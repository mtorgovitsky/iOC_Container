using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iOC_Container
{
    public interface INotifier
    {
        void Notify(string name, string phone, string email);
    }
}
