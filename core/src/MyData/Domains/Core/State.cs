namespace MyData;

public class State
{
    public StateId Id { get; set; }
    public StateInfo? Info { get; set; }
    public CountryId CountryId { get; set; }
    public Country? Country { get; set; }
}
