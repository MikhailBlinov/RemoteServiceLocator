using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocator
{
    interface IInjection
    {
        void Test();
    }

    class MyInjection : IInjection
    {
        public void Test()
        {
            Console.WriteLine("Test injection string");
        }
    }

    class ForDependencyInjection
    {
        private IInjection _injection;
        public ForDependencyInjection(IInjection injection)
        {
            _injection = injection;
        }

        public void Test()
        {
            _injection.Test();
        }
    }
}
