using Newtonsoft.Json;

namespace DevWebReceitas.Application.Mappers.Default
{
    public static class TypeConverter
    {
        public static T ConvertTo<T>(object value)
        {
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(value));
        }
    }
}
