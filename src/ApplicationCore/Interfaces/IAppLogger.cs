﻿namespace Microsoft.eShopWeb.ApplicationCore.Interfaces
{
    /// <summary>
    /// This type eliminates the need to depend directly on the ASP.NET Core logging types. Add some comments
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IAppLogger<T>
    {
        void LogInformation(string message, params object[] args);
        void LogWarning(string message, params object[] args);
    }
}
