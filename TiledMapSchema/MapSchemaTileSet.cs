using System.Collections.Generic;

namespace TiledMapSchema
{
    public class MapSchemaTileSet
    {
        public int columns { get; set; }
        public int firstgid { get; set; }
        public string image { get; set; }
        public int imagewidth { get; set; }
        public int imageheight { get; set; }
        public int margin { get; set; }
        public string name { get; set; }
        public List<MapSchemaProperty> properties { get; set; }
        public int spacing { get; set; }
        public string source { get; set; }
        public int tilecount { get; set; }
        public int tileheight { get; set; }
        public int tileoffset { get; set; }
        public List<MapSchemaTile> tiles { get; set; }
        public int tilewidth { get; set; }
        public string transparentcolor { get; set; }
        public string type { get; set; }

    }
}
