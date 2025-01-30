namespace MyData.Clients;

public class ClientSuccessObject<T> : ClientSuccess
{
    public required T? Data { get; set; }
}
