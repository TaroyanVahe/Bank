using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Das27.Enterprises;
using Das27.Transport;

namespace Das27.Habitant
{
    public  class Habitants
    {

        public List<string> _UsersBanks=new List<string>();
        public string Name { get; set; }
        public string LastName { get; set; }
        private string _PassportID;

        private List<Car> _cars =new List<Car>();
        

        public string PassportID { get { return _PassportID; } set { _PassportID = value; } }
        public Habitants(string name,string lastname,string passportid)
        {
            Name = name;
            LastName = lastname;
            PassportID = passportid;
            
        }
        public void AddProp(Car car)
        {
            _cars.Add(car);
            

        }
        public void CheckMyProp()
        {
            foreach(var car in _cars)
            {
                Console.Write($"{car.Model} - {car.PlateNumber} - {car.TransportId}");
                Console.WriteLine();
            }
            Console.Write("-------------------------\n");


        }
        public void CheckMyBanks()
        {
            foreach(var item in _UsersBanks)
            {
                Console.WriteLine(item);
            }
        }



    }
}
