using Microsoft.AspNetCore.Mvc;
using StoreMDC.Application.Interfaces.Services;
using StoreMDC.Application.ViewModels;
using System;

namespace StoreMDC.WebApi.Controllers
{
    public class CountryController : Controller
    {
        private readonly ICountryAppService _appService;

        public CountryController(ICountryAppService appService)
        {
            _appService = appService;
        }

        [HttpGet]
        [Route("Countries")]
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
        [Route("Countries/{id}")]
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
        [Route("Countries")]
        public IActionResult Post([FromBody]CountryViewModel ViewModel)
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
        [Route("Countries")]
        public IActionResult Put([FromBody]CountryViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ViewModel);
            }

            _appService.Update(ViewModel);

            return Ok(ViewModel);
        }

        [HttpDelete]
        [Route("Countrys/{id}")]
        public IActionResult Delete(int id)
        {
            _appService.Remove(id);

            return Ok();
        }
    }
}