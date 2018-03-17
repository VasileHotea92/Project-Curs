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
    class ArchetypeDetailsRepository : IArchetypeDetailsRepository
    {
        private readonly IRepository<ArchetypeDetailsEntity> _archetypedetailsRepository;

        public ArchetypeDetailsRepository(IRepository<ArchetypeDetailsEntity> repository)
        {
            _archetypedetailsRepository = repository;
        }

        public List<ArchetypeDetailsEntity> GetAll()
        {
            return _archetypedetailsRepository.GetAll().ToList();
        }
    }
}
