namespace Utils
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    public class SerializationUtils
    {
        private class SafeSerializationBinder : DefaultSerializationBinder
        {
            private static readonly string DeclaringAssemblyName = typeof(SafeSerializationBinder).Assembly.GetName().Name;

            internal static readonly SafeSerializationBinder Instance = new SafeSerializationBinder();

            public override Type BindToType(string assemblyName, string typeName)
            {
                if (assemblyName != DeclaringAssemblyName)
                    throw new JsonSerializationException($"Trying to deserialize unsafe type: {typeName}, {assemblyName}");
                return base.BindToType(assemblyName, typeName);
            }
        }

        private static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, SerializationBinder = SafeSerializationBinder.Instance };

        public static string Serialize(object obj) => JsonConvert.SerializeObject(obj, SerializerSettings);
        public static T Deserialize<T>(string json) => JsonConvert.DeserializeObject<T>(json, SerializerSettings);
        public static T Deserialize<T>(string json, params JsonConverter[] converters) => JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings { SerializationBinder = SafeSerializationBinder.Instance, Converters = converters });
    }
}