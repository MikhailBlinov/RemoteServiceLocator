using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocator
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            FirstClass first = new FirstClass() {FirstProperty = "first"};
            SecondClass second = new SecondClass() {SecondProperty = "second"};
            ThirdClass third = new ThirdClass() {ThirdProperty = "third"};


            ServiceLocator.RegisterObject(first);
            ServiceLocator.RegisterObject(second);
            ServiceLocator.RegisterObject(third);

            FirstClass f = ServiceLocator.Get<FirstClass>();
            Console.WriteLine(f.FirstProperty);

            SecondClass s = ServiceLocator.Get<SecondClass>();
            Console.WriteLine(s.SecondProperty);
            ThirdClass t = ServiceLocator.Get<ThirdClass>();
            Console.WriteLine(t.ThirdProperty);


            IInjection obj = new MyInjection();

            ForDependencyInjection injection = new ForDependencyInjection(obj);
            injection.Test();

            Console.Read();
        }
    }


    internal class FirstClass
    {
        public string FirstProperty { get; set; }
    }

    internal class SecondClass
    {
        public string SecondProperty { get; set; }
    }


    internal class ThirdClass
    {
        public string ThirdProperty { get; set; }
    }

}
