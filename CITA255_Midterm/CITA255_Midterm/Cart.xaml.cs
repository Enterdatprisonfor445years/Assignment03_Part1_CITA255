namespace CITA255_Midterm;

public partial class Cart : ContentPage
{
	public Cart()
	{
		InitializeComponent();
	}

    private void CheckoutCLicked(Object sender, EventArgs e)
    {
		CheckoutButton.Text = "You Checked Out!";
		CheckoutButton.BackgroundColor= Colors.Green;
    }
}