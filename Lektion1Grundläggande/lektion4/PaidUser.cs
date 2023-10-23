using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lektion4KlasserObjektPolyArv
{
    internal class PaidUser : UserInfo
    {
        public int monthlyFee { get; set; }
        public PaidUser(int monthlyfee, string name, string email)  : base (name, email)
        { 
            this.monthlyFee = monthlyfee;
        }
        public override void PrintInfo()
        {
            Console.WriteLine(Name + " Pays a monthly fee of: " + monthlyFee + " and his email is:" + Email );
        }
    }
}
