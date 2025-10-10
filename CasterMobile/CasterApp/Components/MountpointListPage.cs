using CasterApp.Application;
using MauiReactor;

namespace CasterApp.Components;
class MountpointListPageState
{
    public bool IsLoading { get; set; } = true;
}

partial class MountpointListPage : Component<MountpointListPageState>
{
    private Sourcetable m_Sourcetable = new();
    protected override async void OnMounted()
    {
        await m_Sourcetable.Request();
        base.OnMounted();
        SetState(state => state.IsLoading = false);
    }
    public override VisualNode Render()
        => ContentPage
        (
            ScrollView
            (
                ActivityIndicator().IsRunning(State.IsLoading).HCenter(),
                VStack
                (
                    m_Sourcetable.m_Mountpoints.Select
                    (
                        mountpoint => Button(mountpoint.m_Mountpoint)
                        .OnClicked(async () =>
                        {
                            ConnectionInfo.m_SelectedMountpoint = mountpoint;
                            await Navigation.PushAsync<MountpointPage>();
                        })
                    )
                )
            .VCenter()
            .Spacing(25)
            .Padding(30, 0)
            )
        );
}
