using Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using static MeerkatAutomation.MasterData;

namespace MeerkatAutomation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Start creating map for: ");

            //now read the master data 
            //create for now
            MasterData masterData = new MasterData("PepsiCo", 18.215, 4.33, 0.125, 0.1, 2.4, 2.4, 1.0);
            Console.WriteLine(masterData.WarehouseName.ToString());

            string[] aisles = new string[] { "FU", "FT", "FS", "FR", "FQ", "FP", "FN", "FM", "FL", "FK", "FJ", "FH", "FG", "FE", "FD", "FC", "FB", "FA", "EM", "EL", "EK", "EJ", "EH", "EG" , "EF", "EE", "ED", "EC0", "EB", "EA"};
             
            FrameMaster frames = new FrameMaster();

            double totalBins = 76;
            int binPerRack = (int)Math.Floor(totalBins / 2);
            // lets create some frame data
            //create array of bin NUMBERS
            int[] oddBins = BinMaster.oddBinNumbers(totalBins);
            int[] evenBins = BinMaster.evenBinNumbers(totalBins);
          
           // create Array of X start points
            double[] oddBinStartX = BinMaster.CreateStartPoints(oddBins, frames, masterData.X_Offset);
            double[] evenBinStartX = BinMaster.CreateStartPoints(evenBins, frames, masterData.X_Offset);

            //create array of X end points
            double[] oddBinEndX = BinMaster.CreateEndPoints(oddBinStartX, masterData.PalWidth);
            double[] evenBinEndX = BinMaster.CreateEndPoints(evenBinStartX, masterData.PalWidth);
            //test only 

            //create Aisle names 
            string[] Aisles = AisleMaster.AisleNames(aisles);


            for (int i = 0; i < binPerRack; i++)
            {
                Console.Write(oddBins[i]); Console.Write(" : ");
                Console.WriteLine(oddBinStartX[i]);
                Console.Write(evenBins[i]); Console.Write(" : ");
                Console.WriteLine(evenBinStartX[i]);
            }

            foreach (string aisle in Aisles)
            {
                Console.WriteLine(aisle);
            }

        }
    }
}
