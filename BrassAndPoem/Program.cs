﻿
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds
using System.Collections;
using System.ComponentModel;

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
                DisplayAllProducts(products, productTypes);
                break;
            case "2":
                DeleteProduct(products, productTypes);
                break;
            case "3":
                AddProduct(products, productTypes);
                break;
            case "4":
                UpdateProduct(products, productTypes);
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
    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1} - {products[i].Name} is for sale and costs {products[i].Price}. It is of the {productTypes.Where(pt => pt.ID == products[i].ProductTypeId).ToList()[0].Title} variety");
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    string choice = null;

    while (choice != "0")
    {
        try
        {
            // loop through products but create a ReadLine
            Console.WriteLine("0. Goodbye");
            DisplayAllProducts(products, productTypes);
            choice = Console.ReadLine();
            products.RemoveAt(Int32.Parse(choice) - 1);
        }
        catch
        {
            break;
        }

    }
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    // OBTAINING USER INPUT
    Console.WriteLine("Please supply the product name");
    string prodName = Console.ReadLine();
    Console.WriteLine("Please supply the asking price of the product");
    decimal prodAskingPrice = Decimal.Parse(Console.ReadLine());
    Console.WriteLine("Please supply the product type ID. 1 for Brass. 2 for Poem.");
    int prodType = Int32.Parse(Console.ReadLine());

    // Taking user input and appending it to new instance of proj
    try
    {
        Product ProdToAdd = new Product();
        ProdToAdd.Name = prodName;
        ProdToAdd.Price = prodAskingPrice;
        ProdToAdd.ProductTypeId = prodType;
        // Adding user created prod
        products.Add(ProdToAdd);
    }
    catch
    {
        Console.WriteLine("Enter a valid data type!");
    }
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    string choice = null;

    while (choice != "0")
    {
        try
        {
            // loop through products but create a ReadLine
            Console.WriteLine("0. Goodbye");
            DisplayAllProducts(products, productTypes);
            Console.WriteLine("Choose the item you wish to edit.");
            choice = Console.ReadLine();
            Product IndxChoice = products[Int32.Parse(choice) - 1];

            // view the properties of the object that you're looking to edit
            foreach (PropertyDescriptor desc in TypeDescriptor.GetProperties(IndxChoice))
            {
                string name = desc.Name;
                object value = desc.GetValue(IndxChoice);
                Console.WriteLine(name + ": " + value);
            }

            string prodName = IndxChoice.Name;
            decimal prodAskingPrice = IndxChoice.Price;
            int prodType = IndxChoice.ProductTypeId;

            Console.WriteLine("Please supply the product name");
            string prodNameEntry = Console.ReadLine();
            if (prodNameEntry == "")
            {
                Console.WriteLine("Saving original name.");
            }
            else
            {
                prodName = prodNameEntry;
            }
            Console.WriteLine("Please supply the asking price of the product");
            string prodAskingPriceEntry = Console.ReadLine();
            if (decimal.TryParse(prodAskingPriceEntry, out decimal userSetPrice))
            {
                prodAskingPrice = userSetPrice;

            }
            else
            {
                Console.WriteLine("Saving original price.");
            }
            Console.WriteLine("Please supply the product type ID. 1 for Brass. 2 for Poem.");
            string prodTypeEntry = Console.ReadLine();
            if (Int32.TryParse(prodTypeEntry, out int userSetId))
            {
                prodType = userSetId;

            }
            else
            {
                Console.WriteLine("Saving product type.");
            }
            // Delete old obj 
            products.RemoveAt(Int32.Parse(choice) - 1);
            Product ProdToAdd = new Product();
            ProdToAdd.Name = prodName;
            ProdToAdd.Price = prodAskingPrice;
            ProdToAdd.ProductTypeId = prodType;
            //Readd updated obj
            products.Add(ProdToAdd);
        }
        catch
        {
            Console.WriteLine("Invalid Entry");
            break;
        }
    }
}



Greeting();
DisplayMenu();

// don't move or change this!
public partial class Program { }