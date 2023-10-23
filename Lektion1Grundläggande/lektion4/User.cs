using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lektion4KlasserObjektPolyArv
{
    internal class User
    {
        List<UserInfo> users = new List<UserInfo>();
        List<PaidUser> paidusers = new List<PaidUser>();
        public void run()
        {
            {
                UserInfo Tim = new UserInfo("Bennyblader", " Bennyblade@mail.com");
                UserInfo Robert = new UserInfo("Brntg", "Brntg@mail.com");
                UserInfo Jonas = new UserInfo("Jwns", "Jwns@mail.com");

                PaidUser Karl = new PaidUser(10000, "Kalle", " Kalle@mail.com");
                PaidUser Steffe = new PaidUser(6000, "Steffe", " Steffe@mail.com");
                PaidUser Koffe = new PaidUser(75300, "Koffe", " Koffe@mail.com");

                users.Add(Tim);
                users.Add(Robert);
                users.Add(Jonas);
                paidusers.Add(Karl);
                paidusers.Add(Steffe);
                paidusers.Add(Koffe);

                Console.WriteLine("hej" + Robert);
                foreach (UserInfo User in users)
                {
                    User.PrintInfo();
                }
                foreach (PaidUser User in paidusers)
                {
                    User.PrintInfo();
                }

                for (int i = 0; i < users.Count; i++)
                {
                    string variable = users[i].GetInfo();
                    Console.WriteLine(variable);

                }
                for (int i = 0; i < paidusers.Count; i++)
                {
                    string variable = paidusers[i].GetInfo();
                    Console.WriteLine(variable);
                }


                Console.WriteLine("Write a name");
                string input = Console.ReadLine();
                bool found = false;

                foreach (UserInfo User in users)
                {
                    if (input == User.Name)
                    {
                        found = true;
                        User.PrintInfo();
                        break;
                    }
                }
                if (found == false)
                  {
                    foreach (PaidUser PaidUser in paidusers)
                    {
                        if (input == PaidUser.Name)
                        {
                            found = true;
                            PaidUser.PrintInfo();
                            break;
                        }
                    }



                 }
               
            }
        }
    }
}
