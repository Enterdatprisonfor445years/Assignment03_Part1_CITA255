using Microsoft.Extensions.DependencyInjection;

namespace CITA255_Midterm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Routing.RegisterRoute("GearsOfWar", typeof(GearsOfWar));
            Routing.RegisterRoute("Fallout", typeof(Fallout)); 
            Routing.RegisterRoute("FinalFantasy", typeof(FinalFantasy)); 
            Routing.RegisterRoute("MonsterHunter", typeof(MonsterHunter));
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}