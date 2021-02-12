using System;
using System.Collections;
using System.Diagnostics;
using System.Xml;
using SOLID.Models.OpenClosed;
using SOLID.Models.SingleResponsibility;
using SOLID.Models.Specification;
using SOLID.Services.SingleResponsibility;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("========== 1. SOLID : Single Responsibility Principle ==========");
            //
            // var journal = new Journal();
            // journal.AddEntry("This is the first message.");
            // journal.AddEntry("My name is Kyu");
            // Console.WriteLine(journal.ToString());
            //
            // var persistence = new Persistence();
            // var filename = @"/Users/albert/_ref/sw-engineering/ref-sweng-design-patterns/DesignPatterns/SOLID/temp/journal.txt";
            // persistence.SaveToFile(journal, filename, true);
            
            // Console.WriteLine("========== 2. SOLID : Open Closed Principle ==========");
            //
            // var apple = new Product("Apple", Colors.Green, Sizes.Medium);
            // var strawbarry = new Product("Strawbarry", Colors.Red, Sizes.Small); 
            // var pepper = new Product("Pepper", Colors.Green, Sizes.Small);
            // var house = new Product("House", Colors.Blue, Sizes.Huge);
            //
            // var products = new[] {apple, strawbarry, house, pepper};
            //
            // foreach (var product in  ProductFilter.FilterBySize(products, Sizes.Small))
            // {
            //    Console.WriteLine($" > {product.Name} is Small");
            // }
            // // you can expand more methods for new conditions ( e.g. ProductFilter.FiterByColor(products, Colors.Red) )
            
            Console.WriteLine("========== 2-a. SOLID : Specification Pattern ==========");
            
            var apple = new Product("Apple", Colors.Green, Sizes.Medium);
            var strawbarry = new Product("Strawbarry", Colors.Red, Sizes.Small); 
            var pepper = new Product("Pepper", Colors.Green, Sizes.Small);
            var house = new Product("House", Colors.Blue, Sizes.Huge);
            
            var products = new[] {apple, strawbarry, house, pepper};

            foreach (var product in new FilterBySpecification().Filter(products, new SizeSpecification(Sizes.Small)))
            {
                Console.WriteLine($" > {product.Name} is Small");
            }
            // you can simply implement a new specification without poisoning an interface. ( e.g. FilterBySpecification().Filter(products, new ColorSpecification(Colors.Red)) )
            
            
        }
    }
}