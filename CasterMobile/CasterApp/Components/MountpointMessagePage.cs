using CasterApp.Application;
using MauiReactor;

namespace CasterApp.Components;
class MountpointMessagePageState
{
    public bool m_Flag = false;
}

partial class MountpointMessagePage : Component<MountpointMessagePageState>
{
    public RtcmStatus m_Status;
    protected override void OnMounted()
    {
        base.OnMounted();
        m_Status = new(ConnectionInfo.m_SelectedMountpoint);

        m_Status.m_OnMessageReceived += (type) =>
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                SetState(s => s.m_Flag = !s.m_Flag);
            });
        };

        _ = m_Status.StreamAsync();
    }

    public override VisualNode Render()
        => ContentPage(
            "Mountpoint Status",
            ScrollView
            (
                VerticalStackLayout
                (
                    m_Status.m_MountpointStatus.m_MessageStatus.Select(kvp =>
                        new MauiReactor.Label($"{kvp.Key}: {kvp.Value.m_LastReceived}, {kvp.Value.m_Periodicity}, {kvp.Value.m_Count}")
                            .FontSize(18)
                            .Padding(4)
                    )
                )
            )
        );
}
