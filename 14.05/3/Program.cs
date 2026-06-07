using System;

struct RequestItem
{
    public string Product;
    public int Quantity;
}

class Program
{
    static void Main()
    {
        RequestItem item;

        item.Product = "Мышь";
        item.Quantity = 3;

        Console.WriteLine("Товар: " + item.Product);
        Console.WriteLine("Количество: " + item.Quantity);
    }
}