using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy
{
    public static class MappingExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">source for copy</param>
        /// <param name="template"> result type</param>
        /// <returns></returns>
        public static T CopyFrom<T>(this T source, object template)
        {
            return (T)DeepCopy.Copy(template);
        }
    }
}
