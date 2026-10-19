
using System.Globalization;

namespace CITA255_Midterm;

public partial class CartPage : ContentPage
{
	public CartPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();


        List<string> displayList = new List<string>();

        double runTotal = 0.0;

        for (int i = 0; i < Cart.ItemNames.Count; i++)
        {
            string lineItem = $"{Cart.ItemQuantities[i]} x {Cart.ItemNames[i]}";
            displayList.Add(lineItem);

            if (int.TryParse(Cart.ItemQuantities[i], out int quantity))
            {
                string cleanPrice = Cart.ItemPrices[i].Replace("$", "").Trim();

                if (double.TryParse(cleanPrice, NumberStyles.Any, CultureInfo.InvariantCulture, out double pricePerUnit))
                {
                    runTotal += (pricePerUnit * quantity);
                }
            }
        }

        cartListSection.ItemsSource = null;
        cartListSection.ItemsSource = displayList;

        if (Cart.ItemNames.Count == 0)
        {
            totalSection.Text = "Cart is Empty! Total: $0.00";
        }
        else
        {
            totalSection.Text = $"Total: ${runTotal:F2}";
        }
    }

    private void OnCheckoutButtonClicked(object sender, EventArgs e)
    {
        if (Cart.ItemNames.Count == 0)
        {
            totalSection.Text = "Your cart is already empty. If you want more, please add to the cart!";
            return;
        }

        Cart.ItemNames.Clear();
        Cart.ItemPrices.Clear();
        Cart.ItemQuantities.Clear();

        cartListSection.ItemsSource = null;

        totalSection.Text = "Thanks for your order! Total has returned to $0.00";
    }
}