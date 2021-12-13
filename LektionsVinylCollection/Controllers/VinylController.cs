using LektionsVinylCollection.DTOs;
using LektionsVinylCollection.Entities;
using LektionsVinylCollection.Repo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LektionsVinylCollection.Controllers
{
    [ApiController]
    [Route("api/vinyl")]
    public class VinylController : ControllerBase
    {
        private readonly IVinylRepo _repo;

        public VinylController(IVinylRepo repo)
        {
            _repo = repo;
        }


        // GET /api/vinyl
        [HttpGet]
        [Route("")]
        public IActionResult GetVinyls()
        {
            var vinyls = _repo
                .GetAll()
                .ToList()
                .MapToVinylDTOs();
            return Ok(vinyls);
        }

        // GET /api/vinyl/:id
        [HttpGet("{id}")]
        public IActionResult GetVinylByID(int id)
        {
            Vinyl vinyl = _repo.GetByID(id);
            if (vinyl is null) // vinyl == null
            {
                return NotFound("Could not find vinyl with ID " + id);
            }

            VinylDTO vinylDTO = vinyl.MapToVinylDTO();
            return Ok(vinylDTO);
        }

        [HttpPost("")]
        public IActionResult CreateVinyl([FromBody] CreateVinylDTO createVinylDTO)
        {
            Vinyl createdVinyl = _repo.CreateVinyl(createVinylDTO);
            //VinylDTO vinylDTO = createdVinyl.MapToVinylDTO();

            VinylDTO vinylSavedDTO = _repo
                .GetByID(createdVinyl.Id)
                .MapToVinylDTO();

            return CreatedAtAction(
                nameof(GetVinylByID),
                new { id = vinylSavedDTO.Id },
                vinylSavedDTO);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVinyl([FromBody] Vinyl vinyl, int id)
        {
            Vinyl updatedVinyl = _repo.UpdateVinyl(vinyl, id);
            //VinylDTO vinylDTO = updatedVinyl.MapToVinylDTO();
            VinylDTO vinylDTO = _repo.GetByID(id).MapToVinylDTO();
            return Ok(vinylDTO);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVinyl(int id)
        {
            _repo.DeleteVinyl(id);
            return NoContent();
        }
    }
}
