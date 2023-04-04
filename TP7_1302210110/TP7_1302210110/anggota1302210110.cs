using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static jurnal7_1302210110.DataMahasiswa1302210110;


namespace TP7_1302210110
{
    public class anggota1302210110
    {
        public List<courses> matkul { get; set; }

        public anggota1302210110(List<courses> courses)
        {
            this.matkul = courses;
        }

        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\modul7_kelompok_2");

            anggota1302210110 matkul = JsonSerializer.Deserialize<anggota1302210110>(jsonString);

            for (int i = 0; i < anggota1302210110.courses.; i++)
            {
                Console.WriteLine("MK " + (i + 1) + " " + matkul.courses[i].code + " - " + matkul.courses[i].name);
            }

        }

        public class courses
        {
            public String firstName { get; set; }
            public String lastName { get; set; }
            public String gender { get; set; }
            public int age { get; set; }
            public int nim { get; set; }
            
            
            public course(String name1, String namaakhir, String gender, int umur, int nim)
            {
                this.firstName = name1;
                this.lastName = namaakhir;
                this.gender = gender;
                this.age = umur;
                this.nim = nim;

               
            }
        }
    }
}
