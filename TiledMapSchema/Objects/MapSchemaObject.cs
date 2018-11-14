using System.Collections.Generic;

namespace TiledMapSchema.Objects
{
    public class MapSchemaObject
    {
        public int height { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public bool point { get; set; }
        public int rotation { get; set; }
        public string type { get; set; }
        public bool visible { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public List<MapSchemaProperty> properties { get; set; }
    }
}
