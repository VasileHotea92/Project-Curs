using Creator.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator.Repository.Ports
{
   public interface IArchetypeDetailsRepository
    {

        List<ArchetypeDetailsEntity> GetAll();
    }
}
