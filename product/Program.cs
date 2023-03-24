using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using product.BL;

namespace product
{
    class Program
    {
        static string credentialMenu()
        {
            string option;
            Console.WriteLine("1.SignUp");
            Console.WriteLine("2.SignIn");
            Console.WriteLine("3.Exit");
            Console.WriteLine("Enter your choice");
            option = Console.ReadLine();
            return option;

        }
        static MyUser signUp()
        {
            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            Console.WriteLine("Enter userRole");
            string userRole = Console.ReadLine();
            MyUser credential = new MyUser(username, password, userRole);
            return credential;
        }
        static void addSignUpIntoList(MyUser credential , List<MyUser> signUpdata)
        {
            
            signUpdata.Add(credential);
        }
        static string TakeInputWithoutRole(List<MyUser> sign)
        {
            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            string name=SignIn(username,password,sign);
            return name;
        }

        static  string SignIn(string username,string password, List<MyUser> sign)
        {
            foreach (MyUser storedata in sign)
            {
                if (username == storedata.username && storedata.password == password)
                {
                    return storedata.userRole;
                }
            }
            return "NA";

        }
        static string adminMenu()
        {
            string choice;
            Console.WriteLine("1.Add products");
            Console.WriteLine("2.View All Products");
            Console.WriteLine("3.Find producst with highest unit price");
            Console.WriteLine("4.View sales tax of all producs");
            Console.WriteLine("5.Products to be ordered");
            Console.WriteLine("6.Exit");
            Console.WriteLine("Enter your choice");
            choice = Console.ReadLine();
            return choice;

        }
        static Product addProduct()
        {
            
            Console.WriteLine("Enter product name:");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter product category:(Grocery , Fruit , any other)");
            string productCategory = Console.ReadLine();
            Console.WriteLine("Enter product price:");
            float productPrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter available stock quantity:");
            int availableQuantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minimum stock threshold quantity:");
            int thresholdQuantity = int.Parse(Console.ReadLine());
            Product pData = new Product(productName, productCategory , productPrice , availableQuantity , thresholdQuantity);
            return pData;
        }
        static void addProductIntoList(Product pData , List<Product> productData)
        {
            productData.Add(pData);
        }
        static Product addProductForCaculateTax()
        {
            Console.WriteLine("Enter product name:");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter product category:(Grocery , Fruit , any other)");
            string productCategory = Console.ReadLine();
            Console.WriteLine("Enter product price:");
            float productPrice = float.Parse(Console.ReadLine());
            Product pData = new Product(productName, productCategory , productPrice);
            return pData;
        }
        static void viewproducts(List<Product> productData)
        {
           
            Console.WriteLine("Name" + "\t\t" + "Catogery" + "\t\t" + "Price" + "\t\t" + "Available Quatity" + "\t\t" + "Threshold Quantity");
            for (int i = 0; i < productData.Count; i++)
            {
                Console.WriteLine(productData[i].productName + "\t\t" + productData[i].productCategory + "\t\t" + productData[i].productPrice
                    + "\t\t" + productData[i].availableQuantity + "\t\t" + productData[i].thresholdQuantity);
            }

        }

       static void findHighest(List<Product> productData)
        {
            float min = -10;
            string name = "";
            for(int i = 0; i < productData.Count; i++)
            {
                if(min < productData[i].productPrice)
                {
                    min = productData[i].productPrice;
                    name = productData[i].productName;
                }
            }
            Console.WriteLine("Product of highest price is:");
            Console.WriteLine("Product :" + name);
            Console.WriteLine("Price:" + min);
        }
        static void orderedProducts(List<Product> productData)
        {
            for(int i=0; i< productData.Count; i++)
            {
                Console.WriteLine("Enter name of the product to order it");
                string orderProduct = Console.ReadLine();
                if(orderProduct == productData[i].productName)
                {
                    if (productData[i].availableQuantity <= productData[i].thresholdQuantity)
                    {
                        Console.WriteLine(productData[i].productName + "'s quantity is very less so there is need of ordering the products");

                    }
                }
                   
            }
          
        }
        static void GenerateInVoice()
        {

        }
        //.......................

