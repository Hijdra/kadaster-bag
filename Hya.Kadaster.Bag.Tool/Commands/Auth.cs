using System.CommandLine;
using System.CommandLine.Invocation;

namespace Hya.Kadaster.Bag.Tool.Commands;

public class Auth : Command
{
    public Auth() : base("auth", "Configure authentication with ApiKey and Live settings")
    {
        AddOption(new Option<string>(new[] { "-k", "--api-key" }));
        AddOption(new Option<bool>(new[] { "-l", "--live" }));
    }

    public new class Handler : ICommandHandler
    {
        public string ApiKey { get; set; } // From DI
        public bool? Live { get; set; } // From DI

        public int Invoke(InvocationContext context)
        {
            if (string.IsNullOrEmpty(ApiKey))
            {
                Console.WriteLine($"Error: '{nameof(ApiKey)}' missing");
                return 1;
            }

            if (Live == null)
            {
                Console.WriteLine($"Error: '{nameof(Live)}' missing");
                return 1;
            }

            Environment.SetEnvironmentVariable("Hya_BagOptions__ApiKey", ApiKey, EnvironmentVariableTarget.User);
            Environment.SetEnvironmentVariable("Hya_BagOptions__IsLive", Live.ToString()?.ToLowerInvariant(), EnvironmentVariableTarget.User);

            return 0;
        }

        public Task<int> InvokeAsync(InvocationContext context) => Task.FromResult(Invoke(context));
    }
}