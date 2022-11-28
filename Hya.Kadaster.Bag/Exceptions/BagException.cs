using Hya.Kadaster.Bag.Models.Generated;

namespace Hya.Kadaster.Bag.Exceptions;

public class BagException : Exception
{
    public Error Error { get; set; }

    public BagException(Error error) : base(error.Title)
    {
        Error = error;
    }
}