import React from 'react'

import { Col, Button, Card } from "react-bootstrap";
function Product({ productName, productImgeUrl }) {
    return (
        <Col>
            <Card>
                <Card.Img style={{ width: "100px" }} variant="top" src={productImgeUrl} />
                <Card.Body>
                    <Card.Title>Card Title</Card.Title>
                    <Card.Text>
                        Some quick example text to build on the card title and make up the
                        bulk of the card's content.
                    </Card.Text>
                    <Button variant="primary">Go somewhere</Button>
                </Card.Body>
            </Card>
        </Col>
    )
}

export default Product;




