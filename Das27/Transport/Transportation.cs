using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Das27.Transport
{
    public abstract class Transportation
    {
        public string Model { get; set; }
        public string PlateNumber { get; set; }
        public int HP { get; set; }
        private string _TransportId {  get; set; }

        public string TransportId {
            get
            {  return _TransportId; }
            set { _TransportId = value; }
        }
        protected Transportation(string model,string platenumber,string transportid,int hp)
        {
            Model = model;
            PlateNumber = platenumber;
            TransportId = transportid;
            HP = hp;
            
        }
        public abstract void CheckTax(int hp);
        
           

        


    }
}
