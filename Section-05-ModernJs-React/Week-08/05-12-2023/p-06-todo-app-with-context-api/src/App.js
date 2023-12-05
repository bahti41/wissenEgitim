import './App.css';
import TodoWrapper from './Components/TodoWrapper';
import { v4 as idGenerate } from 'uuid';

const INITIAL_STATE = [
  { id: idGenerate(), desc: "sakjcjsbjkdsbkjbsjkbscds", isCompleted: false, isEditing: false },
  { id: idGenerate(), desc: "asklsakncjsjcksjakcjk", isCompleted: false, isEditing: false },
  { id: idGenerate(), desc: "sdjkcbjzvbjkşbvbjdv", isCompleted: true, isEditing: false },
  { id: idGenerate(), desc: "kdsnvknkjvnkdjnvkdönv", isCompleted: false, isEditing: false },
  { id: idGenerate(), desc: "skjdvjksbdjvbbdjkvsbksdj", isCompleted: true, isEditing: false }
];

function App() {
  return (
    <>
      <TodoWrapper tasks={INITIAL_STATE} />
    </>
  );
}

export default App;