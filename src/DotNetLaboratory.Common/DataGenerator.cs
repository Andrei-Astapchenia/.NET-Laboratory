using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetLaboratory.Common
{
    public static class DataGenerator
    {
        private static readonly Random RND = new();

        public static int[] RandomIntArray(int size, int min = 0, int max = 10000)
        {
            var array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = RND.Next(min, max);
            }
            return array;
        }
        public static int[] SimplyKidSortedArray(int size)
        {
             var array= new int[size];
            for (int i = 0; i < size; ++i) array[i] = i;
            return array;
        }
        public static int[] ReversedSimplyKidSortedArray(int size)
        {
             var array= new int[size];
            for (int i = 0; i < size; ++i) array[i] = size - i;
            return array;
        }
        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var buffer = new char[length];
            for (int i=0;i<length; ++i)
            {
                buffer[i] = chars[RND.Next(chars.Length)];
            }
            return new string(buffer);
        }
    }
}
