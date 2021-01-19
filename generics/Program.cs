using System;

namespace generics
{
    class tags<T>
    {
        public T data;
        public T[] array = new T[5];

        public void show()
        {
            foreach(var i in array)
            {
                System.Console.WriteLine(i);
            }
            
        }

        public void add(int i,T item)
        {
            
            if(i>=0)
            {
                array[i] = item;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("/////////////Generic class with string type/////////////////");
            tags<string> obj = new tags<string>();
            obj.add(0, "Plate");
            obj.add(1, "Knife");
            obj.add(2, "Spoon");
            obj.add(3, "Fork");

            obj.show();

            System.Console.WriteLine("/////////////Generic class with int type/////////////////");
            tags<int> obji = new tags<int>();
            obji.add(0, 3);
            obji.add(1, 2);
            obji.add(2, 4);
            obji.add(3, 7);

            obji.show();
            

        }
    }
}
