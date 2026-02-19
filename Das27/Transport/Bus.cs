using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Das27.Interfaces;

namespace Das27.Transport
{
    public class Bus:Transportation,IPassangerTransport
    {
        public void Move()
        {
            Console.WriteLine("Its Moving every 20 Minutes");
        }
        public Bus(string model,string platenumber,string transportid,int hp ):base(model,platenumber,transportid,hp)
        {

          
        }
        public override void CheckTax(int hp)
        {
            Console.WriteLine("Public Bus is free of Taxes !!!");
            Console.Write("-------------------------\n");

        }
    }
}
