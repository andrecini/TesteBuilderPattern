using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBuilderFactory
{
    /// <summary>
    ///  Faz sentido usar o Builder Pattern apenas quando seus 
    /// produtos são bastante complexos e exigem uma configura-
    /// ção extensa.
    /// 
    ///  Ao contrário de outros Creational Patterns, diferentes
    /// construtores podem produzir produtos não relacionados. Em
    /// outras palavras, resultados de vários construtores nem
    /// sempre podem seguir a mesma interface.
    /// </summary>
    public class Product
    {
        private List<Object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); //Remove a última ", "

            return "Product Parts: " + str + ".\n";
        }

    }
}
