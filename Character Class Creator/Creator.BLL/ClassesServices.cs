using AutoMapper;
using Creator.BLL.Ports;
using Creator.Core.Models;
using Creator.Repository.Entity;
using Creator.Repository.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator.BLL
{
    public class ClassesServices : IClassesServices
    {
        #region Attributes

        private readonly IClassesRepository _classesRepository;

        private IMapper Mapper { get; set; }

        #endregion Attributes

        #region Constructor

        public ClassesServices(IClassesRepository classesRepository)
        {
            _classesRepository = classesRepository;

            Mapper = SetMapperConfigs();
        }

        #endregion Constructor

        #region Public Methods

        public List<ClassesDto> GetClassesList()
        {
            var classesEntityList = _classesRepository.GetAll();
            var classesList = Mapper.Map<List<ClassesDto>>(classesEntityList);

            return classesList;
        }

        #endregion Public Methods

        #region Private Methods

        private IMapper SetMapperConfigs()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ClassesDto, ClassesEntity>();
                cfg.CreateMap<ClassesEntity, ClassesDto>();
            });

            IMapper mapper = config.CreateMapper();

            return mapper;
        }

        #endregion Private Methods
    }
}
