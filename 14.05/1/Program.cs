using System;

struct Article
{
    public int ProductCode;
    public string ProductName;
    public decimal Price;
}

class Program
{
    static void Main()
    {
        Article article;

        article.ProductCode = 101;
        article.ProductName = "Ноутбук";
        article.Price = 75000;

        Console.WriteLine("Код товара: " + article.ProductCode);
        Console.WriteLine("Название товара: " + article.ProductName);
        Console.WriteLine("Цена товара: " + article.Price);
    }
}
