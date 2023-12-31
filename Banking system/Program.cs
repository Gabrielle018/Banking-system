using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        ShowData();
        Bank b = new Bank();
        int press;
        while (true)

        {
            Choice();
            press = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (press == 1)
            {
                b.Data(press);

            }
            else if (press == 2)
            {
                b.Transac(press);

            }
            else if (press == 3)
            {
                b.Exit(press);

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input");
            }
        }
    }

    static void ShowData()
    {
        char[] arrshow = { ' ', ' ', ' ', 'B', 'A', 'N', 'K', ' ', 'M', 'A', 'N', 'A', 'G', 'E', 'M', 'E', 'N', 'T', ' ', 'S', 'Y', 'S', 'T', 'E', 'M' };
        for (int i = 0; i < arrshow.Length; i++)
        {
            Console.Write(arrshow[i]);
            Thread.Sleep(300);
        }
        Console.Clear();
    }

    static void Choice()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("|Welcome to Bank Management System  |");
        Console.WriteLine("|1. Registration of an account      |");
        Console.WriteLine("|2. Transactions                    |");
        Console.WriteLine("|3. Exit                            |");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine(" ");
        Console.Write("Press number: ");
    }
}

class Bank
{
    
    private string[] arr = new string[20];
    private string[] arr1 = new string[20];
    private string[] arr2 = new string[20];
    private string[] arr3 = new string[20];
    private string[] arr4 = new string[20];
    private string[] arr5 = new string[20];
    private string[] arr6 = new string[20];
    private double[] arr7 = new double[20];
    private int a;

    public Bank()
    {
        a = 0;
    }


