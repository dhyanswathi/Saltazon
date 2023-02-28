import {useState, useEffect} from 'react';
import Product from './Product';

function ProductList() {
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
    <section className='product-list'>{
        products
            .map((p) => {
                return (
                    <Product key={p.id}
                             product={p}/>)
            })
    }
    </section>
  )
}

export default ProductList;