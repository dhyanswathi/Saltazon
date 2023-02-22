import AdminProductList from "./products/AdminProductList.jsx";
import React, {useState, useEffect} from "react";
import { useParams } from "react-router-dom";

function AdminPage() {
    const params =useParams();
    const currentStore = "Salt store number 2";
    const [storeProducts, setStoreProducts] = useState([]);

    useEffect(() => {
      const getData = async () => {
          const response = await fetch(`http://localhost:7148/api/Store/${params.id}/product`);
          const productResults = await response.json();
          setStoreProducts(productResults);
      }
      getData();
  });
    return (
        <>
            <header>
                Welcome to the {currentStore}
            </header>
            <AdminProductList products={storeProducts} storeName={currentStore} />
        </>
    )
}

export default AdminPage;