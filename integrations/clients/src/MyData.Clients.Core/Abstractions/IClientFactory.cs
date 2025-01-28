namespace MyData.Clients;

public interface IClientFactory
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    IClient Create(string name);

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TClient"></typeparam>
    /// <returns></returns>
    TClient Create<TClient>() where TClient : IClient;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TClient"></typeparam>
    /// <param name="name"></param>
    /// <returns></returns>
    TClient Create<TClient>(string name) where TClient : IClient;
}
