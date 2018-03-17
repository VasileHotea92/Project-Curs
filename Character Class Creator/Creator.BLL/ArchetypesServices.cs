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
    public class ArchetypesService : IArchetypesServices
    {
        #region Attributes

        private readonly IArchetypesRepository _archetypesRepository;

        private IMapper Mapper { get; set; }

        #endregion Attributes

        #region Constructor

        public ArchetypesService(IArchetypesRepository archetypesRepository)
        {
            _archetypesRepository = archetypesRepository;

            Mapper = SetMapperConfigs();
        }

        #endregion Constructor

        #region Public Methods

        public List<ArchetypesDto> GetArchetypesList()
        {
            var archetypesEntityList = _archetypesRepository.GetAll();
            var archetypesList = Mapper.Map<List<ArchetypesDto>>(archetypesEntityList);

            return archetypesList;
        }

        #endregion Public Methods

        #region Private Methods

        private IMapper SetMapperConfigs()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ArchetypesDto, ArchetypesEntity>();
                cfg.CreateMap<ArchetypesEntity, ArchetypesDto>();
            });

            IMapper mapper = config.CreateMapper();

            return mapper;
        }

        #endregion Private Methods
    }
}
