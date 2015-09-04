using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox.Common;
using Sandbox.Common.Components;
using Sandbox.Definitions;
using Sandbox.Engine;
using Sandbox.Game;
using VRage.ObjectBuilders;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;

namespace Warp
{
    public class WarpMod : MyGameLogicComponent
    {
        public void onPlayerJoin()
        {
            // if player does not exist
                // create player
                // welcome to server player
            // else player does exist
                // load player
                // show joined message
            // end if
            
        }

        public void tmrCheckPlayerJoin()
        {
            for (int t = 0; t < 1000; t++)
            {
                if (!isPlayerJoined()) { return; }
                else
                {
                    onPlayerJoin();
                }
            }
        }

        public override void Close()
        {

        }

        public bool isPlayerJoined()
        {
            
            return true;
        }

        public override MyObjectBuilder_EntityBase GetObjectBuilder(bool copy = false)
        {
            throw new NotImplementedException();
        }
    }

    public class WarpAPI : IWarpAPI
    {
        public void createWarp(string warpName, string warpAddress, IWarpPlayer sender)
        {
            throw new NotImplementedException();
        }

        public string getProgFrendlyWarpName(string warpName)
        {
            throw new NotImplementedException();
        }

        public List<TWarp> getWarps(IWarpPlayer sender)
        {
            throw new NotImplementedException();
        }

        public void removeWarp(string warpName, IWarpPlayer sender)
        {
            throw new NotImplementedException();
        }

        public void warpPlayer(string warpName)
        {
            throw new NotImplementedException();
        }

        public void warpPlayer(IWarpPlayer Player, string warpName)
        {
            throw new NotImplementedException();
        }

        public void warpPlayer(string warpAddress, bool isWarpAddress)
        {
            throw new NotImplementedException();
        }

        public void warpPlayer(IWarpPlayer Player, string warpAddress, bool isWarpAddress)
        {
            throw new NotImplementedException();
        }
    }
}
