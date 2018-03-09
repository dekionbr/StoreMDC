using Microsoft.AspNetCore.Mvc;
using StoreMDC.Application.Interfaces.Services;
using StoreMDC.Application.ViewModels;
using System;

namespace StoreMDC.WebApi.Controllers
{
    public class StateController : Controller
    {
        private readonly IStateAppService _appService;

        public StateController(IStateAppService appService)
        {
            _appService = appService;
        }

        [HttpGet]
        [Route("States")]
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
        [Route("States/{id}")]
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
        [Route("States")]
        public IActionResult Post([FromBody]StateViewModel ViewModel)
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
        [Route("States")]
        public IActionResult Put([FromBody]StateViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ViewModel);
            }

            _appService.Update(ViewModel);

            return Ok(ViewModel);
        }

        [HttpDelete]
        [Route("States/{id}")]
        public IActionResult Delete(int id)
        {
            _appService.Remove(id);

            return Ok();
        }
    }
}