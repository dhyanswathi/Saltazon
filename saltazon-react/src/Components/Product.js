function Product({product}) {
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
                <button>Add to Cart</button>
            </article>
        </>
    )
}

export default Product;