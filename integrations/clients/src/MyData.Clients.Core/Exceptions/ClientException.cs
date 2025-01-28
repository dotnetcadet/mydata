﻿using System;

namespace MyData.Clients;

public class ClientException : Exception
{
    public ClientException(string message) : base(message)
    {

    }

    public ClientException(string message, Exception innerException) 
        : base(message, innerException)
    {
        
    }

}
