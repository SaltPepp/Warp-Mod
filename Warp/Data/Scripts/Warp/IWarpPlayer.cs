using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warp
{
    public class IWarpPlayer
    {
        public ulong SteamID { get; set; }
        public string Nickname { get; set; }
        public bool isOp { get; set; }
    }
}
