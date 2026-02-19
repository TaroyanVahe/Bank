using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Das27.Transport
{
    public class Car : Transportation
    {
        public Car(string model, string platenumber, string transportid, int hp) : base(model, platenumber, transportid, hp)
        {

        }
        public override void CheckTax(int hp)
        {
            Console.WriteLine($"Your tax is {hp*15}$ --- {PlateNumber}");
        }
    }
}
