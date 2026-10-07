namespace CITA255_Midterm
{
    public partial class MainPage : ContentPage
    {
        List<string> products =
        [
            "Gears of War E Day",
            "Fallout New Vegas",
            "Final Fantasy 7: Rebirth",
            "Monster Hunter Wilds"
        ];

        public MainPage()
        {
            InitializeComponent();
            productList.ItemsSource = products;
        }

        private void OnProductSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count > 0)
            {
                string picked = e.CurrentSelection[0].ToString();

                productList.SelectedItem = null;

                if (picked == "Gears of War E Day")
                {
                    Shell.Current.GoToAsync("GearsOfWar");
                }
                else if (picked == "Fallout New Vegas")
                {
                    Shell.Current.GoToAsync("Fallout");
                }
                else if (picked == "Final Fantasy 7: Rebirth")
                {
                    Shell.Current.GoToAsync("FinalFantasy");
                }
                else if (picked == "Monster Hunter Wilds")
                {
                    Shell.Current.GoToAsync("MonsterHunter");
                }
            }
        }
    }
}
