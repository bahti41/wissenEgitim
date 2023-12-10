import React from 'react'
import { Container, ListGroupItem, NavLink } from 'react-bootstrap'

const UserRepo = ({ userRepoName, userRepoUrl }) => {
    console.log(userRepoUrl)
    return (
        <>
            <Container>
                <ListGroupItem xs={4} className='w-auto' action={true} href={userRepoUrl} target="_blank">
                    {userRepoName}
                </ListGroupItem>
            </Container>
        </>
    )
}

export default UserRepo