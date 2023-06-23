using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace jurnal7_1302210110
{
    public class DataMahasiswa1302210110
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String gender { get; set; }
        public int age { get; set; }
        public address adr { get; set; }
        public course matkul { get; set; }

        public DataMahasiswa1302210110(String firstName, String lastName, String gender, int age, address address, course matkul)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.adr = address;
            this.matkul = matkul;

        }

        public static void ReadJSON()
        {
            String path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            String jsonString = File.ReadAllText(path + "/jurnal7_1_1302210110.json");

            DataMahasiswa1302210110 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302210110>(jsonString);

            Console.WriteLine("mahasiswa dengan nama " + mahasiswa.firstName + mahasiswa.lastName + " kelamin " + mahasiswa.gender + " umur " + mahasiswa.age + " alamat " + mahasiswa.matkul);

        }

        public class address
        {
            public String streetAddress;
            public String city;
            public String state;

            public address(String adr, String city, String state)
            {
                this.streetAddress = adr;
                this.city = city;
                this.state = state;
            }
        }
        public class course
        {
            public String code;
            public String name;

            public course(String code, String name)
            {
                this.code = code;
                this.name = name;
            }
        }
    }


}
