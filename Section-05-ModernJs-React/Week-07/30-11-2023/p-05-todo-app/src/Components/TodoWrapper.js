import React, { useState } from 'react'
import TodoFrom from './TodoFrom';
import { v4 as uuidv4 } from 'uuid';

const TodoWrapper = () => {
    let [todos, setTodos] = useState([]);
    const addTodo = todo => {
        setTodos([...todo, {
            id: uuidv4(),
            desc: todo,
            completed: false
        }]);
    };
    return (
        <>
            <div className='TodoWrapper'>
                <h1>FS-2310-13 Todo App</h1>
                <TodoFrom addTodo={addTodo} />
            </div>
        </>
    )
}

export default TodoWrapper;
