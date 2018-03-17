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
    public class ArchetypeDetailsService : IArchetypeDetailsServices
    {
        #region Attributes

        private readonly IArchetypeDetailsRepository _archetypedetailsRepository;

        private IMapper Mapper { get; set; }

        #endregion Attributes

        #region Constructor

        public ArchetypeDetailsService(IArchetypeDetailsRepository archetypedetailsRepository)
        {
            _archetypedetailsRepository = archetypedetailsRepository;

            Mapper = SetMapperConfigs();
        }

        #endregion Constructor

        #region Public Methods

        public List<ArchetypeDetailsDto> GetArchetypeDetailsList()
        {
            var archetypedetailsEntityList = _archetypedetailsRepository.GetAll();
            var archetypedetailsList = Mapper.Map<List<ArchetypeDetailsDto>>(archetypedetailsEntityList);

            return archetypedetailsList;
        }

        #endregion Public Methods

        #region Private Methods

        private IMapper SetMapperConfigs()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ArchetypeDetailsDto, ArchetypeDetailsEntity>();
                cfg.CreateMap<ArchetypeDetailsEntity, ArchetypeDetailsDto>();
            });

            IMapper mapper = config.CreateMapper();

            return mapper;
        }

        #endregion Private Methods
    }
}
