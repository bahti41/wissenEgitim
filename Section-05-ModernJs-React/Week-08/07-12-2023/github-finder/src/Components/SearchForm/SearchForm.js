import React from 'react'
import { Button, Container, Form, InputGroup } from 'react-bootstrap'

const SearchForm = () => {
    const handeleSubmit = (e) => {
        e.preventDefault();

    }
    return (
        <>
            <Container className='py-3'>
                <Form onSubmit={handeleSubmit}>
                    <InputGroup>
                        <Form.Control placeholder="Enter search user naem">
                        </Form.Control>
                        <Button variant='primary' type='bubmit'>Search</Button>
                    </InputGroup>
                </Form>
            </Container>

        </>
    )
}

export default SearchForm
