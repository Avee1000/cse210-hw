using System;

public class ShoppingCartUI
{
    private Cart cart;
    public ShoppingCartUI()
    {
        cart = new Cart();
        cart.MakeSaleList();
    }
    public void GetUserInput()
    {
        int end = -1;
        while (!(end == 6))
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char star = '\u2605';
            Console.WriteLine($"{star}   Welcome to the Online Shopping cart System  {star}\n");
            Console.Write("1. Display all products available for sale\n2. Add Products to your Cart\n3. Remove Items from your Cart\n4. View the items in your Cart\n" +
            "5. Make a Payment\n6. View past orders\n\nPlease Select One of the following: ");
            string user = Console.ReadLine();
            int choice = int.Parse(user);

            if (choice == 1)
            {
                DisplayProducts();
            }

            else if (choice == 2)
            {
                cart.AddToCart();
            }

            else if (choice == 3)
            {

            }

            else if (choice == 4)
            {
                DisplayCartContent();
            }

            else if (choice == 5)
            {

            }

            else if (choice == 6)
            {

            }

            else if (choice == 7)
            {
                break;
            }
        }
    }
    
    public void DisplayProducts()
    {
        cart.DisplayAll();
        Console.WriteLine("Please click any button to go to the Main Menu: ");
        Console.ReadLine();
    }

    public void DisplayCartContent()
    {
        cart.DisplayCart();
    }

    public void DisplayPaymentConfirmation()
    {
    }

    public void DisplayTotalPrice()
    {
    }


}