
import './Product.css'

function Product({product, addToCart}) {
    return (
        <>
            <article className={"product_item"}>
                <section className={"text_section"}>
                    <h1>
                        {product.title}
                    </h1>
                    <h2>
                        {product.description}
                    </h2>
                </section>
                <img src={product.imageUrl} alt="s"/>
                <button onClick={() => addToCart(product.id)}>Add to Cart</button>
            </article>
        </>
    )
}

export default Product;