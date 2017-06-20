using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iOC_Container
{
    public class EmailNotifier : INotifier
    {
        public void Notify(string name, string phone, string email)
        {
            Console.WriteLine($"Registering {name} from email: {email}");
        }
    }
}
