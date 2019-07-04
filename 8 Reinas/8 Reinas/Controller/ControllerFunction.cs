using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _8_Reinas.Function;
using _8_Reinas.Model;
using _8_Reinas.View;

namespace _8_Reinas.Controller
{
    public class ControllerFunction
    {
        Algoritmo_Genetico algoritmo = new Algoritmo_Genetico();

        public Dato datos(int pob, int ite, decimal pCru, decimal pMut)
        {
            Dato dato = new Dato();
            dato.iniciar(pob, ite, pCru, pMut);
            return dato;
        }

        public int completo(Dato datos, formHome home)
        {
            home.stStripProgBarIteration.Value = 0;
            home.stStripProgBarIteration.Maximum = datos.Iteraciones;

            algoritmo.llenarPoblacion(datos.Poblacion, home);
            algoritmo.evaluar(home, true);
            for (int i = 0; i < datos.Iteraciones; i++)
            {
                home.stStripLblIteration.Text = "Iteracion " + (i + 1) + "/" + home.stStripProgBarIteration.Maximum;
                Application.DoEvents();

                algoritmo.torneo(home);
                algoritmo.cruce(datos.ProbCruce, home);
                algoritmo.mutacion(datos.ProbMutacion, home);
                algoritmo.evaluar(home, false);
                algoritmo.mejor(home);
                algoritmo.nacimiento(home);

                home.stStripProgBarIteration.PerformStep();
            }

            return algoritmo.apto(home);
        }

        public void pasos(Dato datos, formHome home)
        {
            home.stStripProgBarIteration.Value = 0;
            home.stStripProgBarIteration.Maximum = datos.Iteraciones;

            Algoritmo_Genetico algoritmo = new Algoritmo_Genetico();

            algoritmo.llenarPoblacion(datos.Poblacion, home);
            algoritmo.evaluar(home, true);

            home.Paso = 1;
            home.Iteracion = 0;
        }

        public int? paso(Dato datos, formHome home)
        {
            if (home.Iteracion < datos.Iteraciones)
            {
                switch (home.Paso)
                {
                    case 1:
                        home.toolStripBtnNextIteration.Enabled = false;
                        home.stStripLblIteration.Text = "Iteracion " + (home.Iteracion + 1) + "/" + home.stStripProgBarIteration.Maximum;
                        algoritmo.torneo(home);
                        home.Paso++;
                        break;
                    case 2:
                        algoritmo.cruce(datos.ProbCruce, home);
                        home.Paso++;
                        break;
                    case 3:
                        algoritmo.mutacion(datos.ProbMutacion, home);
                        home.Paso++;
                        break;
                    case 4:
                        algoritmo.evaluar(home, false);
                        home.Paso++;
                        break;
                    case 5:
                        algoritmo.mejor(home);
                        home.Paso++;
                        break;
                    case 6:
                        algoritmo.nacimiento(home);
                        home.toolStripBtnNextIteration.Enabled = true;
                        home.Paso = 1;
                        home.Iteracion++;
                        Application.DoEvents();
                        home.stStripProgBarIteration.PerformStep();
                        break;
                }
            }
            else
            {
                return algoritmo.apto(home);
            }

            return null;
        }

        public int? iteracion(Dato datos, formHome home)
        {
            if (home.Iteracion < datos.Iteraciones)
            {
                home.toolStripBtnNextStep.Enabled = false;
                home.stStripLblIteration.Text = "Iteracion " + (home.Iteracion + 1) + "/" + home.stStripProgBarIteration.Maximum;
                Application.DoEvents();

                algoritmo.torneo(home);
                algoritmo.cruce(datos.ProbCruce, home);
                algoritmo.mutacion(datos.ProbMutacion, home);
                algoritmo.evaluar(home, false);
                algoritmo.mejor(home);
                algoritmo.nacimiento(home);

                home.toolStripBtnNextStep.Enabled = true;
                home.stStripProgBarIteration.PerformStep();
            }
            else
            {
                return algoritmo.apto(home);
            }

            home.Iteracion++;
            return null;
        }

        public void abrirTablero(formHome home)
        {
            formTablero tablero = new formTablero();
            tablero.Reinas = (home.individuoBindingSource.Current as Individuo).Reinas;
            tablero.ShowDialog(home);
        }
    }
}
