using FirstTask.Entities;
using FirstTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.Services
{
    public class BoxService<T> : IService<T>
    {
        public IDictionary<string, object> GetAttributes(T obj)
        {
            var dict = new Dictionary<string, object>();
            if(obj.GetType().BaseType == typeof(Box))
            {
                PropertyInfo[] info = obj.GetType().GetProperties();

                foreach(var i in info)
                {
                    if(i.CustomAttributes.Where(x => x.AttributeType == typeof(BoxFieldAttribute)) != null)
                    {
                        dict.Add(i.Name, i.GetValue(obj));
                    }
                }
            }

            return dict;
        }

    }
}
