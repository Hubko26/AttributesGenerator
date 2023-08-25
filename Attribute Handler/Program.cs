using Attribute_Handler;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Provide path to APPEDIA_NG Repo");
        var repo = Console.ReadLine();

        Console.WriteLine("Provide Attribute Name:");
        var attrName = Console.ReadLine();

        Console.WriteLine("Provide Attribute Data Type:");
        var dataType = Console.ReadLine();

        if (!IGeneratable.DataTypes.Contains(dataType))
        {
            Console.WriteLine("Invalid type.");
        }

        IGeneratable attribute;
        if (dataType != null && attrName != null && repo != null) 
        {
            attribute = new Attribute_Handler.Attribute(attrName, dataType, repo);
            attribute.GeneratedCodeAttribute();
        }         

        
    }
}