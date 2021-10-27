using FirstTask.Entities;
using FirstTask.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var box1 = new FirstDerivedBox();

            var box2 = new SecondDerivedBox();

            BoxService<Box> service = new BoxService<Box>();

            var firstAttrbutes = service.GetAttributes(box1);

            var secondAttributes = service.GetAttributes(box2);

            foreach(var element in firstAttrbutes)
            {
                Console.WriteLine(element.Key + " : " + element.Value.ToString());
            }

            foreach (var element in secondAttributes)
            {
                Console.WriteLine(element.Key + " : " + element.Value.ToString());
            }

            Console.ReadKey();
        }
    }
}
