function AddStoreForm() {
    return (
        <>
            <h4>Add new Store</h4>
            <form className={"add_store_form"}>
                <label htmlFor={"name_input"}>Title</label>
                <input placeholder={"Name of store"} id={"name_input"}/>
                <br/>
                <label htmlFor={"admin_input"}>Admin Id</label>
                <input type={"text"} id={"admin_input"}/>
                <br/>
                <button onClick={() => console.log("Added new store")}>Add Store</button>
            </form>
        </>
    )
}

export default AddStoreForm;