using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace TiledMapSchema.Converters
{
    public abstract class JsonObjectConverter<T> : JsonConverter
    {
        protected abstract T Create(Type objectType, JObject jsonObject);

        public override bool CanConvert(Type objectType)
        {
            return typeof(T).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var obj = JObject.Load(reader);
            T result = Create(objectType, obj);

            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
