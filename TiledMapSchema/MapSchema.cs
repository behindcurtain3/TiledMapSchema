using Newtonsoft.Json;
using System.Collections.Generic;
using TiledMapSchema.Converters;
using TiledMapSchema.Layers;

namespace TiledMapSchema
{
    public class MapSchema
    {
        public int height { get; set; }
        public bool infinite { get; set; }
        public int nextlayerid { get; set; }
        public int nextobjectid { get; set; }
        public string orientation { get; set; }
        public string renderorder { get; set; }
        public string tiledversion { get; set; }
        public int tileheight { get; set; }
        public int tilewidth { get; set; }
        public string type { get; set; }
        public string version { get; set; }
        public int width { get; set; }

        public List<MapSchemaTileSet> tilesets { get; set; }
        public List<MapSchemaProperty> properties { get; set; }

        [JsonConverter(typeof(LayerConverter))]
        public List<Layer> layers { get; set; }
    }
}
