import React, { useContext, useState } from 'react';
import { TodoContext } from '../Contexts/TodoContext';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faCriticalRole } from '@fortawesome/free-brands-svg-icons';
import { faCircle } from '@fortawesome/free-regular-svg-icons';
import { faCirclePlus } from '@fortawesome/free-solid-svg-icons';

const TodoAddForm = () => {
    const context = useContext(TodoContext);
    const [desc, setDesc] = useState("");
    const handleSubmit = (e) => {
        e.preventDefault();
        if (desc) {
            context.addTask(desc);
            setDesc("");
            e.target.firstChild.firstChild.focus();
        } else {
            alert("Lütfen bos bırakmayınız!");
        }
    }
    return (
        <div className='container-fluid g-0 m-0'>
            <h1 className="display-5 text-center mb-5 text-danger">Todo App</h1>
            <form onSubmit={handleSubmit}>
                <div className="input-group mb-1">
                    <input onChange={(e) => { setDesc(e.target.value) }} value={desc} type="text" className="form-control" placeholder="What is the task today?" aria-describedby="button-addon2" />
                    <button className="btn btn-outline-success" type="submit" id="btn-add-task">
                        {/* {<FontAwesomeIcon icon={faCirclePlus} size='x1' />} */}
                        {<FontAwesomeIcon icon={faCirclePlus} className='fs-1' />}
                    </button>

                </div>
            </form>
        </div>
    )
}

export default TodoAddForm;