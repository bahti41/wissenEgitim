import React from 'react'
import { Container, Navbar, NavbarBrand, Nav } from 'react-bootstrap'
import { NavLink } from 'react-router-dom'
const Header = () => {
    return (
        <>
            <Navbar bg='primary' variant='dark'>
                <Container >
                    <NavbarBrand>
                        <navLink className="Nav-link" to={"/"}>
                            Fs-2310-12 Githup Finder App</navLink>
                    </NavbarBrand>
                    <Nav className="ms-auto">
                        <NavLink className="nav-link" to="/">Home</NavLink>
                        <NavLink className="nav-link" to="/search">Search</NavLink>
                    </Nav>
                </Container >
            </Navbar>
        </>
    )
}

export default Header
