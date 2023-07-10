using System;
using System.Collections.Generic;

namespace pemrog13
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "2023";
            mhs1.namaMahasiswa = "Asep Budiman";

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "4021";
            mhs2.namaMahasiswa = "Rudi Samsudin";

            List<Mahasiswa> list = new List<Mahasiswa>();
            list.Add(mhs1);
            list.Add(mhs2);


            Console.WriteLine("NIM      NAMA");
            Console.WriteLine("=============");
            foreach(Mahasiswa mhs in list) {
                Console.WriteLine("{0},    {1}", mhs.Nim, mhs.namaMahasiswa);
            }

            Console.ReadKey();

        }
    }
}