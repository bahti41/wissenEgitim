import './App.css';
import TodoWrapper from './Compoments/TodoWrapper';
import { v4 as idGenerate } from 'uuid';

const INITIAL_STATE = [
  { id: idGenerate(), desc: "ayşenur arama", isCompleted: false, isEditing: false },
  { id: idGenerate(), desc: "bahtiyar arama", isCompleted: false, isEditing: false },
  { id: idGenerate(), desc: "yasın arama", isCompleted: true, isEditing: false },
  { id: idGenerate(), desc: "melike arama", isCompleted: false, isEditing: false },
  { id: idGenerate(), desc: "numan arama", isCompleted: false, isEditing: false }
];
function App() {

  return (
    <>
      <TodoWrapper tasks={INITIAL_STATE} />
    </>
  );
}

export default App;
