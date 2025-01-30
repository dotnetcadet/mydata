namespace MyData;

public class State : ReferenceEntity
{
    public StateId Id { get; set; }
    public StateInfo? Info { get; set; }
    public CountryId CountryId { get; set; }
    public Country? Country { get; set; }
    public override EntityKind Kind => EntityKind.State;
    public override EntityDomain Domain => EntityDomain.Core;
}
