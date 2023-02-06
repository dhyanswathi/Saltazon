function LoginForm({onSubmit}) {
    return (
        <>
          <h3>Login</h3>
          <form onSubmit={onSubmit} className={"login_form"}>
            <label htmlFor="email_input">Email</label>
            <input placeholder={"email"} id={"email_input"}/>
            <br/>
            <label htmlFor="password_input">Password</label>
            <input placeholder={"password"} id={"password_input"}/>
            <br/>
            <input type={'submit'}/>
          </form>
        </>
    )
  }
  
  export default LoginForm;