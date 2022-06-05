using Notes.DB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Notes.Core
{
    public class NotesServices : INotesService
    {
        private readonly AppDbContext _dbContext;
        public NotesServices(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Note GetNote(int id)
        {
            return _dbContext.Notes.First(n => n.Id == id);
        }

        public List<Note> GetNotes()
        {
            return _dbContext.Notes.ToList();
        }
        public Note CreateNotes(Note note)
        {
            _dbContext.Add(note);
            _dbContext.SaveChanges();
            return note;
        }
        public void EditNote(Note note)
        {
            var existingNote = _dbContext.Notes.First(n => n.Id == note.Id);
            existingNote.Value = note.Value;
            _dbContext.SaveChanges();

        }


        public void DeleteNote(int id)
        {
            var note = _dbContext.Notes.First(n => n.Id == id);
            _dbContext.Notes.Remove(note);
            _dbContext.SaveChanges();

        }        
        
    }

}
