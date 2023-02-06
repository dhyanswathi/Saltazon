import {Link} from "react-router-dom";

export default function StoreOverview({storeInfo}) {
    return (
        <>
            <h3>StoreName: {storeInfo.name}</h3>
            <p>StoreId: {storeInfo.id}</p>
            <h3>AdminId: {storeInfo.adminId}</h3>
            <Link to={"/admin"}>Go to {storeInfo.name}</Link>
            <button>Delete Store</button>
        </>
    )
}