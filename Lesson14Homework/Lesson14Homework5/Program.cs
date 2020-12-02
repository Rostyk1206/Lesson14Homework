using System;

namespace Lesson14Homework5
{
    class MyClass
    {
        public class Nested
        {
            public void SortArray(int[] array)
            {
                int element = 0;

                for (int bubble = 0; bubble < array.Length; bubble++)
                {
                    for (int sort = 0; sort < array.Length - 1; sort++)
                    {
                        if (array[sort] > array[sort + 1])
                        {
                            element = array[sort + 1];
                            array[sort + 1] = array[sort];
                            array[sort] = element;
                        }
                    }

                }
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass.Nested instance = new MyClass.Nested();
            int[] array = new int[] { 9, 8, 7, 6, 5, 4, 3, 2 };
            instance.SortArray(array);
        }
    }
}