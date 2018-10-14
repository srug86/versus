using Plugin.Connectivity.Abstractions;

namespace Versus.Core.Contracts.Services.General
{
    public interface IConnectionService
    {
        bool IsConnected { get; }

        event ConnectivityChangedEventHandler ConnectivityChanged;
    }
}
