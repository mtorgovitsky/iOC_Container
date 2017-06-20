using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iOC_Container
{
    public class RegistrationService
    {
        [Dependency]
        public INotifier Notifier { get; set; }

        public void Register(string name, string phone, string email)
        {
            Notifier.Notify(name, phone, email);
        }
    }
}
