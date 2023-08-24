using Attribute_Handler;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Provide Attribute Name:");
        var attrName = Console.ReadLine();

        Console.WriteLine("Provide Attribute Data Type:");
        var dataType = Console.ReadLine();

        if (!Generatable.DataTypes.Contains(dataType))
        {
            Console.WriteLine("Invalid type.");
        }
    }
}