using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class BankSzamla
        {
            private int _egyenleg;

            public int Egyenleg
            {
                get { return _egyenleg; }
                set
                {
                    if (value > 0)
                        _egyenleg = value;
                    else
                        Console.WriteLine("Egyenleg nem lehet nulla");
                }
            }
            public void Betesz() { }
            public void Kivesz() { }

        }


        public class Szemely
        {
            protected string _nev;
            private int _eletkor;



            public string Nev
            {
                get { return _nev; } //privat adattag kiolvasásához
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
                return $"A személy neve: {_nev}, kora: {_eletkor}";
            }



            
            public string Kiir()
            {
                return $"A személy neve: {Nev}\nÉletkora: {Eletkor}";

            }
           
           
        }

        public class Hallgato : Szemely
        {
            private string _neptunkod;

            public string Neptunkod
            {
                get { return _neptunkod; }
                set
                {
                    if (value.Length <= 6)
                    {
                        _neptunkod = value;
                    }
                    else
                        Console.WriteLine("Túl hosszú kód");
                }
            }

            public override string ToString()
            {
                _nev = "Pista";
                return $"A hallgató neve: {_nev}";
            }
        }
        public class Dolgozo : Szemely
        {
            private int _ber;

            public Dolgozo()
            {

            }
            public override string ToString()
            {
                return $"a dolgozó neve: {base.Nev}";
            }
        }


        static void Main(string[] args)
        {
            Szemely person = new Szemely();
            person.Eletkor = 33;
            person.Nev = "Feri";
            Console.WriteLine(person);

            Hallgato student = new Hallgato();
            student.Neptunkod = "123456";
            Console.WriteLine(student);

            List<Hallgato> studentlist = new List<Hallgato>();
            for (int i = 0; i < 3; i++)
            {
                Hallgato student2 = new Hallgato();
                Console.Write($"Kérem a(z) {i + 1} hallgató nevét: ");
                student2.Nev = Console.ReadLine();
                Console.Write($"Kérem a(z) {i + 1} hallgató életkorát: ");
                student2.Eletkor = Convert.ToInt32(Console.ReadLine());
                studentlist.Add(student2);
            }

            foreach (var item in studentlist)
            {
                Console.WriteLine(item.Nev);
            }

            Dolgozo worker = new Dolgozo();


            //Console.WriteLine($"A személy neve: {person.Nev}, kora: {person.Eletkor}");

            //Szemely person = new Szemely("Dani", 67);
            //Console.WriteLine(person.Kiir());
        }
    }
}