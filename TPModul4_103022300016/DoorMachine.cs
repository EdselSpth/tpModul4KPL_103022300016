using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPModul4_103022300016
{
    public enum pintu { terkunci, terbuka };
    public enum kegiatan { bukaPintu, kunciPintu };
    class DoorMachine
    {
        private pintu state;

        public DoorMachine()
        {
            state = pintu.terkunci;
        }

        public void ubahStatePintu(kegiatan opsi)
        {
            switch (state)
            {
                case pintu.terkunci:
                    if (opsi == kegiatan.bukaPintu)
                    {
                        Console.WriteLine("Pintu tidak terkunci");
                        state = pintu.terbuka;
                    }
                    else
                    {
                        Console.WriteLine("Pintu sudah terkunci");
                    }
                    break;

                case pintu.terbuka:
                    if (opsi == kegiatan.kunciPintu)
                    {
                        Console.WriteLine("Pintu terkunci");
                        state = pintu.terkunci;
                    }
                    else
                    {
                        Console.WriteLine("Pintu sudah terbuka");
                    }
                    break;
            }
        }

        public void getStatusPintu()
        {
            Console.WriteLine("Status Pintu: " + state);
        }
    }
}
