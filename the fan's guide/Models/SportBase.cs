using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_fan_s_guide.Models
{
    public class SportBase
    {
        public bool Changed { get; set; }
        public SportBase()
        {
            Sportsmen = new List<Sportsman>();
        }
        public List<Sportsman> Sportsmen { get; set; }
        //public void TestData(int k)
        //{
        //    Sportsmen = new List<Sportsman>();
        //    for (int i = 0; i < k; i++)
        //    {
        //        var sportsman = new Sportsman
        //        {
        //            FirstName = "First" + i,
        //            LastName = "Last" + i,
        //            Citizenship = "Country" + i,
        //            Nationality = "Nationality" + i,
        //            Height = 150 + i,
        //            Sport = "Sport" + i,
        //            Team = "Team" + i,
        //            PersonalRecord = "Record" + i,
        //            Recordsman = "no"
        //        };
        //        Sportsmen.Add(sportsman);
        //    }
        //    Changed = true;
        //}

        internal List<Sportsman> SearchSportsmen(string text)
        {
            List<Sportsman> res = new List<Sportsman>();
            foreach (Sportsman sportsman in Sportsmen)
            {
                if (sportsman.FirstName.ToLower().IndexOf(text.ToLower()) > -1 || sportsman.LastName.ToLower().IndexOf(text.ToLower()) > -1 || sportsman.Sport.ToLower().IndexOf(text.ToLower()) > -1)
                {
                    res.Add(sportsman);
                }
            }
            return res;
        }

        internal List<Sportsman> SearchRecordsman(string sportLine)
        {
            List<Sportsman> recordsmanRes = new List<Sportsman>();
            foreach (Sportsman sportsman in Sportsmen)
            {
                if(sportsman.Sport.ToLower()== sportLine.ToLower() && sportsman.Recordsman.ToLower() == "yes")
                {
                    recordsmanRes.Add(sportsman);
                }
            }
            return recordsmanRes;
        }
    } 
}

