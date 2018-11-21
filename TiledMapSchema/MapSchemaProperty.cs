namespace TiledMapSchema
{
    public class MapSchemaProperty
    {
        public string name { get; set; }
        public string type { get; set; }
        public string value { get; set; }

        public object GetValue()
        {
            switch(type)
            {
                case "string":
                    return value;
                case "bool":
                    return bool.Parse(value);
                case "int":
                    return int.Parse(value);
            }

            return null;
        }
    }
}
