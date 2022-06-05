import React from 'react'
import './App.css'
import { NewNoteModal } from './components/NoteModal'
import { NotesTable } from './components/NotesTable'

const App = () => {
  return (
    <div className="App">
      <div style={{ maxWidth: '70%', margin: 'auto',paddingTop: '20px' }}>
        <h3>Notes Application</h3>
      </div>

      <div style={{ maxWidth: '70%', margin: 'auto' }}>
        <div style={{ textAlign: 'left', paddingBottom: '20px' }}>
          <NewNoteModal></NewNoteModal>
        </div>
        <NotesTable></NotesTable>
      </div>
    </div>
  )
}

export default App
