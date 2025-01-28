using System;

namespace MyData;

public record class Reference
{
    public Uri? Source { get; set; }
    public Uri? Link { get; set; }
}
