using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace mod7_130221026_yosuawilliampallunan
{
    internal class DataMahasiswa1302210126
    {
        public string firstName { get; set; }

        public string LastName { get; set; }

        public string gender { get; set; }

        public int age { get; set; }

        public Address address { get; set; }

        public Course course { get; set; }

        public DataMahasiswa1302210126(string firstName, string LastName, string gender, int age, Address address, Course course)
        {
            this.firstName = firstName;
            this.LastName = LastName;
            this.gender = gender;
            this.age = age;
            this.address = address;
            this.course = course;
        }

        public static void ReadJSON()
        {

        }
    }
}
