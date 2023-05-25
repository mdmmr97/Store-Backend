﻿using Microsoft.AspNetCore.Mvc;
using Store_Backend.Application.Dtos;
using Store_Backend.Application.Services;
using Store_Backend.Domain.Persistence;

namespace Store_Backend.Infraestructure.Rest
{
    public class GenericCrudController<D>: ControllerBase where D : class
    {
        protected IGenericService<D> _service;
        public GenericCrudController(IGenericService<D> service) {
            _service = service;
        }

        [HttpGet]
        [Produces("application/json")]
        public virtual ActionResult<IEnumerable<D>> Get()
        {
            var dto = _service.GetAll();
            return Ok(dto);
        }

        [HttpGet("{id}")]
        [Produces("application/json")]
        public virtual ActionResult<D> Get(long id)
        {
            try
            {
                D dto = _service.Get(id);
                return Ok(dto);
            }
            catch (ElementNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpPost]
        [Produces("application/json")]
        [Consumes("application/json")]
        public virtual ActionResult<D> Insert(D dto)
        {
            if (dto == null) return BadRequest();
            dto = _service.Insert(dto);
            return CreatedAtAction(nameof(Get), new { id = ((IDto)dto).Id }, dto);
        }

        [HttpPut]
        [Produces("application/json")]
        [Consumes("application/json")]
        public virtual ActionResult<D> Update(D dto)
        {
            if (dto == null) return BadRequest();
            dto = _service.Update(dto);
            return Ok(dto);
        }

        [HttpDelete("{id}")]
        public virtual ActionResult<D> Delete(long id)
        {
            try
            {
                _service.Delete(id);
                return NoContent();
            }
            catch (ElementNotFoundException)
            {
                return NotFound();
            }
        }
    }
}
