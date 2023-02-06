function NewUserForm({onSubmit}) {
    return (
        <>
          <h3>Create new user</h3>
          <form onSubmit={onSubmit} className={"create_user_form"}>
            <label htmlFor="email_input">Email</label>
            <input placeholder={"email"} id={"email_input"}/>
            <br/>
            <label htmlFor="password_input">Password</label>
            <input placeholder={"password"} id={"password_input"}/>
            <br/>
            <label htmlFor="confirmed_password_input">Confirm password</label>
            <input placeholder={"confirm password"} id={"confirmed_password_input"}/>
            <br/>
            <label htmlFor="type_input">Type of User</label>
            <select placeholder={"user"} id={"type_input"}>
              <option value={"user"}>User</option>
              <option value={"admin"}>Admin</option>
            </select>
            <br/>
            <input type={'submit'}/>
          </form>
        </>
    )
  }
  
  export default NewUserForm;