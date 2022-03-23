namespace Protobuf.System.Text.Json;

public class JsonProtobufSerializerOptions
{
    /// <summary>
    /// Defines how property names should be resolved for protobuf contracts.
    /// When set to true PropertyNamingPolicy will be ignored and property name will be derived from protobuf contract.
    /// This is usually the lower-camel-cased form of the field name, but can be overridden using the <c>json_name</c>
    /// option in the .proto file.
    /// The default value is false.
    /// </summary>
    public bool UseProtobufJsonNames { get; set; }

    /// <summary>
    /// Controls how <see cref="Google.Protobuf.WellKnownTypes.Duration"/> fields are handled.
    /// When set to true, <see cref="Google.Protobuf.WellKnownTypes.Duration"/> properties will
    /// be converted to <see cref="TimeSpan"/> before serialization and will be expected in the
    /// same format as <see cref="TimeSpan"/> (-dddddddd.hh:mm:ss.fffffff) during deserialization.
    /// The default value is true.
    /// </summary>
    public bool TreatDurationAsTimeSpan { get; set; } = true;
}