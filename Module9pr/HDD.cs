using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9pr
{
    class HDD : Storage
    {
        private double usbSpeed;
        private int partitions;
        private double partitionSize;

        public HDD(string name, string model, double usbSpeed, int partitions, double partitionSize)
            : base(name, model)
        {
            this.usbSpeed = usbSpeed;
            this.partitions = partitions;
            this.partitionSize = partitionSize;
        }

        public override double GetMemory()
        {
            return partitions * partitionSize;
        }

        public override void CopyData(double dataSize)
        {
            // Логика копирования на HDD
        }

        public override double GetFreeSpace()
        {
            // Логика получения свободного места на HDD
            return 0;
        }

        public override string GetDeviceInfo()
        {
            return $"Removable HDD: {name} ({model}), USB Speed: {usbSpeed}, Partitions: {partitions}, Partition Size: {partitionSize}";
        }
    }
}
