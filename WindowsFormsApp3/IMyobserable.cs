using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public interface IMyobserable
    {

        void AddObserable(IObServer obserable);
        void RemoveObserable(IObServer obserable);
        void Notify();

    }
}
