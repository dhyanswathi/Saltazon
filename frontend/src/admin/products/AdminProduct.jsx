function AdminProduct({product, updateQuantity}) {
    const quantity = 5;
    return (
        <>
            <h1>
                {product.title}
            </h1>
            <h2>
                {product.description}
            </h2>
            <img src={product.imageUrl} alt="product"/>
            <input type={"number"}/>
            <button onClick={() => updateQuantity(product.id, quantity)}>Update quantity</button>
        </>
    )
}

export default AdminProduct;