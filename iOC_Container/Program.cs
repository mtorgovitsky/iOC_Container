using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iOC_Container
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();

            container.RegisterType<RegistrationService>();

            container.RegisterType<INotifier, EmailNotifier>();
            container.RegisterType<INotifier, SmsNotifier>();
            //container.RegisterType<INotifier, SmsNotifier>();

            var tmp = container.Resolve<RegistrationService>();

            tmp.Register("Michael", "00000000", "mail@mail.com");
        }
    }
}
