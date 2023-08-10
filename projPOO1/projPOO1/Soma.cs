using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace projPOO1
{
    internal class Soma
    {
        #region Atributos
        private int n1;
        private int n2;
        private int resultado;
        #endregion

        #region MetodosInterface
        public void setN1(int p)
        {
            n1 = p;
        }
        public void setN2(int p)
        {
            n2 = p;
        }
        public int getN1()
        {
            return n1;
        }
        public int getN2()
        {
            return n2;
        }
        public int getResultado()
        {
            return resultado;
        }
        #endregion

        #region MetodosFuncionais
        public void calcular()
        {
            resultado = n1 + n2;
        }
        #endregion
    }
}
