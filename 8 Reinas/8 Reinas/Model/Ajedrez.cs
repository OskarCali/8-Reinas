using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Reinas.Model
{
    class Individuo : ICloneable
    {
        #region Variables
        private int _num;
        private int _r1, _r2, _r3, _r4, _r5, _r6, _r7, _r8;
        private int _fitness;
        #endregion

        #region Propiedades
        public int Num
        {
            get { return _num; }
        }
        public int R1
        {
            get { return _r1; }
        }
        public int R2
        {
            get { return _r2; }
        }
        public int R3
        {
            get { return _r3; }
        }
        public int R4
        {
            get { return _r4; }
        }
        public int R5
        {
            get { return _r5; }
        }
        public int R6
        {
            get { return _r6; }
        }
        public int R7
        {
            get { return _r7; }
        }
        public int R8
        {
            get { return _r8; }
        }

        public int Fitness
        {
            get { return _fitness / 2; }
        }

        public List<int> Reinas
        {
            get { return new List<int>() {R1, R2, R3, R4, R5, R6, R7, R8}; }
        }

        //public virtual List<Reina> ReinasColision { get; set; }
        #endregion

        #region Metodos

        public void iniciar(List<int> reinas, int num)
        {
            _num = num + 1;

            _r1 = reinas[0];
            _r2 = reinas[1];
            _r3 = reinas[2];
            _r4 = reinas[3];
            _r5 = reinas[4];
            _r6 = reinas[5];
            _r7 = reinas[6];
            _r8 = reinas[7];

            _fitness = 0;
        }

        public void colision(/*int reinaPos, int colision*/)
        {
            _fitness++;
            //var r = ReinasColision.FirstOrDefault(x => x.Pos == reinaPos);
            //r.Colisiones.Add(colision);
        }

        public void igualar(int num)
        {
            _num = num;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    }

    public class Dato
    {
        #region Variables
        private int _poblacion;
        private int _iteraciones;
        private decimal _probCruce;
        private decimal _probMutacion;
        #endregion

        #region Propiedades
        public int Poblacion
        {
            get { return _poblacion; }
        }
        public int Iteraciones
        {
            get { return _iteraciones; }
        }
        public decimal ProbCruce
        {
            get { return _probCruce; }
        }
        public decimal ProbMutacion
        {
            get { return _probMutacion; }
        }
        #endregion

        #region Metodos
        public void iniciar(int pob, int ite, decimal pCru, decimal pMut)
        {
            _poblacion = pob;
            _iteraciones = ite;
            _probCruce = pCru;
            _probMutacion = pMut;
        }
        #endregion
    }

    //class Reina
    //{
    //    private int _pos;
    //    private List<int> _colisiones;

    //    public int Pos { get; set; }
    //    public List<int> Colisiones { get; set; }
    //}
}
