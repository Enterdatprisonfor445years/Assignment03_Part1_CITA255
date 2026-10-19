namespace CITA255_Midterm;

public partial class GearsOfWar : ContentPage
{
	public GearsOfWar()
	{
		InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        string gameTitle = "Gears of war E Day";

        if (Cart.GameInventory.ContainsKey(gameTitle))
        {
            int availableStock = Cart.GameInventory[gameTitle];

            if (availableStock <= 0)
            {
                AddToCartButton.IsEnabled = false;
                MessageLabel.Text = "This item is out of stock!";
                MessageLabel.TextColor = Colors.Red;
            }
            else
            {
                AddToCartButton.IsEnabled = true;
                MessageLabel.Text = $"{availableStock} copies left in stock!";
                MessageLabel.TextColor = Colors.Green;
            }
        }
    }

    private void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        string gameTitle = "Gears of War E Day";

        if (int.TryParse(QtyEntry.Text, out int requestedQuantity) && requestedQuantity > 0)
        {
            int availableStock = Cart.GameInventory[gameTitle];

            if (requestedQuantity > availableStock)
            {
                MessageLabel.Text = $"Cannot add to cart! Only {availableStock} copies remain in stock.";
                MessageLabel.TextColor = Colors.Purple;
                return;
            }

            Cart.ItemNames.Add(gameTitle);
            Cart.ItemPrices.Add("69.99");
            Cart.ItemQuantities.Add(requestedQuantity.ToString());

            MessageLabel.Text = $"{requestedQuantity} added to cart!";
            MessageLabel.TextColor = Colors.Green;

            QtyEntry.Text = string.Empty;
        }
        else
        {
            MessageLabel.Text = "Invalid input: This requires a whole number!";
            MessageLabel.TextColor = Colors.Purple;
        }
    }
}