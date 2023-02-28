import '../Styles/Product.css';
import {Link} from 'react-router-dom';

function Product({product}) {
    
    return (
        <>
            <article className="product_item" key={product.id}>
                <section className="text_section">
                    <h1>
                        {product.title}
                    </h1>
                </section>
                <img className='product-image' src={product.imageUrl} alt="s"/>
                <p>{product.price}</p>
                <Link to={`/details/${product.id}`}> <button>Details</button></Link>
            </article>
        </>
    )
}

export default Product;