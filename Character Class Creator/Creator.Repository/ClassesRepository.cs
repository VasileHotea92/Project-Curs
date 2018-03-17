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
    class ClassesRepository : IClassesRepository
    {
        private readonly IRepository<ClassesEntity> _classesRepository;

        public ClassesRepository(IRepository<ClassesEntity> repository)
        {
            _classesRepository = repository;
        }

        public List<ClassesEntity> GetAll()
        {
            return _classesRepository.GetAll().ToList();
        }
    }
}
