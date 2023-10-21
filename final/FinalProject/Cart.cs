using System;

public class Cart
{
    private List<Product> _products;
    private decimal _totalPrice;
    private List<Product> _orderedProducts;

    public Cart()
    {
        _totalPrice = 0;
        _products = new List<Product>();
        _orderedProducts = new List<Product>();
    }

    //we may not need to set total score yet
    public void MakeSaleList()
    {
        // Create a random number generator
        Random random = new Random();
        // Define a date range (start and end dates)
        DateTime startDate = new DateTime(2000, 1, 1);
        DateTime endDate = new DateTime(2023, 12, 31);
        // Generate a random number of days between the start and end dates
        int range = (endDate - startDate).Days;
        // Generate a random number of days to add to the start date
        int randomDays = random.Next(range);
        // Add the random number of days to the start date to get a random date
        DateTime randomDate = startDate.AddDays(randomDays);
        string date = randomDate.ToLongDateString();

        _products.Add(new ElectronicProduct("Laptop","high-performance laptop", 800, "Electronic", 6, "Hewlett Packard" ));
        _products.Add(new ElectronicProduct("Smartphone","Latest model smartphone", 500, "Electronic", 5, "Apple"));
        _products.Add(new ElectronicProduct("Smart TV" ,"4K Smart TV", 700, "Electronic", 10, "SAMSUNG" ));
        _products.Add(new ElectronicProduct("Headphones", "Wireless noise-canceling headphones", 100, "Electronic", 2, "JBL"));
        _products.Add(new ElectronicProduct("Gaming Console", "Next-gen gaming console", 300, "Electronic", 4, "X-BOX"));
        
        _products.Add(new ClothingProduct("T-Shirt", 20, "Plain cotton T-shirt", "Clothing", "Large (L)", "Red", "Silk"));
        _products.Add(new ClothingProduct("Jeans", 40, "Men's blue jeans", "Clothing", "Medium (M)", "Black", "Denim" ));
        _products.Add(new ClothingProduct("Women's Gown", 50, "Women's evening dress", "Clothing", "Small (S)", "White", "Chiffon"));
        _products.Add(new ClothingProduct("Sneakers", 60, "Running sneakers", "Clothing", "38", "Blue", "Cotton"));
        _products.Add(new ClothingProduct("Winter Coat", 80, "Warm winter coat", "Clothing", "Extra Large (XL)", "Green", "Wool" ));
        
        _products.Add(new FoodProduct("Apples (1 lb)", (decimal)1.99, "Fresh, organic apples", "Food", date));
        _products.Add(new FoodProduct("Pasta (2 lbs)", (decimal)2.49, "Italian pasta", "Food", date));
        _products.Add(new FoodProduct("Chicken Breasts (2 lbs)", (decimal)7.99, "Skinless, boneless chicken breasts", "Food", date));
        _products.Add(new FoodProduct("Rice (5 lbs)", (decimal)4.99, "Long-grain white rice", "Food", date));
        _products.Add(new FoodProduct("Milk (1 gallon)", (decimal)2.49, "Fresh whole milk", "Food", date));
        
        _products.Add(new FurnitureProduct("Sofa", 799, "Modern fabric sofa", "Furniture", "Fabric"));
        _products.Add(new FurnitureProduct("Dining Table", 499, "Wooden dining table with chairs", "Furniture", "Wood and Glass"));
        _products.Add(new FurnitureProduct("Bed Frame", 299, "Queen-size bed frame", "Furniture", "Wood"));
        _products.Add(new FurnitureProduct("Bookshelf", 149, "Tall bookshelf with adjustable shelves", "Furniture", "Wood"));
        _products.Add(new FurnitureProduct("Coffee Table", 99, "Glass-top coffee table", "Furniture","Glass and Metal"));
        
        _products.Add(new ToyProduct("LEGO Set", (decimal)39.99, "Large LEGO creative set", "Toy", "5-15 Years"));
        _products.Add(new ToyProduct("Remote Control Car", (decimal)29.99, "Off-road RC car", "Toy", "8-12 Years"));
        _products.Add(new ToyProduct("Barbie Doll", (decimal)19.99, "Fashion doll with accessories", "Toy", "3-12 Years"));
        _products.Add(new ToyProduct("Board Game", (decimal)24.99, "Strategy board game", "Toy", "7+ Years" ));
        _products.Add(new ToyProduct("Action Figure", (decimal)9.99, "Superhero action figure", "Toy", "5-16" ));
    }

    public void AddToCart()
    {
        // DisplayAll();
        Console.Clear();
        Console.WriteLine("Select the product type to add to the cart:");
        Console.Write("1. Electronic Product\n2. Clothing Product\n3. Food Product\n4. Toy Product\n5. Furniture Product\n");
        Console.Write("Enter your choice (1-4): ");
        int choice = int.Parse(Console.ReadLine());

        List<Product> selectedProducts = new List<Product>();

        switch (choice)
        {
            case 1:
                selectedProducts = _products.Where(product => product is ElectronicProduct).ToList();
                break;
            case 2:
                selectedProducts = _products.Where(product => product is ClothingProduct).ToList();
                break;
            case 3:
                selectedProducts = _products.Where(product => product is FoodProduct).ToList();
                break;
            case 4:
                selectedProducts = _products.Where(product => product is ToyProduct).ToList();
                break;
            case 5:
                selectedProducts = _products.Where(product => product is FurnitureProduct).ToList();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        if (selectedProducts.Count == 0)
        {
            Console.WriteLine("No products of the selected type available.");
            return;
        }
        else
        {
            Console.Clear();
            DisplayProducts(selectedProducts);
        }

        Console.Write("Input the 'SERIAL NUMBER' of the item you want to add to your cart: ");
        string pick = Console.ReadLine();
        int productIndex = int.Parse(pick) - 1;

        if (productIndex >= 0 && productIndex < selectedProducts.Count)
        {
            Product selectedProduct = selectedProducts[productIndex];
            _orderedProducts.Add(selectedProduct);
            Console.WriteLine($"-----  {selectedProduct.GetName()} has been added to your cart  ------");
        }
        else
        {
            Console.WriteLine("Invalid 'SERIAL NUMBER'. Please try again.");
        }
        // _orderedProducts.Add(newProduct);
    }

    public void RemoveFromCart()
    {
    
    }

    public void UpdateCart(Product product, int quantity)
    {
    }

    // public decimal CalculateTotalPrice()
    // {
    //     return 
    // }

    public void SaveOrderHistoryToFile()
    {

    }

    public void LoadOrderHistoryFromFile()
    {
        
    }

    public void DisplayAll()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        char star = '\u2605';
        for (int i = 0; i < _products.Count; i++)
        {
            Console.WriteLine($"{star}   " + _products[i].GetProductInfo());
        }
    }

    public void DisplayCart()
    {
        Console.WriteLine("\nThe Items in your Shopping Cart are:");
        for (int i = 0; i <_orderedProducts.Count; i++ )
        {
            Console.WriteLine($"({i + 1}). " + _orderedProducts[i].GetProductInfo());
        }
    }

    public static void DisplayProducts(List<Product> products)
    {
        Console.WriteLine("Available Products:");
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine($"Serial Number: {i + 1}");
            Console.WriteLine(products[i].GetProductInfo());
        }
    }
}