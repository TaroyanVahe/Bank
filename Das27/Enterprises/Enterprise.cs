using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Das27.Cities;

namespace Das27.Enterprises

{
    public abstract class Enterprise
    {
        public string Name { get; set; }
        public int NumberEmploy {  get; set; }
        private decimal _Income;
        public decimal Income { get { return _Income; } set { _Income = value; } }
        public int NumberOfStudents { get; set; }
        private string _StudentId;
        public string StudentId { get { return _StudentId; } set { _StudentId = value; } }



        protected Enterprise(string name,int numemployee)
        {
            Name=name;
            NumberEmploy=numemployee;
        }
        protected Enterprise(string name,int numemployee,int numstudents)
        {
            Name=name;
            NumberEmploy=numemployee;
            NumberOfStudents=numstudents;
            
        }

    }
}
