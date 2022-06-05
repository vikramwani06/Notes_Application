using Notes.DB;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Core
{
    public interface INotesService
    {
        Note CreateNotes(Note note);
        Note GetNote(int id);
        List<Note> GetNotes();
        void EditNote(Note note);
        void DeleteNote(int id);
    }

}
