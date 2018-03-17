using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator.Repository.Entity
{
    [Table("dbo.ClassDescriptions")]
   public class ClassDetailsEntity
    {
        [Key]

        public int Id { get; set; }

        public int ClassId { get; set; }

        public string Description { get; set; }
    }
}
