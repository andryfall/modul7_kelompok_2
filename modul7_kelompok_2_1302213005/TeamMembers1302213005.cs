using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_2_1302213005
{
    internal class TeamMembers1302213005
    {
        public List<members> members { get; set; }

        public TeamMembers1302213005(List<members> members)
        {
            this.members = members;
        }

        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\modul7_kelompok_2\\modul7_kelompok_2_1302213005\\jurnal7_2_1302213005.json");

            TeamMembers1302213005 team = JsonSerializer.Deserialize<TeamMembers1302213005>(jsonString);
            Console.WriteLine("Team member list:");
            for (int i = 0; i < team.members.Count; i++)
            {
                Console.WriteLine(team.members[i].nim + " " + team.members[i].firstName + " " + team.members[i].lastName+ "(" + team.members[i].age+" " + team.members[i].gender+")");
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

        public members(String firstName, String lastName, String gender, int age, String nim)
        {
            this.firstName = firstName;
            this.lastName = lastName;   
            this.gender = gender;
            this.age = age;
            this.nim = nim;
        }
    }
}