        static string customerMenu()
        {
            string choice1;
            Console.WriteLine("1.View all products");
            Console.WriteLine("2.Buy products");
            Console.WriteLine("3.Generate invoice");
            Console.WriteLine("4.Exit");
            Console.WriteLine("Enter your choice");
            choice1 = Console.ReadLine();
            return choice1;

        }

        static void buyProduct(List<Product> productData)
        {
            Console.WriteLine("Enter name of the product to buy it");
            string buyProduct = Console.ReadLine();
            Console.WriteLine("Enter quantity of the product to buy it");
            int buyQuantity = int.Parse(Console.ReadLine());
           
            for(int i=0 ; i< productData.Count; i++)
            {
                if(buyProduct == productData[i].productName)
                {
                    Console.WriteLine("Product is available");
                    if (buyQuantity < productData[i].availableQuantity)
                    {
                        Console.WriteLine("Quantity  is  also available");
                        
                        productData[i].availableQuantity = productData[i].availableQuantity - buyQuantity;
                        Console.WriteLine("you have bought" + buyProduct);
                    }
                    else
                    {
                        Console.WriteLine("Quantity  is  not  available");
                    }
                }
                else
                {
                    Console.WriteLine("Product is not available");
                }

            }
        }
        //..................................................

        static void clear()
        {
            Console.WriteLine("Press any key to continue:");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
           List<Product> productData = new List<Product>();
           List<MyUser> signUpdata = new List<MyUser>();
            string option;
            option = credentialMenu();
          //  MyUser credential = new MyUser();
            while (option == "1" || option == "2" || option == "3")
            {
                if (option == "1")
                {
                    Console.Clear();

                    MyUser credential = signUp();
                        addSignUpIntoList(credential , signUpdata);
                    clear();
                    Console.Clear();
                    option = credentialMenu();
                    clear();
                    
                }
                if (option == "2")
                {
                   
                    string role=TakeInputWithoutRole(signUpdata);
                    Console.Clear();
                    if(role == "admin")
                    {
                        Console.Clear();
                        Console.WriteLine("Congratulations, you successfully Login:");
                        clear();
                        Console.Clear();
                        string choice;
                        choice = adminMenu();
                        if(choice == "1")
                        {
                            Console.Clear();
                            Product dataProduct = addProduct();
                            addProductIntoList(dataProduct, productData);
                            clear();
                            Console.Clear();
                            choice = adminMenu();
                        }
                        if (choice == "2")
                        {
                            Console.Clear();
                            viewproducts(productData);
                            //buyProduct(productData);
                            clear();
                            Console.Clear();
                            choice = adminMenu();
                        }
                        if (choice == "3")
                        {
                            Console.Clear();
                            findHighest(productData);
                            clear();
                            Console.Clear();
                            choice = adminMenu();
                        }
                        if (choice == "4")
                        {
                            Console.Clear();
                            Product data1 = addProductForCaculateTax();
                            float tax = data1.calculateTax();
                            Console.WriteLine("Tax is.........." + tax);
                            clear();
                            Console.Clear();
                            choice = adminMenu();
                        }
                        if (choice == "5")
                        {
                            Console.Clear();
                            orderedProducts( productData);
                            clear();
                            Console.Clear();
                            choice = adminMenu();
                        }
                        if (choice == "6")
                        {
                            break;
                        }
                        option = credentialMenu();
                        clear();
                    }
                    else if(role=="customer")
                    {
                        string choice1 = customerMenu();
                        if(choice1 == "1")
                        {
                            Console.Clear();
                            viewproducts(productData);
                            clear();
                            Console.Clear();
                            choice1 = customerMenu();
                        }
                        if (choice1 == "2")
                        {
                            Console.Clear();
                            buyProduct( productData);
                            clear();
                            Console.Clear();
                            choice1 = customerMenu();
                        }
                        if (choice1 == "3")
                        {
                            Console.Clear();
                            
                            clear();
                            Console.Clear();
                            choice1 = customerMenu();
                        }
                        if (choice1 == "4")
                        {
                            break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid User.");
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        option = credentialMenu();
                    }
                   
                }
                if (option == "3")
                {
                    break;
                }
            }
            Console.ReadKey();

        }
    }
}
