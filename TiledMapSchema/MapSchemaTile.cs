using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiledMapSchema
{
    public class MapSchemaTile
    {
        public int id { get; set; }
        public string image { get; set; }
        public int imageheight { get; set; }
        public int imagewidth { get; set; }
        public List<MapSchemaProperty> properties { get; set; }
        public string type { get; set; }
    }
}
