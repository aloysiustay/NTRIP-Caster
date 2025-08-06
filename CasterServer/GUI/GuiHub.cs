using CasterServer.Mountpoint;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
public class CasterHub : Hub
{
    private readonly MountpointManager m_MountpointManager;
    public CasterHub(MountpointManager _mountpointManager)
    {
        m_MountpointManager = _mountpointManager;
    }
    // Called by client to subscribe to a mountpoint's live message stream
    public async Task SubscribeToMountpoint(string mountpointName)
    {
        MountpointSession? session = m_MountpointManager.GetMountpointSession(mountpointName);
        if (session == null)
            return;
        if (!session.m_Streamer.IsStreamActive)
            session.StreamRTCM();
        if (!session.m_Streamer.IsDecodeActive)
            session.DecodeRTCM();

        await Groups.AddToGroupAsync(Context.ConnectionId, mountpointName);
    }

    // Called by client to unsubscribe when no longer interested
    public async Task UnsubscribeFromMountpoint(string mountpointName)
    {
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, mountpointName);
    }
}