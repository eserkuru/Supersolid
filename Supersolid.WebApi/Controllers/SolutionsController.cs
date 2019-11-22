using System;
using Microsoft.AspNetCore.Mvc;
using Supersolid.Business.Abstract;
using Supersolid.Entities.Concrete;

namespace Supersolid.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolutionsController : ControllerBase
    {
        private readonly ISolutionService _solutionService;

        public SolutionsController(ISolutionService solutionService)
        {
            _solutionService = solutionService;
        }

        [HttpGet("getlist")]
        public IActionResult GetList()
        {
            var result = _solutionService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(Guid id)
        {
            var result = _solutionService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Solution solution)
        {
            var result = _solutionService.Add(solution);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Solution solution)
        {
            var result = _solutionService.Update(solution);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Solution solution)
        {
            var result = _solutionService.Delete(solution);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("remove")]
        public IActionResult Remove(Solution solution)
        {
            var result = _solutionService.Remove(solution);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}