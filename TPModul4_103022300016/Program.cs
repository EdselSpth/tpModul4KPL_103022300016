using System;

namespace TPModul4_103022300016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Daftar Kelurahan");
            Console.WriteLine("===================================");
            Console.WriteLine("Kelurahan \t |    Kode Pos");
            Console.WriteLine("===================================");
            foreach (KodePos.kelurahan kel in Enum.GetValues(typeof(KodePos.kelurahan)))
            {
                String namaKelurahan = kel.ToString();
                Console.WriteLine($"{kel,-16} |     {KodePos.getkodePos(kel)}");
            }
        }
    }
}