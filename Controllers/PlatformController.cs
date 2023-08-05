using Microsoft.AspNetCore.Mvc;
using PlatformService.Data;
using AutoMapper;
using PlatformService.Dtos;
using System.Collections.Generic;


namespace PlatformService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformController : ControllerBase
    {
        private readonly IPlatformRepo _repository;
        private readonly IMapper _mapper;
        public PlatformController(IPlatformRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet()]
        public ActionResult<IEnumerable<PlatformReadDto>> GetAllPlatforms()
        {
            var platformItems = _repository.GetAllPlatforms();
            return Ok(_mapper.Map<IEnumerable<PlatformReadDto>>(platformItems));
        }
    }
}