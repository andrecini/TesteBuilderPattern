using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBuilderFactory
{
    /// <summary>
    ///  O Director é responsável apenas por executar os passos
    /// de construção em uma  sequência particular. Isso é útil
    /// quando está produzindo produtos de acordo com uma ordem
    /// específica de configuração. Estritamente falando, o Di-
    /// rector é opcional, desde que o cliente possa Controlar
    /// a construção diretamente.
    /// </summary>
    class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value;}
        }

        public void BuildMinimalViableProduct()
        {
            this._builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB(); 
            this._builder.BuildPartC();
        }

    }
}
