function AddProductForm() {
    return (
        <>
            <h4>Add new Product</h4>
            <form className={"add_product_form"}>
                <label htmlFor={"title_input"}>Title</label>
                <input placeholder={"title of product"} id={"title_input"}/>
                <br/>
                <label htmlFor={"quantity_input"}>Quantity</label>
                <input type={"number"} placeholder={1} id={"quantity_input"}/>
                <br/>
                <label htmlFor={"price_input"}>Price</label>
                <input type={"number"} id={"price_input"}/>
                <br/>
                <label htmlFor={"category_input"}>Category</label>
                <input type={"text"} placeholder={"category"} id={"category_input"}/>
                <br/>
                <button onClick={() => console.log("Added new product")}>Add product</button>
            </form>
        </>
    )
}

export default AddProductForm;