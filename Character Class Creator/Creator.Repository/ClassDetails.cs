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
    class ClassDetailsRepository : IClassDetailsRepository
    {
        private readonly IRepository<ClassDetailsEntity> _classdetailsRepository;

        public ClassDetailsRepository(IRepository<ClassDetailsEntity> repository)
        {
            _classdetailsRepository = repository;
        }

        public List<ClassDetailsEntity> GetAll()
        {
            return _classdetailsRepository.GetAll().ToList();
        }
    }
}
