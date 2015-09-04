using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warp
{
    public interface IWarpAPI
    {
        // warpPlayer(warpName)
        /// <summary>
        /// Warp the current player to the address thats attached to the specified warp name.
        /// </summary>
        /// <param name="warpName">Warp Name</param>
        void warpPlayer(string warpName);

        // warpPlayer(warpAddress, isWarpAdress)
        /// <summary>
        /// Warps the current player to the specified warp address.
        /// </summary>
        /// <param name="warpAddress">Vector3 Address[x,y,z]</param>
        /// <param name="isWarpAddress">True</param>
        void warpPlayer(string warpAddress, bool isWarpAddress);

        // warpPlayer(Player, warpAddress, isWarpAddress)
        /// <summary>
        /// Warps the specified player to the specified warp address.
        /// </summary>
        /// <param name="Player">IPlayer Player</param>
        /// <param name="warpAddress">Vector3 Address[x,y,z]</param>
        /// <param name="isWarpAddress">True</param>
        void warpPlayer(IWarpPlayer Player, string warpAddress, bool isWarpAddress);

        // warpPlayer(Player, warpName)
        /// <summary>
        /// Warp the specified player to the address thats attached to the specified warp name.
        /// </summary>
        /// <param name="Player">IWarpPlayer Player</param>
        /// <param name="warpName">Warp Name</param>
        void warpPlayer(IWarpPlayer Player, string warpName);

        // createWarp(warpName, warpAddress, sender)
        /// <summary>
        /// Records a new address attached to a warp name.
        /// </summary>
        /// <param name="warpName">Warp Name</param>
        /// <param name="warpAddress">Vector3 Address[x,y,z]</param>
        /// <param name="sender">IWarpPlayer sender</param>
        void createWarp(string warpName, string warpAddress, IWarpPlayer sender);

        // removeWarp(warpName, sender)
        /// <summary>
        /// Removes the specified warp name from the data store.
        /// </summary>
        /// <param name="warpName">Warp Name</param>
        /// <param name="sender">IWarpPlayer sender</param>
        void removeWarp(string warpName, IWarpPlayer sender);

        // getProgFriendlyWarpName(warpName)
        /// <summary>
        /// Gets the programically friendly version of a warp name. e.g. spaces replaced with a underscore.
        /// </summary>
        /// <param name="warpName">Warp Name</param>
        /// <returns>Programically Friendly Warp Name</returns>
        string getProgFrendlyWarpName(string warpName);

        // getWarps(sender)
        /// <summary>
        /// Gets a list of warps.
        /// </summary>
        /// <param name="sender">IWarpPlayer sender</param>\
        /// <returns>TWarp Warps</returns>
        List<TWarp> getWarps(IWarpPlayer sender);
    }
}
