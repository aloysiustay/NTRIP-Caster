using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasterApp.Components
{
    class AppNavigation : Component
    {
        public override VisualNode Render() =>
            NavigationPage(
                new LoginPage()
            );
    }
}
