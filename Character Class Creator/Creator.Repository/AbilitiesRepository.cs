using Creator.Repository.Entity;
using Creator.Repository.Ports;
using Creator.Repository.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator.Repository
{
    class AbilitiesRepository : IAbilitiesRepository
    {
        private readonly IRepository<AbilitiesEntity> _abilityRepository;

        public AbilitiesRepository(IRepository<AbilitiesEntity> repository)
        {
            _abilityRepository = repository;
        }

        public List<AbilitiesEntity> GetAll()
        {
            return _abilityRepository.GetAll().ToList();
        }
    }
}
