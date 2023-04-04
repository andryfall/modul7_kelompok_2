using mod7_130221026_yosuawilliampallunan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace mod7_1302210126_yosuawilliampallunan
{
    internal class MOD7_1302210126
    {
        public class DataMahasiswa1302210126
        {
            public string firstName { get; set; }

            public string LastName { get; set; }

            public string gender { get; set; }

            public int age { get; set; }

            public address adr { get; set; }

            public course matkul { get; set; }

            public DataMahasiswa1302210126(string firstName, string LastName, string gender, int age, address adr, course matkul)
            {
                this.firstName = firstName;
                this.LastName = LastName;
                this.gender = gender;
                this.age = age;
                this.adr = adr;
                this.matkul = matkul;
            }
            public static void ReadJSON()
            {
                String jsonString = File.ReadAllText("D:\\modul7_kelompok_2\\mod7_1302210126_yosuawilliampallunan");

                DataMahasiswa1302210126 mahasiswa =
                JsonSerializer.Deserialize<DataMahasiswa1302210126>(jsonString);

                Console.WriteLine("mahasiswa dengan nama " + mahasiswa.firstName + mahasiswa.LastName + "kelamin" + mahasiswa.gender + "umur" + mahasiswa.age + "alamat" mahasiswa.matkul);
            }
        }


        
        public class address
        {
            public string streetAddress;
            public string city;
            public string state;

            public address(string adr, string city, string state)
            {
                this.streetAddress = adr;
                this.city = city;
                this.state = state;
            }
        }

        public class course
        {
            public string code;
            public string name;

            public course(String code , string name)
            {
                this.code = code;
                this.name = name;
            }
        }
    }
}
