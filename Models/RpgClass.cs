using System.Text.Json.Serialization;

namespace dotnet_rpg_dotNET50_.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,
        Mage,
        Cleric
    }
}