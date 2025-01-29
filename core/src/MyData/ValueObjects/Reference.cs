using System;

namespace MyData;

public record class Reference
{
    public string? Source { get; set; }
    public Uri? Link { get; set; }
    public string? Type { get; set; }
}
