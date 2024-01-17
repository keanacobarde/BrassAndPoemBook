
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds
List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Trumpet",
        Price = 230.50M,
        ProductTypeId = 1,
    },
    new Product()
    {
        Name = "Tuba",
        Price = 2300.50M,
        ProductTypeId = 1,
    },
    new Product()
    {
        Name = "The Road Less Traveled",
        Price = 23.50M,
        ProductTypeId = 2,
    },
    new Product()
    {
        Name = "The Raven",
        Price = 45.50M,
        ProductTypeId = 2,
    },
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    { 
        Title = "Brass",
        ID = 1,
    },
        new ProductType()
    {
        Title = "Poem",
        ID = 2,
    }
};

//put your greeting here
void Greeting()
{
    Console.WriteLine("Welcome to Brass and Poems!");
}

//implement your loop here

void DisplayMenu()
{
    string choice = null;
    while (choice != "5")
    {
        Console.WriteLine(@"Choose an option: 
                      1. Display All Products
                      2. Delete a product
                      3. Add a new product
                      4. Update product properties
                      5. Exit");
        choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("Goodbye");
                break;
            case "2":
                Console.WriteLine("Goodbye");
                break;
            case "3":
                Console.WriteLine("Goodbye");
                break;
            case "4":
                Console.WriteLine("Goodbye");
                break;
            case "5":
                Console.WriteLine("Goodbye");
                break;
            default:
                Console.WriteLine("Please choose a valid option");
                break;
        }
    }
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}


// don't move or change this!
public partial class Program { }