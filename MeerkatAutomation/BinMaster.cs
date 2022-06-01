using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeerkatAutomation
{
    public class BinMaster
    {
        public static int[] oddBinNumbers(double total)
        {
            int spaces = (int)Math.Floor(total / 2);
            int[] oddBinNumers = new int[spaces];
            int index = 1;
            for (int i = 0; i<spaces ; i++)
            {
                oddBinNumers[i] = index;
                index = index + 2;
            }
            return oddBinNumers;
        }
        public static int[] evenBinNumbers(double total)
        {
            int spaces = (int)Math.Floor(total / 2);
            int[] BinNumers = new int[spaces];
            int index = 2;
            for (int i = 0; i < spaces; i++)
            {
                BinNumers[i] = index;
                index = index + 2;
            }
            return BinNumers;
        }
        public static double[] CreateStartPoints(int[] odd_bins, FrameMaster frames, double offset)
        {

            double[] startPoints = frames.FrameStarts();
            double[] endPoints = frames.FrameEnds();
            int[] binPerFrame = frames.bins();

            double[] BinStartX = new double[odd_bins.Length];

            int bindex = 0;
            int index = 0;
            for (int k=0; k< startPoints.Length-1; k++)
            {
                int num_bins = binPerFrame[index];
                double split_frame = (endPoints[index] - startPoints[index]) / num_bins;
                for (int i = 0; i < num_bins; i++)
                {
                    double placeholder = startPoints[index] + (i * split_frame) + offset;
                    int location = bindex + i;
                    BinStartX[location] = placeholder;
                }
                bindex = bindex + num_bins;
                index++;
            }
            return BinStartX;
        }

        public static double[] CreateEndPoints(double[] starts, double palSpace)
        {
            double[] binEnds = new double[starts.Length];
            for (int i = 0; i < starts.Length; i++)
            {
                binEnds[i] = starts[i] + palSpace;
            }
            return binEnds;
        }
   
    }
}
