using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_2
{
    internal class DataMahasiswa1302213005
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<courses> courses { get; set; }

        public DataMahasiswa1302213005(String firstName, String lastName, String gender, int age, Address address, List<courses> courses) { 
            this.firstName= firstName;
            this.lastName= lastName;
            this.gender= gender;
            this.age = age;
            this.address = address;
            this.courses = courses;

        }
        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\modul7_kelompok_2\\modul7_kelompok_2_1302213005\\jurnal7_1_1302213005.json");

            DataMahasiswa1302213005 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302213005>(jsonString);

            Console.WriteLine("Nama "+mahasiswa.firstName+" "+mahasiswa.lastName+" jenis kelamin "+mahasiswa.gender+" umur "+mahasiswa.age+" Alamat : "+mahasiswa.address.streetAddress +" "+ mahasiswa.address.city+" "+ mahasiswa.address.state );
            for (int i = 0; i < mahasiswa.courses.Count; i++)
            {
                Console.WriteLine("MK " + (i + 1) + " " + mahasiswa.courses[i].code + " - " + mahasiswa.courses[i].name);
            }

        }
    }

    public class Address
    {
        public String streetAddress { get; set; }
        public String city { get; set; }
        public String state { get; set; }

        public Address(String streetAddress, String city, String state)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
        }
    }

    public class courses
    {
        public String code { get; set; }
        public String name { get; set; }

        public courses(String code, String name)
        {
            this.code = code;
            this.name = name;
        }
    }
}
