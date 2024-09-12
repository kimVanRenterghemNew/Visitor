using System.Text.Json.Serialization;
using System.Text.Json;

namespace BehaviorToMessages;


public class PersonConverter : JsonConverter<PersonVisitor>
{
    public override PersonVisitor? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions? options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var type = root.GetProperty("Type").GetString();

        return type switch
        {
            "Developer" => JsonSerializer.Deserialize<Developer>(root.GetRawText(), options),
            "Architect" => JsonSerializer.Deserialize<Architect>(root.GetRawText(), options),
            _ => throw new NotSupportedException($"Person type '{type}' is not supported")
        };
    }

    public override void Write(Utf8JsonWriter writer, PersonVisitor value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, (object)value, value.GetType(), options);
    }
}

public class LocationConverter : JsonConverter<LocationRules>
{
    public override LocationRules? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions? options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var type = root.GetProperty("Type").GetString();

        return type switch
        {
            "ServerRoom" => JsonSerializer.Deserialize<ServerRoom>(root.GetRawText(), options),
            "DevRoom" => JsonSerializer.Deserialize<DevRoom>(root.GetRawText(), options),
            _ => throw new NotSupportedException($"Location type '{type}' is not supported")
        };
    }

    public override void Write(Utf8JsonWriter writer, LocationRules value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, (object)value, value.GetType(), options);
    }
}