using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator.Repository.Entity
{
    [Table("dbo.Abilities")]
    public class AbilitiesEntity
    {
        [Key]

        public int Id { get; set; }

        public int AbilityID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

    }
}
