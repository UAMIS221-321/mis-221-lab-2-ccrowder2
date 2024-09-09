// initialize variables
using System.Runtime.CompilerServices;

int numberOfSandwiches = 0;
int numberOfToppings = 0;
double tip = 0;
double totalSandwichCost;
double totalToppingCost;
double baseCost;

//initialize constants
const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.10;

//prompt the user for # sandwiches
System.Console.WriteLine("How many sandwiches?");
numberOfSandwiches = int.Parse(Console.ReadLine());
System.Console.WriteLine("Sandwiches "+numberOfSandwiches);

//prompt the user for # toppings
System.Console.WriteLine("What is the number of toppings you'd like?");
numberOfToppings = int.Parse(Console.ReadLine());
System.Console.WriteLine("Toppings "+numberOfToppings);

//prompt the user for tip
System.Console.WriteLine("What is the tip you'd like to leave?");
tip = double.Parse(Console.ReadLine());
System.Console.WriteLine("Tip "+tip);

totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
totalToppingCost = COST_OF_TOPPING * numberOfToppings;
baseCost = totalSandwichCost + totalToppingCost;

double orderCost = (tip + baseCost*(1-DISCOUNT_AMOUNT));

System.Console.WriteLine("The total cost of your order is $"+ Math.Round(orderCost, 2));