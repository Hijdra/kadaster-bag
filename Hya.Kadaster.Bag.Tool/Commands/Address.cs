using System.CommandLine;

namespace Hya.Kadaster.Bag.Tool.Commands;

public class Address : Command
{
    public Address() : base("address", "Tools for addresses")
    {
        AddCommand(new AddressFind());
        AddCommand(new AddressGet());
    }
}