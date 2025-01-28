namespace MyData.Clients.Internal;

internal class ClientErrorDefault : ClientError
{
    public ClientErrorDefault(string message, int statusCode) : base(statusCode)
    {
        Message = message;
    }
    public override string Message { get; }
}
