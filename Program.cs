using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBuilderFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //  O código cliente cria o objeto Builder, passado
            // para o Director e inicializando a construção do
            // processo. O resultado final é recuperado do obj-
            // to Builder.
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Console.WriteLine("Standard basic product:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            // Lembrando que o Builder Pattern pode não utili-
            // zar o Director.
            Console.WriteLine("Custom product:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.Write(builder.GetProduct().ListParts());

            Console.ReadLine();
        }
    }
}
