using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Notes.Core;
using Notes.DB;

namespace Notes.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotesController : ControllerBase
    {

        private readonly INotesService _notesService;

        public NotesController( INotesService notesService)
        {
            _notesService = notesService;
        }

        [HttpGet("{id}", Name = "GetNote")]
        public IActionResult GetNote(int id)
        {
            return Ok(_notesService.GetNote(id));
        }

        [HttpGet]
        public IActionResult GetNotes()
        {
            return Ok(_notesService.GetNotes());
        }

        [HttpPost]
        public IActionResult CreateNote(Note note)
        {
            var newNote = _notesService.CreateNotes(note);
            return CreatedAtRoute("GetNote", new { newNote.Id }, newNote);
        }

        [HttpPut]
        public IActionResult EditNote([FromBody] Note note)
        {
            _notesService.EditNote(note);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteNote(int id)
        {
            _notesService.DeleteNote(id);
            return Ok();
        }



    }
}
