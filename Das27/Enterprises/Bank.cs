using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Das27.Cities;
using Das27.Habitant;

namespace Das27.Enterprises
{
    public  class Bank:Enterprise
    {
        protected class Bankuser
        {
            public string ClientName { get; set; }
            private string _PassportInfo;
            public string PassportInfo { get { return _PassportInfo; } set { _PassportInfo = value; } }
            
            private decimal _Balance;
            public decimal Balance { get { return _Balance; }set { _Balance = value; } }

        }
       
        private Dictionary<string,Bankuser> _BankUsersData  = new Dictionary<string,Bankuser>();

        public void BecomeClient(Habitants citizen)
        {
            Bankuser user = new Bankuser();
            user.ClientName=citizen.Name;
            user.PassportInfo = citizen.PassportID;
            user.Balance = 0;


    
            _BankUsersData.Add(user.PassportInfo,user);
            citizen._UsersBanks.Add(Name);
        }
        public void RemoveClient(Habitants citizen)
        {
            _BankUsersData.Remove(citizen.PassportID);

        }

        
        public void Payment(Habitants citizen)
       {
            if(_BankUsersData.ContainsKey(citizen.PassportID))
            {
                Console.WriteLine("Withdraw 1 | Deposit 2 | Balance  0 | Exit 5");
                int comande = Convert.ToInt32(Console.ReadLine());

                if (comande == 0)
                {
                    Console.Write($"Your balance is {_BankUsersData[citizen.PassportID].Balance}$\n");
                    Payment(citizen);
                }
                else if (comande == 1)// withdraw
                {
                    Console.WriteLine("Input the money");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                    if (_BankUsersData[citizen.PassportID].Balance >= amount)
                    {
                        _BankUsersData[citizen.PassportID].Balance = _BankUsersData[citizen.PassportID].Balance - amount;
                        Payment(citizen);


                    }
                    else
                    {
                        Console.WriteLine("You dont have enough money to withdraw");
                        Payment(citizen);

                    }
                }
                else if (comande == 2)// deposit
                {
                    Console.WriteLine("Input the money");

                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                    if (amount > 0)
                    {
                        _BankUsersData[citizen.PassportID].Balance = _BankUsersData[citizen.PassportID].Balance + amount;
                        Payment(citizen);

                    }
                    else
                    {
                        Console.WriteLine("Deposit the number above 0");
                    }
                }
                else if(comande==5)
                {
                    return;

                }
                else 
                {
                    Console.WriteLine("Please select from the provided options");
                    Payment(citizen);



                }

            }
            else
            {
                Console.WriteLine($"{citizen.Name }{citizen.LastName} -- You arent client of {Name}");
            }
            

        }
        public void CheckUserData()
        {
            if (_BankUsersData == null)
            {
                Console.WriteLine($"In the {Name} there is no user");
            }
            else
            {
                Console.WriteLine($"--------{Name}------");
                foreach(var item in _BankUsersData)
                {
                    Console.WriteLine($"{item.Value.ClientName} {item.Key} {item.Value.Balance}$");
                }

            }

        }
       
        public   void AddEnterprise(City city, Bank bank)
        {
            city.AddInfo(bank);

        }


        public void RemoveEnterprise(City city,Bank bank)
        {
            city.RemoveInfo(bank);
        }

        public Bank(string name,int numemployee):base(name,numemployee)
        {
            
        }

        public decimal GetUserBalance(Habitants citizen)
        {
            
                if(_BankUsersData.ContainsKey(citizen.PassportID))
                {
                    return _BankUsersData[citizen.PassportID].Balance;
                }
            
            return -1;
        }
        public void TaxUser(Habitants citizen,decimal tax)
        {
            if(_BankUsersData.ContainsKey(citizen.PassportID))
            {
                _BankUsersData[citizen.PassportID].Balance = _BankUsersData[citizen.PassportID].Balance - tax;

            }
            else
            {
                Console.WriteLine("There is no such kind of user in this bank");
            }
        }
    }
}
