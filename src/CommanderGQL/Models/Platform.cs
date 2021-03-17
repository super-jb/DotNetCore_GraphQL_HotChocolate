using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommanderGQL.Models
{
    //[GraphQLDescription("Represents any software or service that has a command line interface")] -> moved to PlatformType.cs
    public class Platform
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        //[GraphQLDescription("Represents a valid purchased License for the platform")]
        public string LicenseKey { get; set; }

        public ICollection<Command> Commands { get; set; } = new List<Command>();
    }
}