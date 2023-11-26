using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9pr
{
    abstract class Storage
    {
        public string name;
        public string model;

        public Storage(string name, string model)
        {
            this.name = name;
            this.model = model;
        }

        public abstract double GetMemory();

        public abstract void CopyData(double dataSize);

        public abstract double GetFreeSpace();

        public abstract string GetDeviceInfo();
    }
}
