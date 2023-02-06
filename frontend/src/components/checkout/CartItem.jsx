import './Cart.css';

function CartItem({product, removeFromCart}) {
  return (
      <article className={"cart_item"}>
        <img src={product.imageUrl} alt="i"/>
        <section className={"text_section"}>
          <h2>
            {product.title}
          </h2>
          <h3>Amount {product.amount}</h3>
          <h3>Price {product.price}</h3>
        </section>
        <button onClick={() => removeFromCart(product.id)}>Remove from Cart</button>
      </article>
  )
}

export default CartItem;