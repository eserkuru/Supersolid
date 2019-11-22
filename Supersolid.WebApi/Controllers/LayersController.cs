using System;
using Microsoft.AspNetCore.Mvc;
using Supersolid.Business.Abstract;
using Supersolid.Entities.Concrete;

namespace Supersolid.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LayersController : ControllerBase
    {
        private readonly ILayerService _layerService;

        public LayersController(ILayerService layerService)
        {
            _layerService = layerService;
        }

        [HttpGet("getlist")]
        public IActionResult GetList()
        {
            var result = _layerService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(Guid id)
        {
            var result = _layerService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Layer layer)
        {
            var result = _layerService.Add(layer);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Layer layer)
        {
            var result = _layerService.Update(layer);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Layer layer)
        {
            var result = _layerService.Delete(layer);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("remove")]
        public IActionResult Remove(Layer layer)
        {
            var result = _layerService.Remove(layer);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}