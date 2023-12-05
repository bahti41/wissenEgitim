import React, { useContext, useState } from 'react';
import { TodoContext } from '../Contexts/TodoContext';

const TodoAddFrom = () => {
    const context = useContext(TodoContext);
    const [desc, setDesc] = useState("");


    const handleSubmit = (e) => {
        e.preventDefault();
        if (desc) {
            context.addTask(desc);
            setDesc("");
            e.target.firstChild.firstChild.focus();
        } else {
            alert("lütfen boş bırakmayanız!");
        }
    }
    return (
        <div className='container w-50 p-5'>
            <h1 className='display-5 text-center mb-5 text-danger'>Todo App</h1>
            <form onSubmit={handleSubmit}>
                <div className="input-group mb-3">
                    <input onCanPlay={(e) => { setDesc(e.target.value) }} value={desc} type="text" className="form-control" placeholder="What Is The Task Today?" aria-label="Recipient's username" aria-describedby="button-addon2" />
                    <button className="btn btn-outline-success" type="submit" id="btn-add-task">Add Task</button>
                </div>
            </form>
        </div>
    )
}

export default TodoAddFrom
