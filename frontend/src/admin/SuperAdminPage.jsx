import StoreOverview from "./StoreOverview.jsx";
import AddStoreForm from "./AddStoreForm.jsx";
import React, {useState, useEffect} from "react";

function SuperAdminPage() {
    const currentUser = "Best Admin of all";

    const [stores, setStores] = useState([]);

    useEffect(() => {
      const getData = async () => {
          const response = await fetch(`https://localhost:7148/api/Store`);
          const storeResults = await response.json();
          setStores(storeResults.data);
      }
      getData();
  });
    return (
        <>
            <header>
                Welcome Almighty SuperAdmin {currentUser}
            </header>
            <AddStoreForm/>
            {
                stores.map(s => {
                    return <StoreOverview storeInfo={s}/>
                })
            }

        </>
    )
}

export default SuperAdminPage;