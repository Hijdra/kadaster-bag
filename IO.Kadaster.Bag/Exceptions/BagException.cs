using IO.Kadaster.Bag.Models.Generated;

namespace IO.Kadaster.Bag.Exceptions;

public class BagException : Exception
{
    public Error Error { get; set; }

    public BagException(Error error) : base(error.Title)
    {
        Error = error;
    }
}