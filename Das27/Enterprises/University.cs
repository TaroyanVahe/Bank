using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Das27.Cities;
using Das27.Habitant;

namespace Das27.Enterprises
{
    public class University:Enterprise
    {
       private Dictionary<string,List<int>> _StudentsData=new Dictionary<string,List<int>>();
        protected class Students
        {
            public string Name;
            public string LastName;
            public int StudentID;
            public List<int> Grades=new List<int>();


        }


        public void AddUniverity(City city,University uni)
        {
            city.AddInfo(uni);
        }
        public void RemoveUniversity(City city,University uni)
        {
            city.RemoveInfo(uni);
        }
        public University(string name,int numemployee,int numstudents):base(name,numemployee,numstudents)
        {

        }
    }
}
