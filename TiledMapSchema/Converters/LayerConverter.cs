using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using TiledMapSchema.Layers;

namespace TiledMapSchema.Converters
{
    public class LayerConverter : JsonArrayConverter<Layer>
    {
        protected override Layer Create(Type objectType, JObject jsonObject)
        {
            var typeName = jsonObject["type"].ToString();
            switch (typeName)
            {
                case "tilelayer":
                    return JsonConvert.DeserializeObject<TileLayer>(jsonObject.ToString());

                case "objectgroup":
                    return JsonConvert.DeserializeObject<ObjectLayer>(jsonObject.ToString());

                default: return null;
            }
        }
    }
}
