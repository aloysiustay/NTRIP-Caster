using CasterApp.Application;
using CasterApp.Resources.Styles;
using MauiReactor;
using CommunityToolkit.Maui.Core;
using MauiReactor.Animations;
using MauiReactor.Shapes;

namespace CasterApp.Components;
class PieChartViewState
{

}

partial class PieChartView : Component<PieChartView>
{
    public override VisualNode Render()
         => ContentPage([..
                Children(),
                #if !IOS

                #endif
                    ])
        .Padding(-1)
        .HasNavigationBar(false)
        ;
}
