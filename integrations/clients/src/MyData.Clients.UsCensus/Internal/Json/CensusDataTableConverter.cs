using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MyData.Clients.UsCensus.Internal;

internal class CensusDataTableConverter : JsonConverter<UsCensusDataTable>
{
    public override UsCensusDataTable? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {

        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException("Invalid payload");
        }

        var headersRead = false;
        var table = new UsCensusDataTable();

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndArray)
            {
                break;
            }
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException("Invalid payload");
            }
            // Read Columns
            if (!headersRead)
            {
                var index = 0;

                while (reader.Read())
                {
                    if (reader.TokenType == JsonTokenType.EndArray)
                    {
                        break;
                    }
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException("Invalid payload");
                    }

                    var headerName = reader.GetString()!;

                    table.AddColumn(new UsCensusDataColumn()
                    {
                        Index = index,
                        Name = headerName
                    });

                    index++;
                }

                headersRead = true;
            }
            // Read Rows
            else
            {
                var row = new UsCensusDataRow();

                while (reader.Read())
                {
                    if (reader.TokenType == JsonTokenType.EndArray)
                    {
                        break;
                    }
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException("Invalid payload");
                    }

                    var value = reader.GetString()!;

                    row.AddValue(value);
                }

                table.AddRow(row);
            }
        }

        return table;
    }

    public override void Write(Utf8JsonWriter writer, UsCensusDataTable value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
