using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace modul7_kelompok_2
{
    internal class DataMahasiswa1302210123
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }

        public List<Courses> courses { get; set; }

        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }

            public Address(string streetAddress, string city, string state)
            {
                this.streetAddress = streetAddress;
                this.city = city;
                this.state = state;
            }
        }

        public class Courses
        {
            public string code { get; set; }
            public string name { get; set; }

            public Courses(String code, String name)
            {
                this.code = code;
                this.name = name;
            }
        }

        public DataMahasiswa1302210123(String firstName, String lastName, String gender, int age, Address address, List<Courses> courses) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.address = address;
            this.courses = courses;
        }
        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\modul7_kelompok_2\\modul7_kelompok_2\\jurnal7_1_1302210123.json");

            DataMahasiswa1302210123 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302210123>(jsonString);

            Console.WriteLine("Nama " + mahasiswa.firstName + " " + mahasiswa.lastName + " dengan gender " + mahasiswa.gender + " umur " + mahasiswa.age);
            Console.WriteLine("Bertempat Tinggal di: " + mahasiswa.address.streetAddress + " kota " + mahasiswa.address.city + " Provinsi " + mahasiswa.address.state);
            
            for (int i = 0; i < mahasiswa.courses.Count; i++)
            {
                Console.WriteLine("MK " + (i + 1) + " " + mahasiswa.courses[i].code + " - " + mahasiswa.courses[i].name);
            }

        }
    }
}


