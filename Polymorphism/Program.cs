using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Dada---------");
            var d = new Dada();
            Console.WriteLine(d.Dhumpan("huka"));

            Console.WriteLine("------------Bap---------");
            var b = new Bap();
            Console.WriteLine(b.Dhumpan("huka"));
            Console.WriteLine(b.Dhumpan("huka", "biri"));

            Console.WriteLine("------------Pola---------");
            var p = new Pola();
            Console.WriteLine(p.Dhumpan("huka"));
            Console.WriteLine(p.Dhumpan("pipe", "ebiri"));
            Console.ReadLine();
        }
    }

    public class Dada
    {
        public string Dhumpan(string huka)
        {
            return $"{huka}: Dhoya";
        }
    }

    public class Bap: Dada
    {
        public virtual string Dhumpan(string huka, string biri)
        {
            return $"{huka} & {biri}: Dhoya";
        }
        public string Dhumpan(string huka, int biri)
        {
            return $"{huka} & {biri}: Dhoya";
        }
        public int Dhumpan(int biri, string huka)
        {
            return 1;
        }
    }

    public class Pola : Bap
    {
        public override string Dhumpan(string pipe, string ebiri)
        {
            return $"{pipe} & {ebiri}: More Dhoya";
        }
    }
}
