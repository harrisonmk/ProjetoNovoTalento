using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoTalento
{
    public class Calculadora
    {

        private List<string> listahistorico;
        private String data;


        public Calculadora(string data)
        {
            listahistorico = new List<string>();
            this.data = data;
        }

        public int somar(int x,int y)
        {
            int res = x+y;
            listahistorico.Insert(0, "Res: " + res + " - data: "+data);
            return res;
        }

        public int subtrair(int x, int y)
        {
            int res = x - y;
            listahistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }

        public int multiplicar(int x, int y)
        {
            int res = x * y;
            listahistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }

        public int dividir(int x, int y)
        {
            int res = x / y;
            listahistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }

        public List<string> historico()
        {
            listahistorico.RemoveRange(3, listahistorico.Count);
            return listahistorico;
        }
    }
}
