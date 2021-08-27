using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _25._08_ConsoleApp2
{
    class Example
    {
        int _num;
        int _number;
        public int Num
        {
            get { return _num; }
            set { _num = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example();
            Write(" Введите целое число : ");
            example.Num = int.Parse(ReadLine()); // set
            Write("Вы ввели: ");
            WriteLine(example.Num); // get
        }
    }
}

