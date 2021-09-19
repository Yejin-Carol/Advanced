using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iPhone_repairshop.util
{
    class RepairTable
    {
        public const int DISPLAY = 0;
        public const int BATTERY = 1;
        public const int SOUND = 2;
        public const int AIRPODS = 3;
        public const int BOARD = 4;
        public const int CAMERA = 5;

        public static int[] fixPrice =
        {
            300000, 200000, 100000,
            100000, 300000, 2000003
        };

    }
}
