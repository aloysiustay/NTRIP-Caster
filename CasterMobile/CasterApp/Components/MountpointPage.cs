using CasterApp.Application;
using MauiReactor;

namespace CasterApp.Components;
class MountpointPageState
{
    public bool m_IsConnected = false;
}

partial class MountpointPage : Component<MountpointPageState>
{
    public RtcmStatus m_Status;
    protected override void OnMounted()
    {
        base.OnMounted();
        m_Status = new(ConnectionInfo.m_SelectedMountpoint);

        _ = m_Status.StreamAsync();
    }

    public override VisualNode Render()
    => ContentPage(
        "My Page",
        Grid("*,*", "*",
            // ---------- TOP HALF ----------
            Grid("Auto,Auto", "Auto,*",
                // Name (row 0, span 2 cols)
                VStack(
                    Label(m_Status.m_MountpointStatus.m_Info.m_Mountpoint)
                    .FontSize(24),
                    Label(m_Status.m_MountpointStatus.m_Info.m_Country)
                        .FontSize(16)
                        .TextColor(Colors.Green),
                    Label(m_Status.m_MountpointStatus.m_Info.m_Identifier)
                        .FontSize(16)
                        .TextColor(Colors.Green)
                )
                .HCenter()
                .VCenter()
                .Margin(10)
                .GridRow(0)
                .GridColumnSpan(2),

                // Left square button
                Button("B")
                    .WidthRequest(80)
                    .HeightRequest(80)
                    .GridRow(1)
                    .GridColumn(0),

                // Right: VStack with Status
                VStack(
                    Label("Status")
                        .FontSize(16),
                    Label(m_Status.IsConnected)
                        .FontSize(14)
                        .TextColor(Colors.Green)
                )
                .VCenter()
                .GridRow(1)
                .GridColumn(1)
            )
            .GridRow(0),

            // ---------- BOTTOM HALF ----------
            Grid("*,Auto", "*,*",
                // Left info
                VStack(
                    Label("Latitude")
                        .FontSize(12)
                        .TextColor(Colors.DarkGray),
                    Label(m_Status.m_MountpointStatus.m_Info.m_Coordinate.m_Latitude)
                        .FontSize(16)
                        .TextColor(Colors.Green),
                    Label("Longitude")
                        .FontSize(12)
                        .TextColor(Colors.DarkGray),
                    Label(m_Status.m_MountpointStatus.m_Info.m_Coordinate.m_Longitude)
                        .FontSize(16)
                        .TextColor(Colors.Green)
                )
                .HCenter()
                .VCenter()
                .GridRow(0)
                .GridColumn(0),

                // Right info
                VStack(
                    Label("Protocol")
                        .FontSize(12)
                        .TextColor(Colors.DarkGray),
                    Label(m_Status.m_MountpointStatus.m_Info.m_Format)
                        .FontSize(16)
                        .TextColor(Colors.Green)
                )
                .HCenter()
                .VCenter()
                .GridRow(0)
                .GridColumn(1),

                HStack(
                    Button("Messages").WidthRequest(160).HeightRequest(80)
                    .OnClicked(async () =>
                    {
                        await Navigation.PushAsync<MountpointMessagePage>();
                    }),

                    Button("Satellites").WidthRequest(160).HeightRequest(80)
                )
                .Spacing(20)
                .HCenter()
                .Margin(10)
                .GridRow(1)
                .GridColumnSpan(2)
            )
            .GridRow(1)
        )
    );
}
