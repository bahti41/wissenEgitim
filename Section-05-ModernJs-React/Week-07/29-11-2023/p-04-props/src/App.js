
import './App.css';
import ProductList from './Components/ProductList/ProductList';
import TickTock from './Components/TickTock/TickTock';

function App() {
  // const firstName = "bahtiyar";
  // const lastName = "sonmez"
  // const age = 26;
  let Product = [
    {id:1, name: "Iphone14", desc: "hoş bir tel",price: 4600 },
    {id:2, name: "Iphone15", desc: "hoş bir tel",price: 5600 },
    {id:3, name: "Iphone16", desc: "hoş bir tel",price: 6600 },
    {id:4, name: "Iphone17", desc: "hoş bir tel",price: 8600 }
  ];
  return (
    <>
      <div>
      {/* <TickTokck firstName={firstName} lastName={lastName} age={age} />
      <TickTokck firstName={firstName} lastName={lastName} age={age} /> */}
      <ProductList product={product} />
      </div>
    </>
  );
}

export default App;
