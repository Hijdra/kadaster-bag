using Hya.Kadaster.Bag.Exceptions;
using Hya.Kadaster.Bag.Models;
using System.CommandLine;
using System.CommandLine.IO;
using System.Security.Authentication;

namespace Hya.Kadaster.Bag.Tool.Extensions;

public static class ResultExtensions
{
    public static int HandleErrorState<T>(this Result<T> result, IConsole console, Func<T, int> callback)
    {
        return result.On(callback, error =>
        {
            switch (error)
            {
                case BagException bagEx:
                    console.Error.WriteLine($"API error: {bagEx.Error.Title}");
                    break;
                case AuthenticationException:
                    console.Error.WriteLine($"{error.Message}: use 'bag auth -k <api key> -l <true or false>' to set credentials");
                    break;
                default:
                    console.Error.WriteLine($"Error: {error.Message}");
                    break;
            }

            return 1;
        });
    }
}