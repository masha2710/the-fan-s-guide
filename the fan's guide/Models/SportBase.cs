using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_fan_s_guide.Models
{
    public class SportBase
    {
        public SportBase()
        {

        }
        public List<Sportsman> Sportsmen { get; set; }
        public void TestData(int k)
        {
            Sportsmen = new List<Sportsman>();
            for(int i = 0; i < k; i++)
            {
                var sportsman = new Sportsman
                {
                    Name = "Name" + i,
                    Citizenship = "Country" + i,
                    Nationality = "Nationality" + i,
                    Height = 150 + i + "m",
                    Sport = "Sport" + i,
                    Team = "Team" + i,
                    PersonalRecord = "Record" + i,
                    Recordsman = "no"
                };
                Sportsmen.Add(sportsman);
            }
        }
    } 
}

