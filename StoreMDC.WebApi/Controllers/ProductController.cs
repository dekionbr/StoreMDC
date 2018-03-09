using Microsoft.AspNetCore.Mvc;
using StoreMDC.Application.Interfaces.Services;
using StoreMDC.Application.ViewModels;
using System;

namespace StoreMDC.WebApi.Controllers
{
    public class ProductController : ControllerBase
    {
        private readonly IProductAppService _appService;

        public ProductController(IProductAppService appService)
        {
            _appService = appService;
        }

        [HttpGet]
        [Route("Products")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_appService.GetAll());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("Products/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var ViewModel = _appService.GetById(id);

                return Ok(ViewModel);

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpPost]
        [Route("Products")]
        public IActionResult Post([FromBody]ProductViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ViewModel);
            }

            try
            {
                _appService.Insert(ViewModel);

                return Ok(ViewModel);
            }
            catch (Exception)
            {
                return BadRequest(ViewModel);
            }
        }

        [HttpPut]
        [Route("Products")]
        public IActionResult Put([FromBody]ProductViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ViewModel);
            }

            _appService.Update(ViewModel);

            return Ok(ViewModel);
        }

        [HttpDelete]
        [Route("Products/{id}")]
        public IActionResult Delete(int id)
        {
            _appService.Remove(id);

            return Ok();
        }

    }
}