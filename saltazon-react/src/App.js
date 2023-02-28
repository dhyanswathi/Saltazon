import './App.css';
import {useState, useEffect} from 'react';
import Product from './Components/Product';

function App() {
  const [products, setProducts] = useState([]);

    useEffect(() => {
      const getData = async () => {
          const response = await fetch("https://localhost:7148/api/Product");
          const productResults = await response.json();
          setProducts(productResults.data);
      }
      getData();
  }, []);

  return (
    <div className="App">
      <h2>Welcome to saltazon!</h2>
      <section className={"product_list"}>{
                products
                    .map((p) => {
                        return (
                            <Product key={p.id}
                                     product={p}/>)
                    })
            }
            </section>
    </div>
  );
}

export default App;
