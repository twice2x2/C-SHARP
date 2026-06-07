using System;

struct Client
{
    public int ClientCode;
    public string FullName;
    public string Address;
    public string Phone;
    public int OrdersCount;
    public decimal TotalOrdersSum;
}

class Program
{
    static void Main()
    {
        Client client;

        client.ClientCode = 1;
        client.FullName = "Иванов Иван Иванович";
        client.Address = "г. Москва";
        client.Phone = "+7 999 123-45-67";
        client.OrdersCount = 5;
        client.TotalOrdersSum = 120000;

        Console.WriteLine("Код клиента: " + client.ClientCode);
        Console.WriteLine("ФИО: " + client.FullName);
        Console.WriteLine("Адрес: " + client.Address);
        Console.WriteLine("Телефон: " + client.Phone);
        Console.WriteLine("Количество заказов: " + client.OrdersCount);
        Console.WriteLine("Общая сумма заказов: " + client.TotalOrdersSum);
    }
}