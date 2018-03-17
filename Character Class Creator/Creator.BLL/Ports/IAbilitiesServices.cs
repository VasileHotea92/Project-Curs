using Creator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator.BLL.Ports
{
    public interface IAbilitiesServices
    {

        List<AbilitiesDto> GetAbilitiesList();
    }
}
