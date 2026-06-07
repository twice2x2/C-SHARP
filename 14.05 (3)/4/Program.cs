using System;

struct Request
{
    public int OrderCode;
    public int ClientCode;
    public DateTime OrderDate;
    public int ProductCount;
    public decimal ProductPrice;

    public decimal OrderSum
    {
        get { return ProductCount * ProductPrice; }
    }
}

class Program
{
    static void Main()
    {
        Request request;

        request.OrderCode = 1001;
        request.ClientCode = 1;
        request.OrderDate = DateTime.Now;
        request.ProductCount = 4;
        request.ProductPrice = 1500;

        Console.WriteLine("Код заказа: " + request.OrderCode);
        Console.WriteLine("Код клиента: " + request.ClientCode);
        Console.WriteLine("Дата заказа: " + request.OrderDate.ToShortDateString());
        Console.WriteLine("Количество товаров: " + request.ProductCount);
        Console.WriteLine("Цена товара: " + request.ProductPrice);
        Console.WriteLine("Сумма заказа: " + request.OrderSum);
    }
}