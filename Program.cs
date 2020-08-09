using System;

namespace SOLID_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region Dependency Inversion 
            //ILogger logger = new FileLogger();
            //ProductService productService = new ProductService(logger);
            //productService.Log("Hello World!");
            #endregion
        }

        
    }
}
