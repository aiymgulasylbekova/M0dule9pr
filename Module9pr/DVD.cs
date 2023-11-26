using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9pr
{
    class DVD : Storage
    {
        private double readSpeed;
        private double writeSpeed;
        private string discType;

        public DVD(string name, string model, double readSpeed, double writeSpeed, string discType)
            : base(name, model)
        {
            this.readSpeed = readSpeed;
            this.writeSpeed = writeSpeed;
            this.discType = discType;
        }

        public override double GetMemory()
        {
            if (discType == "single")
                return 4.7;
            else if (discType == "double")
                return 9;

            return 0;
        }

        public override void CopyData(double dataSize)
        {
            // Логика копирования на DVD
        }

        public override double GetFreeSpace()
        {
            // Логика получения свободного места на DVD
            return 0;
        }

        public override string GetDeviceInfo()
        {
            return $"DVD Disc: {name} ({model}), Read Speed: {readSpeed}, Write Speed: {writeSpeed}, Type: {discType}";
        }
    }
}
