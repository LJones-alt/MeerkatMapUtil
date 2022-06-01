using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeerkatAutomation
{
    public class Frame
    {
        public double start, end, width;
        public int bins;
        public Frame(double start, double end, double width, int bins) 
        { 
            this.start = start; this.end = end; this.width = width; this.bins = bins;
        }
    }
    public class FrameMaster
    {
        
        public static int FrameCount = 10; //TODO -  inspect
        public static Frame Frame01 = new Frame(0.045,1.53, 0, 1);
        public static Frame Frame02 = new Frame(1.535, 4.42, 1.49, 2);
        public static Frame Frame03 = new Frame(4.425, 7.31, 2.89, 2);
        public static Frame Frame04 = new Frame(7.315, 10.2, 2.89, 2);
        public static Frame Frame05 = new Frame(10.205, 13.09, 2.89, 2);
        public static Frame Frame06 = new Frame(13.095, 15.98, 2.98, 2);
        public static Frame Frame07 = new Frame(15.985, 18.77, 2.89, 2);
        public static Frame Frame08 = new Frame(18.775, 21.56, 2.89, 2);
        public static Frame Frame09 = new Frame(21.565, 24.35, 2.89, 2);
        public static Frame Frame10 = new Frame(24.355, 27.14, 2.89, 2);

        public double[] FrameStarts()
        {
            double[] frameStart = new double[] { 0.045, 1.535, 4.425, 7.315, 10.205, 13.095, 15.985, 18.775, 21.565, 24.355, 27.145, 29.935, 34.025, 36.815, 39.605, 42.395, 45.185, 47.975, 50.765, 53.555 };

            return frameStart;
        }

        public double[] FrameEnds()
        {
            double[] frameEnds = new double[] { 1.53, 4.42, 7.31, 10.2, 13.09, 15.98, 18.77, 21.56, 24.35, 27.14, 29.93, 34.02, 36.81, 39.6, 42.39, 45.18, 47.97, 50.76, 53.55, 56.34};
            return frameEnds;
        }

        public int[] bins()
        {
            int[] bins = new int[] { 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 2, 2, 2, 2, 2, 2, 2,2 }; 
            return bins;
        }
               
    }

    
}
