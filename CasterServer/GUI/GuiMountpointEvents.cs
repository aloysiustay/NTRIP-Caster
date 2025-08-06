using CasterServer.Mountpoint;

namespace CasterServer.GUI
{
    public class GuiMountpointEvents
    {
        private readonly MountpointManager m_MountpointManager;
        public GuiMountpointEvents(MountpointManager _mountpointManager)
        {
            m_MountpointManager = _mountpointManager;
        }

    }

    public class GuiMountpointSessionEvents
    {
        private CancellationTokenSource m_CancellationTokenSource = new();
        public GuiMountpointSessionEvents()
        {

        }
    }
}
