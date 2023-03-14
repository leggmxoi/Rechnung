// See https://aka.ms/new-console-template for more information

using _1;

double totalPrice = 0;
double totalTaxes = 0;


Produkt[] data = new Produkt[] {
    new Produkt("Pflegespülung Ice", 3, 7.95),
    new Produkt("Conditioner Tropical", 1, 5.95),
    new Produkt("Antischuppen Special", 5, 9.99)
};

Main();


void Main()
{

    Console.OutputEncoding = System.Text.Encoding.UTF8;
    coverLetter();

    Console.WriteLine("Produkt\t\t\t\tMenge\t\tUst.19%\t\tPreis\t\tGesamt");

    for (int i = 0; i < data.Length; i++)
    {
        showPrice(data[i].Name, data[i].Amount, data[i].Price);
    }

    Console.WriteLine("");

    if (totalPrice > 25)
    {
        Console.WriteLine("Versandkosten \t\t\t\t\t\t\t 0€");
    }
    else
    {
        const double shippingPrice = 5.95;

        Console.WriteLine("Versandkosten \t\t\t\t\t\t\t" + shippingPrice + "€");
        totalTaxes = totalTaxes + shippingPrice * 0.19;
        totalPrice = totalPrice + shippingPrice;
    }
    // Print.total sum
    Console.WriteLine("");
    Console.WriteLine("Gesamtsumme\t\t\t\t" + "Ust.:" + Math.Round(totalTaxes, 2) + " €\t\t" + totalPrice + "€");
}


void coverLetter()
{
    string name = "Herr Flohr";
    string date = "13.03.2023";
    
    Console.WriteLine(
    "Hallo " + name + @",

    Hiermit übersende ich ihnen die Rechnung für meine Leistungen am " + date + @".
    Vielen Dank, dass Sie unsere Dienste genutzt haben.

    Mit freundlichen Grüßen
    Luis Wagner

    ");
}

void showPrice(string productName, int amount, double price)
{

    double total = amount * price;
   
    double taxes = total * 0.19;
   
    totalPrice = totalPrice + total;

    totalTaxes = totalTaxes + taxes;


    Console.WriteLine(productName + "\t\t" +amount+ "\t\t" + Math.Round(taxes, 2)+ "€\t\t" + Math.Round(price, 2) + "€\t\t" + Math.Round(total, 2)+ "€");
}
