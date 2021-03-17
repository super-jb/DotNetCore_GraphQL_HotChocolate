using System.Threading;
using System.Threading.Tasks;
using CommanderGQL.Data;
using CommanderGQL.GraphQL.Commands;
using CommanderGQL.GraphQL.Platforms;
using CommanderGQL.Models;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Subscriptions;

namespace CommanderGQL.GraphQL
{
    public class Mutation
    {
        [UseDbContext(typeof(AppDbContext))]
        public async Task<AddPlatformResult> AddPlatformAsync(
            AddPlatformRequest request,
            [ScopedService] AppDbContext context,
            [Service] ITopicEventSender eventSender,
            CancellationToken cancellationToken)
            {
                var platform = new Platform
                {
                    Name = request.Name
                };

                context.Platforms.Add(platform);
                await context.SaveChangesAsync();

                await eventSender.SendAsync(nameof(Subscription.OnPlatformAdded), platform, cancellationToken);

                return new AddPlatformResult(platform);
            }

        [UseDbContext(typeof(AppDbContext))]
        public async Task<AddCommandResult> AddCommandAsync(
            AddCommandRequest request,
            [ScopedService] AppDbContext context)
            {
                var command = new Command
                {
                    CommandLine = request.CommandLine,
                    HowTo = request.HowTo,
                    PlatformId = request.PlatformId
                };

                context.Commands.Add(command);
                await context.SaveChangesAsync();

                return new AddCommandResult(command);
            }
  
    }
}
