import { Container, Row, Col, Nav, Image, Button, Card } from "react-bootstrap";

import React from "react"
import Product from "./Product";

function Products() {
    return (
        <Container>
            <Row>
            <Product productName={"sjhjdb"} productImgeUrl={"https://picsum.photos/id/237/100/100"}/>
            <Product productName={"sjhjdb"} productImgeUrl={"https://picsum.photos/id/237/100/100"}/>
            <Product productName={"sjhjdb"} productImgeUrl={"https://picsum.photos/id/237/100/100"}/>
            <Product productName={"sjhjdb"} productImgeUrl={"https://picsum.photos/id/237/100/100"}/>
            <Product productName={"sjhjdb"} productImgeUrl={"https://picsum.photos/id/237/100/100"}/>
            </Row>
        </Container>
    )
}



export default Products;