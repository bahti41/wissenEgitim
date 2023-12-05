import React from 'react'

function Product({product}) {
  console.log(product)
  return (
    <div>
        <h1>{product.name}</h1>
        <p>{product.desc}</p>
        <p>{product.price}</p>
    </div>
  )
}

export default Product;
