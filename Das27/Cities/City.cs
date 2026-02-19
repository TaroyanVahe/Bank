using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Das27.Enterprises;
using Das27.Habitant;
using Das27.Transport;

namespace Das27.Cities
{
    public class City
    {
        private string _MayorName {  get; set; }
        public string MayorName { get { return _MayorName; } set {_MayorName = value; } }
        
        public Transportation transport { get; set; }
        private Dictionary<string,Habitants> _CitizenData=new Dictionary<string, Habitants>();

        private Dictionary<string, int> BanksEmployee =new Dictionary<string, int>();
        private Dictionary<string,int> Universities=new Dictionary<string,int>();
        private Dictionary<string, int> Shops = new Dictionary<string, int>();
        private Dictionary<string, int> Others = new Dictionary<string, int>();

        private List<Bank> ListOfBanks=new List<Bank>();

       public void GetTax(Habitants citizen,decimal tax)
        {
            

            foreach (var item in ListOfBanks)
            {
                if(item.GetUserBalance(citizen)==-1)
                {
                    continue;
                }
                else
                {
                    item.TaxUser(citizen,tax);
                    break;
                }
            }

        }

        
        public void Datacheck()
        {
           foreach(var user in _CitizenData.Values)
            {
                Console.Write($"{user.Name} - {user.LastName} - {user.PassportID}");
                Console.WriteLine();
                user.CheckMyProp();
            }
            Console.Write("-------------------------\n");



        }
        public void RemoveInfo(object value)
        {
            if (value is Bank bank)
            {
                BanksEmployee.Remove(bank.Name);
            }
            else if (value is University uni)
            {
                Universities.Remove(uni.Name);
            }
        }
        public void AddInfo(object value)
        {
            if (value is Bank bank)
            {
                BanksEmployee.Add(bank.Name, bank.NumberEmploy);

                ListOfBanks.Add(bank);


            }
            else if(value is Habitants citizen)
            {
                _CitizenData.Add(citizen.PassportID, citizen);


            }
            else if (value is University university)
            {
                Universities.Add(university.Name, university.NumberOfStudents);


            }
             
            
        }

        

        public void ChecEnterprisesInfo(object value)
        {
            if (value is Bank )
            {
                foreach (var item in BanksEmployee)
                {
                    Console.Write($"{item.Key} --- {item.Value}");
                    Console.WriteLine();
                }
                Console.Write("-------------------------\n");

            }
            else if(value is University)
            {
                foreach (var item in Universities)
                {
                    Console.Write($"{item.Key} --- {item.Value} Students");
                    Console.WriteLine();
                }
                Console.Write("-------------------------\n");
            }
            

        }

       
       
    }
}
