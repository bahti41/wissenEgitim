import React from 'react'

function TickTock( props ) {

    return (
        <>
            <h1>hello react!</h1>
            <h3>first name: {props.firstName} </h3>
            <h3>last name: {props.lastName}</h3>
            <h3>age: {props.age}</h3>
        </>
    )
}

export default TickTock;
