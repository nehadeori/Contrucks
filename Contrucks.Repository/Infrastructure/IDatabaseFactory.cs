using System;

namespace Contrucks.Repository.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        CustomerContext Get();
    }
}