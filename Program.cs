
using solidPrinciple;

var Order = new DpdPolland();
Order.CustomerSize = 10; 

var Calculator = new CarrierSizeCost();
var cost = Calculator.Calculate(Order);

Console.WriteLine(cost);
