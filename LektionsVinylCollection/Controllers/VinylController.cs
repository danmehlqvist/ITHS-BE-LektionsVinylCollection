using LektionsVinylCollection.DTOs;
using LektionsVinylCollection.Entities;
using LektionsVinylCollection.Repo;
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
            IOrderedEnumerable<VinylDTO> vinyls = _repo
                .GetAll()
                .Select(v => new VinylDTO
                {
                    Id = v.Id,
                    Artist = v.Artist,
                    Title = v.Title
                })
                .OrderBy(x => x.Title)
                ;
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

            VinylDTO vinylDTO = MapVinylToVinylDTO(vinyl);
            return Ok(vinylDTO);
        }

        [HttpPost("")]
        public IActionResult CreateVinyl([FromBody]CreateVinylDTO createVinylDTO)
        {
            Vinyl createdVinyl = _repo.CreateVinyl(createVinylDTO);
            VinylDTO vinylDTO = MapVinylToVinylDTO(createdVinyl);

            return CreatedAtAction(
                nameof(GetVinylByID),
                new { id = vinylDTO.Id },
                vinylDTO);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVinyl([FromBody] Vinyl vinyl)
        {
            Vinyl updatedVinyl = _repo.UpdateVinyl(vinyl);
            VinylDTO vinylDTO = MapVinylToVinylDTO(updatedVinyl);
            return Ok(vinylDTO);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVinyl(int id)
        {
            _repo.DeleteVinyl(id);
            return NoContent();
        }

        private VinylDTO MapVinylToVinylDTO(Vinyl vinyl)
        {
            return new VinylDTO
            {
                Id = vinyl.Id,
                Artist = vinyl.Artist,
                Title = vinyl.Title,
            };
        }
    }
}
