import StoreOverview from "./StoreOverview.jsx";
import {allStores} from "../fakedata/fakeStores.js";
import AddStoreForm from "./AddStoreForm.jsx";

function SuperAdminPage() {
    const currentUser = "Best Admin of all";
    return (
        <>
            <header>
                Welcome Almighty SuperAdmin {currentUser}
            </header>
            <AddStoreForm/>
            {
                allStores.map(s => {
                    return <StoreOverview storeInfo={s}/>
                })
            }

        </>
    )
}

export default SuperAdminPage;