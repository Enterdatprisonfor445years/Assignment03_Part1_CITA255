namespace CITA255_Midterm;

public partial class FinalFantasy : ContentPage
{
	public FinalFantasy()
	{
		InitializeComponent();
	}

    private void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            int userEntry = int.Parse(QtyEntry.Text);
            QtyEntry.Text = string.Empty;
            QtyEntry.Placeholder = $"{userEntry} added to cart!";
        }
        catch (FormatException)
        {
            QtyEntry.Text = string.Empty;
            QtyEntry.Placeholder = "Invalid input: This requires a whole number!";
        }
        catch (ArgumentNullException)
        {
            QtyEntry.Text = string.Empty;
            QtyEntry.Placeholder = "Invalid input: a number must be added!";

        }
        catch
        {
            QtyEntry.Text = string.Empty;
            QtyEntry.Placeholder = "Invalid input: an error has occured.";

        }
    }
}