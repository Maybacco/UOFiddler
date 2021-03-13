// /***************************************************************************
//  *
//  * $Author: AMulazzani
//  *
//  * "THE BEER-WARE LICENSE"
//  * As long as you retain this notice you can do whatever you want with
//  * this stuff. If we meet some day, and you think this stuff is worth it,
//  * you can buy me a beer in return.
//  *
//  ***************************************************************************/

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ultima
{
    public class MapExtraction
    {
        [JsonProperty]
        public List<LandTileInfo> LandTiles { get; set; }

        [JsonProperty]
        public List<StaticsTileInfo> StaticTiles { get; set; }

        [JsonConstructor]
        public MapExtraction() { }
    }

    public class LandTileInfo
    {
        [JsonProperty]
        public int X { get; set; }

        [JsonProperty]
        public int Y { get; set; }

        [JsonProperty]
        public int Z { get; set; }

        [JsonProperty]
        public int Id { get; set; }

        [JsonConstructor]
        public LandTileInfo()
        {
        }
    }

    public class StaticsTileInfo
    {
        [JsonProperty]
        public int X { get; set; }

        [JsonProperty]
        public int Y { get; set; }

        [JsonProperty]
        public int Z { get; set; }

        [JsonProperty]
        public int Id { get; set; }

        [JsonProperty]
        public int Hue { get; set; }

        [JsonConstructor]
        public StaticsTileInfo()
        {
        }
    }
}