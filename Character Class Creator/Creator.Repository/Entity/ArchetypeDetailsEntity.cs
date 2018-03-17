using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator.Repository.Entity
{
    [Table("dbo.ArchetypeDetails")]
    public class ArchetypeDetailsEntity

    {
        [Key]

        public int Id { get; set; }

        public int ArchetypeID { get; set; }

        public string Description { get; set; }

        public string Roles { get; set; }

    }
}
