using System;

namespace NIX_Home_Work_1
{

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Print();
            r.Scope(2);
            r.Shift(5,5);
            Console.WriteLine(new string ("*"), 20);
            
            Triangle t = new Triangle();
            t.Print();
            t.Scope(2);
            t.Shift(5, 5);
            Console.WriteLine(new string("*"), 20);

            Circle c = new Circle();
            c.Print();
            c.Scope(2);
            c.Shift(5, 5);
            Console.WriteLine(new string("*"), 20);

            Iamge i = new Iamge(r);
            i.Print();
            i.Shift(10, 10);
            i.Scope(5);

                Console.ReadKey();
        }
    }
}
