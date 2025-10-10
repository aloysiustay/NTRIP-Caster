using CasterApp.Application;

namespace CasterApp.Components;
class LoginPageState
{
    public string Caster { get; set; } = "10.0.2.2";
    public string Port { get; set; } = "2101";
    public string Username { get; set; } = "aloytaytay@gmail.com";
    public string Password { get; set; } = "password";
    public bool IsLoading { get; set; } = false;
}

partial class LoginPage : Component<LoginPageState>
{
    public override VisualNode Render() =>
        ContentPage("Login",
            ScrollView(
                VStack(
                    Label("New Connection")
                        .FontSize(28)
                        .HCenter(),

                    Entry()
                        .Placeholder("Caster")
                        .Text(State.Caster)
                        .OnTextChanged(text => SetState(s => s.Caster = text)),

                    Entry()
                        .Placeholder("Port")
                        .Keyboard(Keyboard.Numeric)
                        .Text(State.Port)
                        .OnTextChanged(text => SetState(s => s.Port = text)),

                    Entry()
                        .Placeholder("Username")
                        .Text(State.Username)
                        .OnTextChanged(text => SetState(s => s.Username = text)),

                    Entry()
                        .Placeholder("Password")
                        .IsPassword(true)
                        .Text(State.Password)
                        .OnTextChanged(text => SetState(s => s.Password = text)),

                    Button("Connect", async () =>
                    {
                        if (int.TryParse(State.Port, out int port))
                        {
                            SetState(s => s.IsLoading = true);
                            ConnectionInfo.Init(State.Caster, port, State.Username, State.Password);
                            await Navigation.PushAsync<MountpointListPage>();
                            SetState(s => s.IsLoading = false);
                        }
                        else
                        {
                            //await Application.Current.MainPage.DisplayAlert(
                            //    "Error", "Invalid Port", "OK"
                            //);
                        }
                    })
                    .HCenter(),

                    ActivityIndicator().IsRunning(State.IsLoading).HCenter()
                )
                .Spacing(15)
                .Padding(20)
            )
        );
}
