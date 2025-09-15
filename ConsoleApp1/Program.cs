using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public class Szemely
        {
            public string _nev;
            public int _eletkor;

            public string Nev
            {
                get { return _nev; } //privat adattag kiolvasashoz
                set { _nev = value; }
            }
            public int Eletkor
            {
                get { return _eletkor; }
                set
                {
                    if (value > 0) _eletkor = value;
                    else Console.WriteLine("Nem lehet negatív.");
                }
            }
            public override string ToString()
            {
               
                   return $"A személy neve: {Nev}, kora: {Eletkor}";
                
            }


            /*public Szemely(string nev, int eletkor)
            {
               Nev = nev; Kor = eletkor;
            }

            public string Kiir()
            {
                return $"A személy neve: {Nev}\nÉletkora: {Kor}";
            }*/


        }
        static void Main(string[] args)
        {
            Szemely person = new Szemely();
            person.Eletkor = 45;
            person.Nev = "Feri";
            Console.WriteLine(person);

            //Szemely person = new Szemely("Andris", 124);
            //Console.WriteLine(person.Kiir());
        }
    }
}
