using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
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
        public class Hallgato : Szemely
        {
            private string _neptunkod;

            public string Neptunkod
            {
                get { return _neptunkod; }
                set
                {
                    if(value.Length <= 6)
                    {
                        _neptunkod = value;
                    } else
                        Console.WriteLine(" Túl hosszú kód");
                }
            }

            public override string ToString()
            {
                return $"A hallgato neve {_nev}";
            }
        }
        public class Szemely
        {
            protected string _nev;
            private int _eletkor;

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
            person.Eletkor = 96;
            person.Nev = "Kund Béla";
            Console.WriteLine(person);

            Hallgato student = new Hallgato();
            student.Neptunkod = "123456";
            Console.WriteLine(student);


            List<Hallgato> studentlist = new List<Hallgato>();
            for ( int i = 0; i < 3; i++)
            {
                Hallgato student2 = new Hallgato();
                Console.WriteLine($"Kérem a(z) {i+1} hallgató nevét: ");
                student2.Nev = Console.ReadLine();
                Console.WriteLine($"Kérem a(z) {i + 1} hallgató életkorát: ");
                student2.Eletkor = Convert.ToInt32(Console.ReadLine());
                studentlist.Add(student2);
            }
            foreach (var item in studentlist)
            {
                Console.WriteLine(item.Nev);
            }
            //Szemely person = new Szemely("Andris", 124);
            //Console.WriteLine(person.Kiir());
        }
    }
}
