using System;

namespace Exercise6
{
    public class Exercise6
    {
        public readonly int[] MyArray1 = new int[10];
        public readonly int[] MyArray2 = new int[10];

        public string DisplayBothArrays()
        {
            return "Array 1: " + string.Join(" ", CreateRndArray()) + 
            "Array 2: " + string.Join(" ", ArrayFromRndArray(CreateRndArray()));
        }

        public int[] CreateRndArray()
        {
            for (var i = 0; i < MyArray1.Length; i++)
            {
                var rd = new Random();
                MyArray1[i] = rd.Next(1, 101);
            }

            return MyArray1;
        }

        public int[] ArrayFromRndArray(int[] MyArray1)
        {
            MyArray1.CopyTo(MyArray2, 0);
            MyArray1[9] = -7;
            return MyArray2;
        }
    }
}
