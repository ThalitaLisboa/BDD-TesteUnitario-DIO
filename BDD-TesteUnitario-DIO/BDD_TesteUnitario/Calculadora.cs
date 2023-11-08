using System;
using System.Collections.Generic;
using System.Text;

namespace BDD_TesteUnitario
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;
        
        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;

        }

        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;

            listaHistorico.Insert(0, "Resultado: " + res + " - data: " + data);
            return res;

            // return val1 + val2
        }

        public int Subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            listaHistorico.Insert(0, "Resultado: " + res + " - data: " + data);
            return res;
        }

        public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            listaHistorico.Insert(0, "Resultado: " + res + " - data: " + data);
            return res;
        }

        public int Dividir(int val1, int val2)
        {
            int res = val1 / val2;
            listaHistorico.Insert(0, "Resultado: " + res + " - data: " + data);
            return res;
        }

        public List<string> historico()
        {
           
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3); //Para remover aqueles além dos 3 que preciso.
            return listaHistorico; 
        }
    }
}
