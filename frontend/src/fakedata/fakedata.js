import React, { useState, useEffect } from "react";

const Fakeproducts = () => {
  const [products, setProducts] = useState([]);

  useEffect(() => {
    const getData = async () => {
        const response = await fetch("http://localhost:5295/api/Product");
        const productResults = await response.json();
        setProducts(productResults.data);
    }
    getData();
}, []);

return (
  <section className="homePage">
      <ul className="product-list">
          {
              products.map(product => 
                  <li className="listed-products">
                    <h6>{product.title}</h6>
                      </li>)
          }
      </ul>
  </section>
)
}

export default Fakeproducts;
// export const fakeProducts = [{
//     id: "1",
//     title: "Harry potter, prisoner of Azkaban",
//     description: "The coolest of all the books",
//     imageUrl: "https://images.unsplash.com/photo-1417325384643-aac51acc9e5d?q=75&fm=jpg&w=400&fit=max",
//     quantity: 107,
//     price: 109.4,
//     category: 'Must haves'
    
//   },
//     {
//       id: "2",
//       title: "Motorcycle",
//       description: "a cool description",
//       imageUrl: "https://images.unsplash.com/photo-1417325384643-aac51acc9e5d?q=75&fm=jpg&w=400&fit=max",
//       quantity: 1,
//       price: 599,
//       category: 'Vehicles'
      
//     },
//     {
//       id: "3",
//       title: "Arvid Nordqvist Coffee",
//       description: "a cool description",
//       imageUrl: "https://images.unsplash.com/photo-1417325384643-aac51acc9e5d?q=75&fm=jpg&w=400&fit=max",
//       quantity: 4,
//       price: 25.9,
//       category: 'Must haves'
//     },
//     {
//       id: "4",
//       title: "Dressman shirt",
//       description: "a cool description",
//       imageUrl: "https://images.unsplash.com/photo-1417325384643-aac51acc9e5d?q=75&fm=jpg&w=400&fit=max",
//       quantity: 78,
//       price: 600.5,
//       category: 'Clothes'
//     },
//     {
//       id: "5",
//       title: "RTX 4090 Graphics Card",
//       description: "a cool description",
//       imageUrl: "https://images.unsplash.com/photo-1417325384643-aac51acc9e5d?q=75&fm=jpg&w=400&fit=max",
//       quantity: 26,
//       price: 9999.9,
//       category: 'Computer Parts'
//     },
//     {
//       id: "6",
//       title: "Volvo V70",
//       description: "a cool description",
//       imageUrl: "https://images.unsplash.com/photo-1417325384643-aac51acc9e5d?q=75&fm=jpg&w=400&fit=max",
//       quantity: 18,
//       price: 100000.1,
//       category: 'Vehicles'
//     }];