﻿using System;
using Newtonsoft.Json;

namespace Alyio.AspNetCore.Orchid.Json.Converters
{
    public class TypeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var type = value as Type;
            if (type == null)
            {
                writer.WriteNull();
                return;
            }
            var name = type.GetTypeName();
            writer.WriteValue(name);
        }
    }
}
