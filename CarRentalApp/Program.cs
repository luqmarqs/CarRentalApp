using System.Globalization;
using CarRentalAppV2.Entities;
using CarRentalAppV2.Services;

Console.WriteLine("Enter rental data: ");
Console.WriteLine("Car model: ");
string model = Console.ReadLine();
Console.WriteLine("Pickup (dd/MM/yyyy hh:ss): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:ss", CultureInfo.InvariantCulture);
Console.WriteLine("Return (dd/MM/yyyy hh:ss): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:ss", CultureInfo.InvariantCulture);


Console.WriteLine("Enter price per hour: ");
double hour = double.Parse(Console.ReadLine());
Console.WriteLine("Enter price per day: ");
double day = double.Parse(Console.ReadLine());

CarRental carRental = new CarRental(start, finish, new Vehicle(model));

RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

rentalService.ProcessInvoice(carRental);

Console.WriteLine("INVOICE: ");
Console.WriteLine(carRental.Invoice);