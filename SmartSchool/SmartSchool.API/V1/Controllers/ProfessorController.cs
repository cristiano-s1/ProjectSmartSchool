﻿using AutoMapper;
using SmartSchool.Models;
using SmartSchool.V1.Dtos;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Repository;
using System.Collections.Generic;

namespace SmartSchool.API.V1.Controllers
{
    public class ProfessorController : Controller
    {
        // Construtor para receber o contexto
        public readonly IBaseRepository _repository;
        public readonly IMapper _mapper;

        public ProfessorController(IBaseRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;     
        }


        [HttpGet("GetRegister")]
        public IActionResult GetRegister()
        {
            return Ok(new ProfessorRegistrarDto());
        }

        //GET: api/V1/Professor
        [HttpGet]
        public IActionResult Get()
        {
            var professor = _repository.GetAllProfessores(true);

            return Ok(_mapper.Map<IEnumerable<ProfessorDto>>(professor));
        }

        // GET: api/V1/Professor/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var professor = _repository.GetProfessorById(id, false);
            if (professor == null) return BadRequest("O Professor não foi encontrado");

            var professorDto = _mapper.Map<ProfessorDto>(professor);

            return Ok(professorDto);
        }

        // POST: api/V1/Professor
        [HttpPost]
        public IActionResult Post(ProfessorRegistrarDto model)
        {
            var professor = _mapper.Map<Professor>(model);

            _repository.Add(professor);

            if (_repository.SaveChanges())
            {
                return Created($"/api/professor/{model.Id}", _mapper.Map<ProfessorDto>(professor));
            }

            return BadRequest("O Professor não encontrado");
        }

        // PUT: api/V1/Professor/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, ProfessorRegistrarDto model)
        {

            var professor = _repository.GetProfessorById(id, false);
            if (professor == null) return BadRequest("Professor não encontrado");

            _mapper.Map(model, professor);

            _repository.Update(professor);

            if (_repository.SaveChanges())
            {
                return Created($"/api/professor/{model.Id}", _mapper.Map<ProfessorDto>(professor));
            }

            return BadRequest("Professor não atualizado");
        }

        // PATCH: api/V1/Professor/5
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, ProfessorRegistrarDto model)
        {
            var professor = _repository.GetProfessorById(id, false);
            if (professor == null) return BadRequest("Professor não encontrado");

            _mapper.Map(model, professor);

            _repository.Update(professor);

            if (_repository.SaveChanges())
            {
                return Created($"/api/professor/{model.Id}", _mapper.Map<ProfessorDto>(professor));
            }

            return BadRequest("Professor não atualizado");
        }

        // DELETE: api/V1/Professor/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var professor = _repository.GetProfessorById(id, false);
            if (professor == null) return BadRequest("Professor não encontrado");

            _repository.Delete(professor);

            if (_repository.SaveChanges())
            {
                return Ok("Professor deletado");
            }

            return BadRequest("Professor não foi deletado");
        }
    }
}
