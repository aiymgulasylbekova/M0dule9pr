using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9pr
{
    public class Program
    {
        static void Main()
        {
            BackupApp app = new BackupApp();

            Flash flashDrive = new Flash("Flash1", "Model1", 3.0, 64);
            DVD dvdDisc = new DVD("DVD1", "Model2", 10, 4, "single");
            HDD hdd = new HDD("HDD1", "Model3", 2.0, 2, 250);

            app.AddDevice(flashDrive);
            app.AddDevice(dvdDisc);
            app.AddDevice(hdd);

            double dataSize = 565; // Размер данных в Гб

            double totalMemory = app.CalculateTotalMemory();
            Console.WriteLine($"Total Memory: {totalMemory} GB");

            app.CopyDataToDevices(dataSize);

            double copyTime = app.CalculateCopyTime(dataSize);
            Console.WriteLine($"Estimated Copy Time: {copyTime} hours");

            List<Storage> requiredDevices = app.CalculateRequiredDevices(dataSize);
            Console.WriteLine("Required Devices:");
            foreach (var device in requiredDevices)
            {
                Console.WriteLine(device.GetDeviceInfo());
            }
            Console.ReadKey();
        }
    }
}
