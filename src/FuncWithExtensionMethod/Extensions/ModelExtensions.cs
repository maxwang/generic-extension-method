using System;
using System.Collections.Generic;
using System.Text;

namespace FuncWithExtensionMethod.Extensions
{
    public static class ModelExtensions
    {
        public static void CreateItem<T>(this T data, Action<int> callback)
        {
            int i = CreateItem(data);
            callback(i);
        }

        private static int CreateItem<T>(T data)
        {
            return 2;
        }
    }
}
