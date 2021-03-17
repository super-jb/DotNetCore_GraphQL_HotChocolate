using System.Linq;
using CommanderGQL.Data;
using CommanderGQL.Models;
using HotChocolate;
using HotChocolate.Types;

namespace CommanderGQL.GraphQL.Commands
{
    public class CommandType : ObjectType<Command>
    {
        protected override void Configure(IObjectTypeDescriptor<Command> descriptor)
        {
            descriptor
                .Description("Represents any valid executable command");

            descriptor
                .Field(x => x.Platform)
                .ResolveWith<Resolvers>(c => c.GetPlatforms(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("This is the associated platform for this command");
        }

        private class Resolvers
        {
            public Platform GetPlatforms(Command command, [ScopedService] AppDbContext context)
            {
                return context.Platforms.FirstOrDefault(p => p.Id == command.PlatformId);
            }
        }
    }
}