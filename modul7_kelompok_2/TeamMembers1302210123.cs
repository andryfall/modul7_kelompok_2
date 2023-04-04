using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace modul7_kelompok_2
{
    internal class TeamMembers1302210123
    {
        public List<members> members { get; set; }

        public TeamMembers1302210123(List<members> members)
        {
            this.members = members;
        }

        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\modul7_kelompok_2\\modul7_kelompok_2\\jurnal7_2_1302210123.json");

            TeamMembers1302210123 Anggota = JsonSerializer.Deserialize<TeamMembers1302210123>(jsonString);

            Console.WriteLine("Team member list: ");
            for (int i = 0; i < Anggota.members.Count; i++)
            {
                Console.WriteLine(Anggota.members[i].nim + " " + Anggota.members[i].firstName + " " + Anggota.members[i].lastName + " (" + Anggota.members[i].age + " " + Anggota.members[i].gender  + ")");
            }

        }


    }

    public class members
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String gender { get; set; }
        public int age { get; set; }
        public String nim { get; set; }

        public members(string firstName, string lastName, string gender, int age, String nim)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.nim = nim;
        }
    }
}
