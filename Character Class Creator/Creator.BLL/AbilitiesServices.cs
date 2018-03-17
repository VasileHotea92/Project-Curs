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
    public class AbilitiesServices : IAbilitiesServices
    {
        #region Attributes

        private readonly IAbilitiesRepository _abilitiesRepository;

        private IMapper Mapper { get; set; }

        #endregion Attributes

        #region Constructor

        public AbilitiesServices(IAbilitiesRepository abilitiesRepository)
        {
            _abilitiesRepository = abilitiesRepository;

            Mapper = SetMapperConfigs();
        }

        #endregion Constructor

        #region Public Methods

        public List<AbilitiesDto> GetAbilitiesList()
        {
            var abilitiesEntityList = _abilitiesRepository.GetAll();
            var abilitiesList = Mapper.Map<List<AbilitiesDto>>(abilitiesEntityList);

            return abilitiesList;
        }

        #endregion Public Methods

        #region Private Methods

        private IMapper SetMapperConfigs()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AbilitiesDto, AbilitiesEntity>();
                cfg.CreateMap<AbilitiesEntity, AbilitiesDto>();
            });

            IMapper mapper = config.CreateMapper();

            return mapper;
        }

        #endregion Private Methods
    }
}
