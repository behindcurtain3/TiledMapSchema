using System.Collections.Generic;
using TiledMapSchema.Objects;

namespace TiledMapSchema.Layers
{
    public class ObjectLayer : Layer
    {
        public string draworder { get; set; }
        public List<MapSchemaObject> objects { get; set; }
    }
}
