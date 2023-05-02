using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obobshenia
{
    class massive<T>
    {
        private List<T> elements=new List<T>();

        public List<T> Elements
        {
            get { return elements; }
        }

        public void Plus(T name) 
        {
            elements.Add(name);
        }

        public T Identify(int i)
        {
            try
            {
                return elements[i];
            }
            catch
            {
                Console.WriteLine("Элемент с данным индексом отсутствует, введите новый \n"); // типа ввели
                return Identify(i-1);
            }
        }

        public void Delete(T element) 
        {
            elements.Remove(element);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            massive<int> intMassive = new massive<int>();

            intMassive.Plus(1);
            intMassive.Plus(2);
            intMassive.Plus(3);

            foreach (var bup in intMassive.Elements)
            {
                Console.WriteLine(bup+"\n");
            }

            Console.WriteLine(intMassive.Identify(3));

            intMassive.Delete(1);
            intMassive.Delete(2);
            intMassive.Delete(3);

            foreach (var bup in intMassive.Elements)
            {
                Console.WriteLine(bup);
            }

            if (intMassive.Elements.Count == 0)
            {
                Console.WriteLine("Список пуст");
            }
            
            massive<string> strMassive = new massive<string>();

            strMassive.Plus("1");
            strMassive.Plus("2");
            strMassive.Plus("3");

            foreach (var bup in strMassive.Elements)
            {
                Console.WriteLine(bup + "\n");
            }

            Console.WriteLine(strMassive.Identify(3));

            strMassive.Delete("1");
            strMassive.Delete("2");
            strMassive.Delete("3");

            foreach (var bup in strMassive.Elements)
            {
                Console.WriteLine(bup);
            }

            if (strMassive.Elements.Count == 0)
            {
                Console.WriteLine("Список пуст");
            }
        }
    }
}
