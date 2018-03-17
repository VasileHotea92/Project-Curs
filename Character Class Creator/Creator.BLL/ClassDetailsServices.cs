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
    public class ClassDetailsService : IClassDetailsServices
    {
        #region Attributes

        private readonly IClassDetailsRepository _classdetailsRepository;

        private IMapper Mapper { get; set; }

        #endregion Attributes

        #region Constructor

        public ClassDetailsService(IClassDetailsRepository classdetailsRepository)
        {
            _classdetailsRepository = classdetailsRepository;

            Mapper = SetMapperConfigs();
        }

        #endregion Constructor

        #region Public Methods

        public List<ClassDetailsDto> GetClassDetailsList()
        {
            var classdetailsEntityList = _classdetailsRepository.GetAll();
            var classdetailsList = Mapper.Map<List<ClassDetailsDto>>(classdetailsEntityList);

            return classdetailsList;
        }

        #endregion Public Methods

        #region Private Methods

        private IMapper SetMapperConfigs()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ClassDetailsDto, ClassDetailsEntity>();
                cfg.CreateMap<ClassDetailsEntity, ClassDetailsDto>();
            });

            IMapper mapper = config.CreateMapper();

            return mapper;
        }

        #endregion Private Methods
    }
}
