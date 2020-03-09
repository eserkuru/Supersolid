using System;
using Microsoft.AspNetCore.Mvc;
using Supersolid.Business.Abstract;
using Supersolid.Entities.Concrete;

namespace Supersolid.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolutionGroupsController : ControllerBase
    {
        private readonly ISolutionGroupService _solutionGroupService;
        public SolutionGroupsController(ISolutionGroupService solutionGroupService)
        {
            _solutionGroupService = solutionGroupService;
        }

        [HttpGet("getlist")]
        public IActionResult GetList()
        {
            var result = _solutionGroupService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(Guid id)
        {
            var result = _solutionGroupService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(SolutionGroup solutionGroup)
        {
            var result = _solutionGroupService.Add(solutionGroup);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(SolutionGroup solutionGroup)
        {
            var result = _solutionGroupService.Update(solutionGroup);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(SolutionGroup solutionGroup)
        {
            var result = _solutionGroupService.Delete(solutionGroup);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("remove")]
        public IActionResult Remove(SolutionGroup solutionGroup)
        {
            var result = _solutionGroupService.Remove(solutionGroup);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}