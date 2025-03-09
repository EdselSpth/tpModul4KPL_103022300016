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

            Console.WriteLine("\n===================================");
            DoorMachine door = new DoorMachine();

            door.getStatusPintu();
            String input = "";
            while (input != "exit")
            {
                Console.WriteLine("Masukkan Perintah (bukaPintu/kunciPintu)");
                input = Console.ReadLine();
                if (Enum.TryParse(input, out kegiatan trigger))
                {
                    door.ubahStatePintu(trigger);
                }
                else
                {
                    Console.WriteLine("Perintah tidak valid. Coba lagi.");
                }
                Console.WriteLine("===================================");
            }
        }
    }
}