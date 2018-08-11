using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy
{
    /// <summary>
    /// ArrayExtensions
    /// </summary>
    public static class ArrayExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="action"></param>
        public static void ForEach(this Array array, Action<Array, int[]> action)
        {
            if (array.LongLength == 0) return;
            ArrayTraverse walker = new ArrayTraverse(array);
            do action(array, walker.Position);
            while (walker.Step());
        }
    }
}
