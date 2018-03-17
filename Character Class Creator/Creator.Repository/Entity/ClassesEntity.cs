using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator.Repository.Entity
{
    [Table("dbo.Classes")]
    public class ClassesEntity
    {
        [Key]
        
        public int Id { get; set; }

        public string Name { get; set; }

    }
}
