using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocator
{
        public class ServiceLocator
        {
            private static Dictionary<object, object> _service = new Dictionary<object, object>();

            public static void RegisterObject(object obj)
            {
                _service[obj.GetType()] = obj;
            }

            public static T Get<T>()
            {
                return (T)_service[typeof(T)];
            }
        }
}
