using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRozwiazania
{
    

    class Program
    {
        int wynik;
        int firstnum = 5;
        int secondnum = 3;
        

        enum operatory {Plus, Minus, Pusty }
    
        string PobierzOperator(string wpisane)
        {
            Console.WriteLine("wpisz operator Plus lub Minus: ");
            wpisane = Console.ReadLine();
            Console.WriteLine("wybrany operator to " + wpisane + "");
            return wpisane;

        }
        object WskazDzialanie(string wpisane, operatory ops)
        {
            string end = "end";
            do
            {
                if (wpisane.Equals("Plus"))
                {
                    ops = operatory.Plus;
                    Console.WriteLine("wybrano: " + ops + "");

                    end = "end";
                    return ops;
                }
                else if (wpisane.Equals("Minus"))
                {
                    ops = operatory.Minus;
                    Console.WriteLine("wybrano: " + ops + "");

                    end = "end";
                    return ops;
                }
                else
                {
                    Console.WriteLine("Wpisano niewlasciwy operator:");
                }
                return ops; 
            }while(end!="end");
        }
        void WyborDzialania(operatory ops)
        {
            
        }
        int dodawanie()
        {
            wynik = firstnum + secondnum;
            Console.WriteLine("wynik to :" + wynik + "");
            Console.ReadKey();

            return wynik;
        }
        int odejmowanie()
        {
            wynik = firstnum - secondnum;
            Console.WriteLine("wynik to :" + wynik + "");
            Console.ReadKey();
            return wynik;
        }


        static void Main(string[] args)
        {
            string wpisane = "";
            var ops = operatory.Pusty;
            int wynik = 0;
            

            Program pierwszykrok = new Program();
            wpisane=pierwszykrok.PobierzOperator(wpisane);

            Program drugikrok = new Program();
            var op= drugikrok.WskazDzialanie(wpisane,ops);
            
            Console.WriteLine("nasze dzialanie to " + op +"");
            Program trzecikrok = new Program();
            switch (op)
            {
                case operatory.Plus:
                    {
                        trzecikrok.dodawanie();
                        break;
                    }
                case operatory.Minus:
                    {
                        trzecikrok.odejmowanie();
                        break;
                    }
            }
            Console.ReadKey();


        }





    }



}
