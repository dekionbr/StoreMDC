using Microsoft.AspNetCore.Mvc;
using StoreMDC.Application.Interfaces.Services;
using StoreMDC.Application.ViewModels;
using System;

namespace StoreMDC.WebApi.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStoreAppService _appService;

        public StoreController(IStoreAppService appService)
        {
            _appService = appService;
        }

        [HttpGet]
        [Route("Stores")]
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
        [Route("Stores/{id}")]
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
        [Route("Stores")]
        public IActionResult Post([FromBody]StoreViewModel ViewModel)
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
        [Route("Stores")]
        public IActionResult Put([FromBody]StoreViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ViewModel);
            }

            _appService.Update(ViewModel);

            return Ok(ViewModel);
        }

        [HttpDelete]
        [Route("Stores/{id}")]
        public IActionResult Delete(int id)
        {
            _appService.Remove(id);

            return Ok();
        }
    }
}