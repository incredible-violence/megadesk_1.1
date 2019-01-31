using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_JamesKennedy
{
    class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public string DesktopMaterial;

        // Constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MAXDEPTH = 48;
        public const int MINDEPTH = 12;
        public const int MINDRAWERS = 0;
        public const int MAXDRAWERS = 7;
    }
}
