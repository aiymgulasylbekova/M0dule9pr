using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9pr
{
    class BackupApp
    {
        private List<Storage> devices = new List<Storage>();

        public void AddDevice(Storage device)
        {
            devices.Add(device);
        }

        public double CalculateTotalMemory()
        {
            double totalMemory = 0;
            foreach (var device in devices)
            {
                totalMemory += device.GetMemory();
            }
            return totalMemory;
        }

        public void CopyDataToDevices(double dataSize)
        {
            foreach (var device in devices)
            {
                device.CopyData(dataSize);
            }
        }

        public double CalculateCopyTime(double dataSize)
        {
            // Логика расчета времени копирования
            return 0;
        }

        public List<Storage> CalculateRequiredDevices(double dataSize)
        {
            List<Storage> requiredDevices = new List<Storage>();
            double remainingData = dataSize;

            foreach (var device in devices)
            {
                if (remainingData <= 0)
                    break;

                double freeSpace = device.GetFreeSpace();
                if (freeSpace >= remainingData)
                {
                    requiredDevices.Add(device);
                    break;
                }

                requiredDevices.Add(device);
                remainingData -= freeSpace;
            }

            return requiredDevices;
        }
    }
}
