using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public interface IMyobserable
    {

        void AddObserable(IOBServer obserable);
        void RemoveObserable(IOBServer obserable);
        void Notify();

    }
}
