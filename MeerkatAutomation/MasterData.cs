using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeerkatAutomation
{
    public class MasterData
    {

        public string WarehouseName; // = "PepsiCo";
        public double X_Offset, Y_Offset, BeamOverhang, Clearance, PalHeight, PalWidth, PalDepth; // = 18.215;

        /*
        public double Y_Offset = 4.33;
        public double BeamOverhang = 0.125;
        public double Clearance = 0.1;
        public double PalHeight = 2.4;
        public double PalWidth = 2.4;
        public double PalDepth = 1.0;*/

        public MasterData(string WarehouseName, double X_Offset, double Y_Offset, double BeamOverhang, double Clearance, double PalHeight, double PalWidth, double PalDepth)
        {
            this.WarehouseName = WarehouseName;
            this.X_Offset = X_Offset;
            this.Y_Offset = Y_Offset;   
            this.BeamOverhang = BeamOverhang;
            this.Clearance = Clearance;
            this.PalHeight = PalHeight;
            this.PalWidth = PalWidth;
            this.PalDepth = PalDepth;


        }
    }
}
