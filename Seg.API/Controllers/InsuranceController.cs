using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Seg.API.Data;
using Seg.API.Dtos;
using Seg.API.Models;

namespace Seg.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuranceController : ControllerBase
    {
        private readonly IInsuranceRepository _repo;
        private readonly IMapper _mapper;

        public InsuranceController(IInsuranceRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetInsurances()
        {
            var insurances =  await _repo.GetAllInsurances();
            return Ok(insurances);
            
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetInsurance(int id)
        {
            // var all = await _repo.GetAllInsurances();
            // return Ok(all);
            var insurance = await _repo.GetInsurance(id);
            if(insurance != null)
            {
                return Ok(insurance);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateInsurance([FromBody]InsuranceForCreationDto InsuranceForCreationDTO)
        {
            var insurance = _mapper.Map<Insurance>(InsuranceForCreationDTO); 
            _repo.Add(insurance);
            if(await _repo.SaveAll()) 
                return Ok(insurance);
            return BadRequest();
          
        }

    
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInsurance(int id)
        {
            var vehicle = await _repo.GetInsurance(id);
            _repo.Delete(vehicle);
            if(await _repo.SaveAll())
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditInsurance(int id, [FromBody]InsuranceForCreationDto insurance)
        {
            var _insurance = await _repo.GetInsurance(id);
            _mapper.Map(insurance, _insurance);
            if(await _repo.SaveAll()){
                return NoContent();
            }
            return BadRequest();
        }
    }
}