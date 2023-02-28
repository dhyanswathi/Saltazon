import React, { useEffect, useState } from "react";
import { useParams } from "react-router-dom";

function ProductDetails() {
    const params  = useParams();
    const [product, setProduct] = useState({
        id: 0,
        title: '',
        description: '',
        imageUrl: '',
        storeId: 0,
        price: '',
        quantity: 0,
        category: ''
    });

    useEffect(() => {
        const getData = async () => {
          const response = await fetch(`https://localhost:7148/api/Product/${params.id}`);
          const some = await response.json();
          const data = some.data;
    
          setProduct(prev => {
            return {
              ...prev,
              id: data.id,
                title: data.title,
                description: data.description,
                imageUrl: data.imageUrl,
                storeId: data.storeId,
                price: data.price,
                quantity: data.quantity,
                category: data.category
            }
          });
        }
        getData();
      },);

    return (
        <section className="details" >
            <section className="info">
            <h1>{product.title}</h1>
            <img src={product.imageUrl} alt="s"/>
            <p>{product.description}</p>
            <p>{product.price}</p>
            <button id="add-to-cart" className="details-button">Add to Cart</button>
            </section>
        </section>
    )
}

export default ProductDetails;