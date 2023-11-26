using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9pr
{
    class Flash : Storage
    {
        private double usbSpeed;
        private double memorySize;

        public Flash(string name, string model, double usbSpeed, double memorySize)
            : base(name, model)
        {
            this.usbSpeed = usbSpeed;
            this.memorySize = memorySize;
        }

        public override double GetMemory()
        {
            return memorySize;
        }

        public override void CopyData(double dataSize)
        {
            // Логика копирования на флешку
        }

        public override double GetFreeSpace()
        {
            // Логика получения свободного места на флешке
            return 0;
        }

        public override string GetDeviceInfo()
        {
            return $"Flash Memory: {name} ({model}), USB Speed: {usbSpeed}, Memory Size: {memorySize}";
        }
    }
}
