double tax_rate, tip, total;

System.Console.WriteLine("This program will calculate the tax and tip of your meal");
System.Console.WriteLine("How much was your meal?");
Double mealCost = Convert.ToInt32(Console.ReadLine());

tax_rate = 0.0675 * mealCost;
tip = 0.2 * (mealCost + tax_rate);
total = mealCost + tax_rate + tip;

System.Console.WriteLine("The tax amount is " + tax_rate);
System.Console.WriteLine("20% tip is " + tip);
System.Console.WriteLine("The total for your meal is " + total);