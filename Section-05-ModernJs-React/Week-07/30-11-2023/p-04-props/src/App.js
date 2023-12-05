
import { useState } from 'react';
import './App.css';
import ProductList from './Components/ProductList/ProductList';
// import TickTock from './Components/TickTock/TickTock';

function App() {
  // const firstName = "bahtiyar";
  // const lastName = "sonmez"
  // const age = 26;
  let products = [
    { id: 1, name: "Iphone14", desc: "hoş bir telefon", price: 4600 },
    { id: 2, name: "Iphone15", desc: "hoş bir telefon", price: 5600 },
    { id: 3, name: "Iphone16", desc: "hoş bir telefon", price: 6600 },
    { id: 4, name: "Iphone17", desc: "hoş bir telefon", price: 8600 }
  ];


  let [number, setNumber] = useState(10);
  function numberAdd() {
    setNumber(++number);
  }
  return (
    <>
      <div>
      {/* <TickTokck firstName={firstName} lastName={lastName} age={age} />
      <TickTokck firstName={firstName} lastName={lastName} age={age} /> */}
      <button onClick={numberAdd}>Tıkla</button>
      <label>{number}</label>
      <ProductList products={products} />
      </div>
    </>
  );
}

export default App;
