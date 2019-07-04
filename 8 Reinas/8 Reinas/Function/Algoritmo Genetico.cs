using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _8_Reinas.Model;
using _8_Reinas.View;

namespace _8_Reinas.Function
{
    class Algoritmo_Genetico
    {
        private List<Individuo> _Individuos { get; set; }
        private List<Individuo> _Padres { get; set; }
        private List<Individuo> _Hijos { get; set; }
        private List<Individuo> _Mejores { get; set; }

        public void llenarPoblacion(int poblacion, formHome home)
        {
            List<int> reinas = new List<int>(8);
            home.stStripProgBarStep.Value = 0;
            home.stStripProgBarStep.Maximum = poblacion;

            for (int i = 0; i < poblacion; i++)
            {
                home.stStripLblStep.Text = "Individuo " + (i + 1) + "/" + poblacion;
                Application.DoEvents();

                reinas.Clear();
                for (int j = 0; j < 8; j++)
                {
                    int pos;
                    do
                    {
                        pos = new Random().Next(1, 9);
                    } while (reinas.Contains(pos));

                    reinas.Add(pos);
                }

                Individuo individuo = new Individuo();
                individuo.iniciar(reinas, i);

                _Individuos.Add(individuo);
                home.stStripProgBarStep.PerformStep();
            }

            actualizar(home);
        }

        public void evaluar(formHome home)
        {
            home.stStripProgBarStep.Value = 0;
            home.stStripProgBarStep.Maximum = _Individuos.Count;

            foreach (var individuo in _Individuos)
            {
                home.stStripLblStep.Text = "Evaluando individuo " + individuo.Num + "/" + _Individuos.Count;
                Application.DoEvents();
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (i == j)
                        {
                            continue;
                        }

                        if (Math.Abs(individuo.Reinas[i] - individuo.Reinas[j]) == Math.Abs(i - j))
                        {
                            individuo.colision();
                        }
                    }
                }

                home.stStripProgBarStep.PerformStep();
            }

            actualizar(home);
        }

        public void torneo(formHome home)
        {
            int potencial1, potencial2;
            int? usado = null;

            home.stStripProgBarStep.Value = 0;
            home.stStripProgBarStep.Maximum = 2;

            for (int i = 0; i < 2; i++)
            {
                home.stStripLblStep.Text = "Obteniendo padre " + (i + 1) + "/2";
                Application.DoEvents();

                do
                {
                    potencial1 = new Random().Next(0, _Individuos.Count);
                    potencial2 = new Random().Next(0, _Individuos.Count);
                } while (potencial2 == potencial1 || potencial1 == usado || potencial2 == usado);

                if (_Individuos[potencial1].Fitness <= _Individuos[potencial2].Fitness)
                {
                    usado = potencial1;
                    _Padres.Add(_Individuos[potencial1].Clone() as Individuo);
                }
                else
                {
                    usado = potencial2;
                    _Padres.Add(_Individuos[potencial2].Clone() as Individuo);
                }

                home.stStripProgBarStep.PerformStep();
            }
        }

        public void cruce(decimal pCruce, formHome home)
        {
            home.stStripProgBarStep.Value = 0;
            home.stStripProgBarStep.Maximum = 2;

            decimal pc = (decimal)new Random().NextDouble();

            if (pc <= pCruce)
            {
                int pos = new Random().Next(0, 8);
                List<int> posHijo = new List<int>(8);

                for (int i = 0; i < 2; i++)
                {
                    home.stStripLblStep.Text = "Obteniendo hijo " + (i + 1) + "/2";
                    Application.DoEvents();

                    int aux = pos;
                    posHijo.Clear();
                    posHijo.AddRange(_Padres[i].Reinas.GetRange(0, pos));

                    for (int j = 0; j < 8 && aux < 8; j++)
                    {
                        switch (i)
                        {
                            case 0:
                                if (!posHijo.Contains(_Padres[i + 1].Reinas[j]))
                                {
                                    posHijo.Add(_Padres[i + 1].Reinas[j]);
                                    aux++;
                                }
                                break;
                            case 1:
                                if (!posHijo.Contains(_Padres[i - 1].Reinas[j]))
                                {
                                    posHijo.Add(_Padres[i - 1].Reinas[j]);
                                    aux++;
                                }
                                break;
                        }
                    }

                    Individuo individuo = new Individuo();
                    individuo.iniciar(posHijo, i);

                    _Hijos.Add(individuo);
                    home.stStripProgBarStep.PerformStep();
                }
            }
            else
            {
                foreach (var individuo in _Padres)
                {
                    _Hijos.Add(individuo.Clone() as Individuo);
                    home.stStripProgBarStep.PerformStep();
                }
            }
        }

        public void mutacion(decimal pMutacion, formHome home)
        {
            home.stStripProgBarStep.Value = 0;
            home.stStripProgBarStep.Maximum = 2;

            decimal pm = (decimal)new Random().NextDouble();
            if (pm <= pMutacion)
            {
                int pos1, pos2;

                pos1 = new Random().Next(0, 8);
                do
                {
                    pos2 = new Random().Next(0, 8);
                } while (pos2 == pos1);

                for (int i = 0; i < 2; i++)
                {
                    home.stStripLblStep.Text = "Mutando hijo " + (i + 1) + "/2";
                    Application.DoEvents();
                    List<int> posReinas = _Hijos[i].Reinas;

                    int val1 = posReinas[pos1];
                    posReinas[pos1] = posReinas[pos2];
                    posReinas[pos2] = val1;

                    home.stStripProgBarStep.PerformStep();
                }
            }
        }

        public void mejor(formHome home)
        {
            home.stStripProgBarStep.Value = 0;
            home.stStripProgBarStep.Maximum = 2;

            List<Individuo> aux = new List<Individuo>();
            aux.AddRange(_Padres);
            aux.AddRange(_Hijos);

            int? usado = null;
            int sel;

            for (int i = 0; i < 2; i++)
            {
                home.stStripLblStep.Text = "Calculando al mejor " + (i + 1) + "/2";
                Application.DoEvents();

                sel = 0;
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (j != k && k != usado && sel != k)
                        {
                            if (!(aux[sel].Fitness <= aux[k].Fitness))
                            {
                                sel = k;
                            }
                        }
                    }
                }
                usado = sel;

                _Mejores.Add(aux[(int) usado].Clone() as Individuo);
                home.stStripProgBarStep.PerformStep();
            }
        }

        public void nacimiento(formHome home)
        {
            home.stStripProgBarStep.Value = 0;
            home.stStripProgBarStep.Maximum = 2;

            for (int i = 0; i < 2; i++)
            {
                home.stStripLblStep.Text = "Cambiando individuo " + (i + 1) + "/2";
                Application.DoEvents();
                _Mejores[i].igualar(_Padres[i].Num);

                _Individuos[_Individuos.IndexOf(_Individuos.FirstOrDefault(x => x.Num == _Padres[i].Num))] = _Mejores[i];
                home.stStripProgBarStep.PerformStep();
            }

            _Hijos.Clear();
            _Padres.Clear();
            _Mejores.Clear();
        }

        public void actualizar(formHome home)
        {
            home.individuoBindingSource.DataSource = _Individuos;
            home.individuoDataGridView.Update();
            home.individuoDataGridView.Refresh();
        }
    }
}
