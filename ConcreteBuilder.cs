using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBuilderFactory
{
    /// <summary>
    /// A classe Concrete Builder implementa a interface IBuilder
    /// e promove implementações específicas dos passos de cons-
    /// trução. O programa pode ter várias variações de Builders
    /// implementadas de forma diferente.
    /// </summary>
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public void Reset()
        {
            this._product = new Product();
        }

        /// <summary>
        /// Uma nova instância do construtor deve conter um objeto
        /// em branco, no qual é usado no assemby adicional.
        /// </summary>
        public ConcreteBuilder()
        {
            this.Reset();
        }

        // Todos os passos de produção em uma mesma instância
        #region Implementação IBuilder
        public void BuildPartA()
        {
           this._product.Add("Parte A");
        }

        public void BuildPartB()
        {
            this._product.Add("Parte B");
        }

        public void BuildPartC()
        {
            this._product.Add("Parte C");
        }
        #endregion


        /// <summary>
        ///  Os Concrete Builders devem fornecer seus próprios mé-
        /// todos para recuperação de resultados. Isso porque vá-
        /// rios tipos de Construtores podem criar produtos total-
        /// mente diferentes que não precisam seguir a mesma in-
        /// terface. Portanto, tais métodos não podem ser declara-
        /// dos na Interface Builder base (pelo menos em uma lin-
        /// guagem de programação staticamente tipada).
        /// 
        ///  Normalmente, depois de retornar o resultado final 
        /// para o cliente, a instância de Builder é esperada para
        /// ser lida para começar a produção de um outro produto.
        /// É por isso que é uma prática comum chamar o "Reset" no
        /// final do corpo do método "GetProduct". No entanto, este
        /// comportamento não é obrigatório, e você pode fazer seus
        /// construtores esperar por um "Reset" explícito chamado 
        /// no código cliente antes de disponibilizar o resultado.
        /// </summary>
        /// <returns></returns>
        public Product GetProduct()
        {
            Product result = this._product;
                
            this.Reset();

            return result;
        }
    }
}
