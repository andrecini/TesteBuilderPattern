using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBuilderFactory
{
    /// <summary>
    /// A Interface Builder especifica os métodos para criar
    /// diferentes partes dos objetos Produtos
    /// </summary>
    public interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        void BuildPartC();
    }
}
