using Microsoft.AspNetCore.Mvc;
using StoreMDC.Application.Interfaces.Services;
using StoreMDC.Application.ViewModels;
using System;

namespace StoreMDC.WebApi.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityAppService _appService;

        public CityController(ICityAppService appService)
        {
            _appService = appService;
        }

        [HttpGet]
        [Route("Cities")]
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
        [Route("Cities/{id}")]
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
        [Route("Cities")]
        public IActionResult Post([FromBody]CityViewModel ViewModel)
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
        [Route("Cities")]
        public IActionResult Put([FromBody]CityViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ViewModel);
            }

            _appService.Update(ViewModel);

            return Ok(ViewModel);
        }

        [HttpDelete]
        [Route("Cities/{id}")]
        public IActionResult Delete(int id)
        {
            _appService.Remove(id);

            return Ok();
        }
    }
}