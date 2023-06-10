using Aksio.Types;

namespace TypeDiscovery;

public static class Program
{
    public static void Main()
    {
        var types = new Types();
        var typesFound = types.FindMultiple<ISomeInterface>();
    }
}
