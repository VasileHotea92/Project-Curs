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
    class ArchetypesRepository : IArchetypesRepository
    {
        private readonly IRepository<ArchetypesEntity> _archetypesRepository;

        public ArchetypesRepository(IRepository<ArchetypesEntity> repository)
        {
            _archetypesRepository = repository;
        }

        public List<ArchetypesEntity> GetAll()
        {
            return _archetypesRepository.GetAll().ToList();
        }
    }
}
