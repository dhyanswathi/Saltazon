import '../Styles/Product.css'

function Product({product}) {
    return (
        <>
            <article className="product_item">
                <section className="text_section">
                    <h1>
                        {product.title}
                    </h1>
                </section>
                <img className='product-image' src={product.imageUrl} alt="s"/>
                <p>{product.price}</p>
                <button>Add to Cart</button>
            </article>
        </>
    )
}

export default Product;