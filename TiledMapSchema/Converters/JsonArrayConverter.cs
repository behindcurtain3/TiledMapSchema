using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace TiledMapSchema.Converters
{
    public abstract class JsonArrayConverter<T> : JsonConverter
    {
        protected abstract T Create(Type objectType, JObject jsonObject);

        public override bool CanConvert(Type objectType)
        {
            return typeof(T).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            List<T> objects = new List<T>();
            var jsonArray = JArray.Load(reader);

            foreach (JObject item in jsonArray.Children())
            {
                var obj = Create(objectType, item);
                objects.Add(obj);
            }

            return objects;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
