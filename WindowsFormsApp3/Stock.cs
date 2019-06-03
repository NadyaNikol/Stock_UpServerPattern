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

        List<IOBServer> obServers = new List<IOBServer>();


        public void AddObserable(IOBServer observer)
        {
            obServers.Add(observer);
        }

        public void Notify()
        {
            foreach (IOBServer observer in obServers)
            {
                observer.Update(this);
            }
        }

        public void RemoveObserable(IOBServer observer)
        {
            obServers.Remove(observer);
        }
    }
}
