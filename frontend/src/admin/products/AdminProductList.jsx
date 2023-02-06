import AdminProduct from './AdminProduct.jsx';
import AddProductForm from "./AddProductForm.jsx";

function AdminProductList({products, storeName}) {
    return (
        <div>
            <header>The items in {storeName}</header>
            <AddProductForm/>
            {
                products
                    .map((p) => {
                        return (
                            <AdminProduct key={p.id}
                                          product={p}/>)
                    })
            }
        </div>)
}

export default AdminProductList;