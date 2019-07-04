using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _8_Reinas.Model;

namespace _8_Reinas.Controller
{
    public class ControllerFunction
    {
        public Dato datos(int pob, int ite, decimal pCru, decimal pMut)
        {
            Dato dato = new Dato();
            dato.iniciar(pob, ite, pCru, pMut);
            return dato;
        }
    }
}
