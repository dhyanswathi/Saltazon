import AdminProductList from "./products/AdminProductList.jsx";
import React, {useState, useEffect} from "react";
import { setAuthToken } from "../components/SetAuthToken.jsx";


function AdminPage() {
    const store = JSON.parse(localStorage.getItem("token"));
    console.log(store.storeId);

    const currentStore = "Salt store number 2";
    const [storeProducts, setStoreProducts] = useState([]);

    useEffect(() => {
      const getData = async () => {
        const token = JSON.parse(localStorage.getItem("token")).token;
        if (token) {
            setAuthToken(token);
        }
          const response = await fetch(`https://localhost:7148/api/Store/${store.storeId}/product`);
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