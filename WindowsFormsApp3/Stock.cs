using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Stock : IMyobserable
    {

        public double BTCCource { get; set; }

        List<IObServer> obServers = new List<IObServer>();


        public void AddObserable(IObServer observer)
        {
            obServers.Add(observer);
        }

        public void Notify()
        {
            foreach (IObServer observer in obServers)
            {
                observer.Update(this);
            }
        }

        public void RemoveObserable(IObServer observer)
        {
            obServers.Remove(observer);
        }
    }
}
