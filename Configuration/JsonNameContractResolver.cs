using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Configuration
{
    public class JsonNameContractResolver : DefaultContractResolver
    {
        protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
        {
            // Let the base class create all the JsonProperties 
            IList<JsonProperty> list = base.CreateProperties(type, memberSerialization);

            // assign the C# property name
            foreach (JsonProperty prop in list)
            {
                prop.PropertyName = ToCamelCase(prop.UnderlyingName);
            }

            return list;
        }

        private string ToCamelCase(string str)
        {
            if (!string.IsNullOrEmpty(str) && str.Length > 1)
            {
                return char.ToLowerInvariant(str[0]) + str.Substring(1);
            }
            return str;
        }
    }
}