    public void Data(int x)
    {
        if (x == 1)
        {
            int click;
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("|Press 1 for Create new accounts                      |");
            Console.WriteLine("|Press 2 for Update information of exisitng account   |");
            Console.WriteLine("|Press 3 for Check details of your account            |");
            Console.WriteLine("|Press 4 for Remove an existing account               |");
            Console.WriteLine("|Press 5 for View customers list                      |");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(" ");
            Console.Write("Enter your option : ");
            click = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (click == 1)
            {
                int count = 0;
                int b = 0;
                Console.Write("How many accounts do you want to create : ");
                b = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                {
                    a = a + b;
                    for (int i = 0; i < b; i++)
                    {

                        do
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\t----Enter Data----\n");
                            Console.Write("Enter Your First Name: ");
                            arr[i] = Console.ReadLine();
                            Console.Write("Enter Your Middle Name : ");
                            arr1[i] = Console.ReadLine();
                            Console.Write("Enter Your Last Name: ");
                            arr2[i] = Console.ReadLine();
                            Console.Write("Enter phone number: ");
                            arr3[i] = Convert.ToString(Console.ReadLine());
                            Console.Write("Enter Your Email address: ");
                            arr4[i] = Console.ReadLine();
                            Console.Write("Enter username: ");
                            arr5[i] = Console.ReadLine();
                            Console.Write("Enter your 4-digit MPIN: ");
                            arr6[i] = Console.ReadLine();
                            Console.Write("Amount to Deposit (Minimum 1000 pesos): ");
                            arr7[i] = Double.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Red;
                            if (arr3[i].Length != 11)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("Invalid phone number");
                                count++;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nPress any key to continue...");
                                Console.ReadKey(true);
                                Console.Clear();
                                continue;
                            }
                            else if (arr6[i].Length != 4)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("Invalid MPIN");
                                count++;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nPress any key to continue...");
                                Console.ReadKey(true);
                                Console.Clear();
                                continue;

                            }
                            else if (arr7[i] < 1000)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Can't create your account. Minimum deposit amount is 1000 pesos.");
                                count++;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nPress any key to continue...");
                                Console.ReadKey(true);
                                Console.Clear();
                                continue;
                            }
                            else if (!arr4[i].Contains("@") || !arr4[i].EndsWith(".com"))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid email address format");
                                count++;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nPress any key to continue...");
                                Console.ReadKey(true);
                                Console.Clear();
                                continue;
                            }
                            else
                            {
                                count = 1;
                            }
                        } while (arr3[i].Length != 11 || arr6[i].Length != 4 || arr7[i] < 1000 || !arr4[i].Contains("@") || !arr4[i].EndsWith(".com"));
                    }

                    {


                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Creating new account please wait");
                        for (int c = 0; c < 5; c++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write(".");
                            Thread.Sleep(500);
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("New Account is Created..!!");
                    }


                }
                else
                {
                    for (int i = a; i < a + b; i++)
                    {
                        Console.WriteLine("\n\t----Enter Data----\n");
                        Console.Write("Enter Your First Name: ");
                        arr[i] = Console.ReadLine();
                        Console.Write("Enter Your Middle Name : ");
                        arr1[i] = Console.ReadLine();
                        Console.Write("Enter Your Last Name: ");
                        arr2[i] = Console.ReadLine();
                        Console.Write("Enter phone number: ");
                        arr3[i] = Convert.ToString(Console.ReadLine());
                        Console.Write("Enter your email address: ");
                        arr4[i] = Console.ReadLine();
                        Console.Write("Enter username: ");
                        arr5[i] = Console.ReadLine();
                        Console.Write("Enter your 4-digit MPIN: ");
                        arr6[i] = Console.ReadLine();
                        Console.Write("Amount to Deposit (Minimum 1000 pesos): ");
                        arr7[i] = Double.Parse(Console.ReadLine());



                        if (!arr4[i].Contains("@") || !arr4[i].EndsWith(".com"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid email address format");
                            count++;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey(true);
                            Console.Clear();
                            i--;
                            continue;
                        }
                        else if (arr3[i].Length != 11)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Invalid phone number");
                            count++;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey(true);
                            Console.Clear();
                            i--;
                            continue;
                        }
                        else if (arr6[i].Length != 4)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Invalid MPIN");
                            count++;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey(true);
                            Console.Clear();
                            i--;
                            continue;
                        }
                        else if (arr7[i] < 1000)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Can't create your account. Minimum deposit amount is 1000 pesos.");
                            count++;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey(true);
                            Console.Clear();
                            i--;
                            continue;
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Creating new account please wait");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(".");
                        Thread.Sleep(300);
                    }
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("New Account is Created..!!");
                    a = a + b;
                }
            }
            
            else if (click == 2)
            {
                if (a == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No data is entered");
                }
                else
                {
                    string pass;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Update your information");
                    Console.WriteLine(" ");
                    Console.Write("MPIN : ");
                    pass = Console.ReadLine();
                    Console.Clear();

                    bool dataUpdated = false;
                    bool mpinMatched = false;
                    int matchingIndex = -1;
                    

                    for (int i = 0; i < a; i++)
                    {
                        if (pass == arr6[i])
                        {
                            mpinMatched = true;
                            matchingIndex = i;
                            break;
                        }
                    }

                    if (!mpinMatched)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid MPIN");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey(true);
                        Console.Clear();
                    }
                    else
                    {
                        
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\t\n---Old Data---\n");
                            Console.WriteLine("First Name: " + arr[matchingIndex]);
                            Console.WriteLine("Middle Name: " + arr1[matchingIndex]);
                            Console.WriteLine("Last name: " + arr2[matchingIndex]);
                            Console.WriteLine("Phone: " + arr3[matchingIndex]);
                            Console.WriteLine("Email: " + arr4[matchingIndex]);
                            Console.WriteLine("Username: " + arr5[matchingIndex]);
                            Console.WriteLine("MPIN: " + arr6[matchingIndex]);
                            Console.WriteLine("Balance: " + arr7[matchingIndex]);
                            Console.WriteLine(" ");
                       


                        int pr;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("|Press 1 to change your MPIN         |");
                        Console.WriteLine("|Press 2 to change your username     |");
                        Console.WriteLine("|Press 3 to change your email        |");
                        Console.WriteLine("|Press 4 to change your phone number |");
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine(" ");
                        Console.Write("Enter your option : ");
                        pr = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (a == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No data is entered");
                        }
                        if (pr == 1)
                        {

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Enter your new 4-time MPIN : ");
                            for (int i = 0; i < a; i++)
                            {

                                arr6[matchingIndex] = Console.ReadLine();
                                if (arr6[matchingIndex].Length != 4)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Invalid MPIN");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nPress any key to continue...");
                                    Console.ReadKey(true);
                                    Console.Clear();
                                    break;
                                }

                                else
                                {
                                    string y;
                                    Console.WriteLine(" ");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\nPress (y/Y) to confirm..");
                                    Console.WriteLine(" ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("Enter your option : ");
                                    y = Console.ReadLine();
                                    Console.WriteLine(" ");

                                    if (y == "y" || y == "Y")
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("Processing");
                                        for (int d = 0; d < 5; d++)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.Write(".");
                                            Thread.Sleep(500);
                                        }

                                        Thread.Sleep(3000);
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nProcess complete...\n");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nPress any key to continue...");
                                        Console.ReadKey(true);
                                        Console.Clear();
                                        Console.WriteLine("Thank you");
                                        Console.Clear();

                                        dataUpdated = true;
                                        break;

                                    }






                                }
                                if (dataUpdated)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Thank you");
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Invalid input or no changes made");
                                    Console.WriteLine("Thank you");
                                    Console.Clear();
                                }



                            }
                        }
                        else if (pr == 2)
                        {

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Enter your new username : ");
                            for (int i = 0; i < a; i++)
                            {
                              
                                arr5[matchingIndex] = Console.ReadLine();


                                {

                                    string ys;
                                    Console.WriteLine(" ");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\nPress (y/Y) to confirm..");
                                    Console.WriteLine(" ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("Enter your option : ");
                                    ys = Console.ReadLine();
                                    Console.WriteLine(" ");

                                    if (ys == "y" || ys == "Y")
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("Processing");
                                        for (int d = 0; d < 5; d++)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.Write(".");
                                            Thread.Sleep(500);
                                        }

                                        Thread.Sleep(3000);
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nProcess complete...\n");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nPress any key to continue...");
                                        Console.ReadKey(true);
                                        Console.Clear();
                                        Console.WriteLine("Thank you");
                                        Console.Clear();

                                        dataUpdated = true;
                                        break;



                                    }




                                }
                                if (dataUpdated)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Thank you");
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Invalid input or no changes made");
                                    Console.WriteLine("Thank you");
                                    Console.Clear();
                                }
                            }
                        }
                        else if (pr == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Enter your new email : ");
                            for (int i = 0; i < a; i++)
                            {
                                arr4[matchingIndex] = Console.ReadLine();
                                if (!arr4[matchingIndex].Contains("@") || !arr4[matchingIndex].EndsWith(".com"))
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Invalid email address format");

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nPress any key to continue...");
                                    Console.ReadKey(true);
                                    break;
                                }
                                else
                                {
                                    string agree;
                                    Console.WriteLine(" ");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\nPress (y/Y) to confirm..");
                                    Console.WriteLine(" ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("Enter your option : ");
                                    agree = Console.ReadLine();
                                    Console.WriteLine(" ");
                                    

                                    if (agree == "y" || agree == "Y")

                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("Processing");
                                        for (int d = 0; d < 5; d++)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.Write(".");
                                            Thread.Sleep(500);
                                        }
                                        Thread.Sleep(3000);
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nProcess complete...\n");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nPress any key to continue...");
                                        Console.ReadKey(true);
                                        Console.Clear();
                                        Console.WriteLine("Thank you");
                                        Console.Clear();

                                        dataUpdated = true;
                                        break;

                                    }
                                }
                                if (dataUpdated)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Thank you");
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Invalid input or no changes made");
                                    Console.WriteLine("Thank you");
                                    Console.Clear();
                                }
                            }
                        }
                        else if (pr == 4)
                        {
                            string agr;



                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Enter your new phone number : ");
                            for (int i = 0; i < a; i++)
                            {
                                
                                arr3[matchingIndex] = Console.ReadLine();
                                if (arr3[matchingIndex].Length != 11)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Invalid phone number");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nPress any key to continue...");
                                    Console.ReadKey(true);
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine(" ");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\nPress (y/Y) to confirm..");
                                    Console.WriteLine(" ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("Enter your option : ");
                                    agr = Console.ReadLine();
                                    Console.WriteLine(" ");


                                    if (agr == "y" || agr == "Y")

                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("Processing");
                                        for (int d = 0; d < 5; d++)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.Write(".");
                                            Thread.Sleep(500);
                                        }
                                        Thread.Sleep(3000);
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nProcess complete...\n");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nPress any key to continue...");
                                        Console.ReadKey(true);
                                        Console.Clear();
                                        Console.WriteLine("Thank you");
                                        Console.Clear();

                                        dataUpdated = true;
                                        break;

                                    }
                                }
                                if (dataUpdated)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Thank you");
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Invalid input or no changes made");
                                    Console.WriteLine("Thank you");
                                    Console.Clear();
                                }
                            }
                        }
                    }

                }
            }






            else if (click == 3)
            {
                if (a == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No data is entered");
                }
                else
                {
                    int pss;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Check details of your account");
                    Console.WriteLine(" ");
                    Console.Write("Enter your MPIN: ");
                    pss = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    bool sameMPIN = false;
                    for (int i = 0; i < a; i++)
                    {


                        if (arr6[i].Length == 4 && pss == Convert.ToInt32(arr6[i]))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("DETAILS OF YOUR ACCOUNT");
                            Console.WriteLine(" ");
                            Console.WriteLine("\n\t----Data----\n");
                            Console.WriteLine("First Name: " + arr[i]);
                            Console.WriteLine("Middle Name: " + arr1[i]);
                            Console.WriteLine("Last name: " + arr2[i]);
                            Console.WriteLine("Phone: " + arr3[i]);
                            Console.WriteLine("Email: " + arr4[i]);
                            Console.WriteLine("Username: " + arr5[i]);
                            Console.WriteLine("MPIN: " + arr6[i]);
                            Console.WriteLine("Balance: " + arr7[i]);

                            sameMPIN = true;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey(true);
                            Console.Clear();
                        }
                    }
                    if (!sameMPIN)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid MPIN");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey(true);
                        Console.Clear();

                    }

                }
            }
            else if (click == 4)
            {
                if (a == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No data is entered");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    int press;
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("|Press 1 to delete specific record |");
                    Console.WriteLine("|Press 2 to delete full record     |");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine(" ");
                    Console.Write("Enter your option : ");
                    press = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (press == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Remove existing account");
                        Console.WriteLine(" ");

                        string pwd;
                        int foundIndex = -1;

                        Console.Write("Enter your MPIN : ");
                        pwd = Console.ReadLine();

                        for (int i = 0; i < a; i++)
                        {
                            if (pwd == arr6[i])
                            {
                                foundIndex = i;
                                break;
                            }
                        }

                        if (foundIndex != -1)
                        {
                            Console.WriteLine("\nAre you sure? (Press y/Y)");
                            Console.WriteLine(" ");
                            Console.Write("Enter your option : ");
                            string yes = Console.ReadLine();

                            if (yes == "y" || yes == "Y")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Processing");
                                for (int d = 0; d < 5; d++)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write(".");
                                    Thread.Sleep(500);
                                }
                                Thread.Sleep(3000);
                                Console.Clear();


                                for (int j = foundIndex; j < a - 1; j++)
                                {
                                    arr[j] = arr[j + 1];
                                    arr1[j] = arr1[j + 1];
                                    arr2[j] = arr2[j + 1];
                                    arr3[j] = arr3[j + 1];
                                    arr4[j] = arr4[j + 1];
                                    arr5[j] = arr5[j + 1];
                                    arr6[j] = arr6[j + 1];
                                    arr7[j] = arr7[j + 1];
                                }
                                a--;

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Required record is deleted..!!");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Deletion cancelled");
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid MPIN");
                        }
                    }
                    else if (press == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Deleting");
                        for (int c = 0; c < 5; c++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write(".");
                            Thread.Sleep(500);
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;

                        a = 0;
                        Console.WriteLine("All records are deleted");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input");
                    }
                }
            }
            else if (click == 5)
            {
                if (a == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No data is entered");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t\t----Data----\n");
                    for (int i = 0; i < a; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nData of person " + (i + 1) + "\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("First Name: " + arr[i]);
                        Console.WriteLine("Middle Name: " + arr1[i]);
                        Console.WriteLine("Last name: " + arr2[i]);
                        Console.WriteLine("Phone: " + arr3[i]);
                        Console.WriteLine("Email: " + arr4[i]);
                        Console.WriteLine("Username: " + arr5[i]);
                        Console.WriteLine("Password: " + arr6[i]);
                        Console.WriteLine("Balance: " + arr7[i]);


                    }
                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey(true);
                    Console.Clear();
                }
            }
        }
    }




    public void Transac(int x)
    {
        if (a == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No data is entered");
        }
        else if (x == 2)
        {
            string pass;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter your MPIN : ");
            pass = Console.ReadLine();
            Console.Clear();



            bool transacPin = false;
            bool matchedMPIN = false;

            for (int i = 0; i < a; i++)
            {
                if (pass == arr6[i])
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t\n----Data----\n");
                    Console.WriteLine("First Name: " + arr[i]);
                    Console.WriteLine("Middle Name: " + arr1[i]);
                    Console.WriteLine("Last name: " + arr2[i]);
                    Console.WriteLine("Phone: " + arr3[i]);
                    Console.WriteLine("Email: " + arr4[i]);
                    Console.WriteLine("Username: " + arr5[i]);
                    Console.WriteLine("MPIN: " + arr6[i]);
                    Console.WriteLine("Balance: " + arr7[i]);

                    matchedMPIN = true;
                    transacPin = true;
                    break;
                }
            }
            if (!matchedMPIN)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid MPIN");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey(true);
                Console.Clear();

            }
            else
            {


                Console.ForegroundColor = ConsoleColor.White;
                int press;
                Console.WriteLine(" ");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("|Press 1 for Withdraw              |");
                Console.WriteLine("|Press 2 for Loan                  |");
                Console.WriteLine("|Press 3 for Bill Payment Services |");
                Console.WriteLine("|Press 4 for Transfer Money        |");
                Console.WriteLine("------------------------------------");
                Console.WriteLine(" ");
                Console.Write("Enter your option: ");
                press = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (press == 1)
                {
                    for (int i = 0; i < a; i++)
                    {
                        string yes;
                        double money, sub = 0;
                        Console.Write("\nEnter amount : ");
                        money = Double.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nPress Y / y to confirm your transaction...");
                        Console.WriteLine(" ");
                        Console.Write("Enter your option : ");
                        yes = Console.ReadLine();
                        if (yes == "y" || yes == "Y")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Processing");
                            for (int d = 0; d < 5; d++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write(".");
                                Thread.Sleep(500);
                            }
                            Thread.Sleep(3000);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Transaction has been completed.");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Thank you");
                        }
                        {
                            if (arr7[i] >= money)
                            {
                                sub = arr7[i] - money;
                                arr7[i] = sub;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("\n" + money + " Pesos is withdrawn from this account\n");
                                string formattedDecimal = sub.ToString("0.00");
                                Console.WriteLine("\nYour balance is now " + formattedDecimal + " pesos");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Insufficient funds for withdrawal.");


                            }
                        }
                        transacPin = true;
                        break;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();



                }
                if (press == 2)
                {
                    for (int i = 0; i < a; i++)
                    {

                        double money, sum = 0;
                        Console.Write("Existing money: " + arr7[i]);
                        Console.Write("\nEnter how much money you need to Loan: ");
                        money = Double.Parse(Console.ReadLine());
                        sum = arr7[i] + money;
                        arr7[i] = sum;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\nYou borrowed money from the account\n");
                        string formattedDecimal = sum.ToString("0.00");
                        Console.WriteLine("\nYour balance is now " + formattedDecimal + " pesos");

                        transacPin = true;
                        break;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey(true);
                    Console.Clear();

                }
                else if (press == 3)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" ");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("|Press 1 for Electric Bill Payment |");
                    Console.WriteLine("|Press 2 for Internet Bill Payment |");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine(" ");
                    Console.Write("Enter your option : ");
                    int billType = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    for (int i = 0; i < a; i++)
                    {

                        double billAmount;
                        Console.WriteLine(" ");
                        Console.Write("Existing money: " + arr7[i]);
                        Console.WriteLine(" ");
                        Console.Write("Enter bill amount for payment: ");
                        Console.WriteLine(" ");
                        billAmount = Double.Parse(Console.ReadLine());

                        if (arr7[i] >= billAmount)
                        {
                            arr7[i] -= billAmount;

                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            if (billType == 1)
                            {

                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine(" ");
                                Console.WriteLine("Processing");
                                for (int d = 0; d < 5; d++)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write(".");
                                    Thread.Sleep(500);
                                }
                                Thread.Sleep(3000);
                                Console.WriteLine(" ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                string formattedDecimal = billAmount.ToString("0.00");
                                Console.WriteLine("\nElectric bill paid. Your balance is now " + formattedDecimal + " pesos");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nPress any key to continue...");
                                Console.ReadKey(true);
                                Console.Clear();
                            }
                            else if (billType == 2)
                            {

                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine(" ");
                                Console.WriteLine("Processing");
                                for (int d = 0; d < 5; d++)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write(".");
                                    Thread.Sleep(500);
                                }
                                Thread.Sleep(3000);
                                Console.WriteLine(" ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                string formattedDecimal = billAmount.ToString("0.00");
                                Console.WriteLine("\nInternet bill paid. Your balance is now " + formattedDecimal + " pesos");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nPress any key to continue...");
                                Console.ReadKey(true);
                                Console.Clear();
                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Insufficient funds for bill payment.");
                        }
                        transacPin = true;
                        break;

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey(true);
                        Console.Clear();

                    }
                }
                else if (press == 4)
                {
                    if (a == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Can't perform transfer. No other accounts available.");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey(true);
                        Console.Clear();
                    }
                    else
                    {
                        int transferFromIndex = -1;
                        int transferToIndex = -1;

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Enter your email: ");
                        string senderAccountNumber = Console.ReadLine();

                        Console.WriteLine(" ");

                        Console.Write("Enter recipient's email: ");
                        string recipientAccountNumber = Console.ReadLine();

                        for (int i = 0; i < a; i++)
                        {
                            if (arr4[i] == senderAccountNumber)
                            {
                                transferFromIndex = i;
                            }

                            if (arr4[i] == recipientAccountNumber)
                            {
                                transferToIndex = i;
                            }
                        }

                        if (transferFromIndex != -1 && transferToIndex != -1)
                        {
                            int transferAmount;
                            Console.WriteLine(" ");
                            Console.Write("Enter amount to transfer: ");
                            transferAmount = Convert.ToInt32(Console.ReadLine());

                            if (arr7[transferFromIndex] >= transferAmount)
                            {
                                arr7[transferFromIndex] -= transferAmount;
                                arr7[transferToIndex] += transferAmount;


                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine(" ");
                                Console.WriteLine("Processing");
                                for (int d = 0; d < 5; d++)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write(".");
                                    Thread.Sleep(500);
                                }
                                Thread.Sleep(3000);
                                Console.WriteLine(" ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nTransferred {transferAmount} pesos from account {senderAccountNumber} to account {recipientAccountNumber}");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Insufficient funds for transfer.");
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid account number(s).");
                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey(true);
                        Console.Clear();
                    }
                }
                if (transacPin)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Thank you");
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input or no changes made");
                    Console.WriteLine("Thank you");
                    Console.Clear();
                }
            }
        }
    }




    public void Exit(int x)
    {
        if (x == 3)
            Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Thank You..!!");
        Environment.Exit(0);
    }

}




