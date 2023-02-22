import React, {useState} from "react";
import axios from 'axios';
import { useNavigate } from "react-router-dom";
import { setAuthToken } from "../SetAuthToken";

function LoginForm({onSubmit}) {
  const [ email, setEmail ] = useState('');
  const [ password, setPassword] = useState('');

  const url = "https://localhost:7148/api/User/login";

  let navigate = useNavigate();
    const postData = (e) => {
      e.preventDefault();
      axios.post(url, {
        email: email,
          password: password
    }).then(response => {
      if(response.status === 200){
        localStorage.setItem("token", JSON.stringify(response.data));
        setAuthToken(response.data.token);
        if (response.data.role === "admin") {
          navigate('/admin')
        }
        else {
          navigate('/');
        }
      }
      else 
      {
        alert('Email or password is incorrect');
      }
    }).catch(error => {
        console.log(error)
    });
    }

    return (
        <>
          <h3>Login</h3>
          <form onSubmit={postData} className={"login_form"}>
            <label htmlFor="email_input">Email</label>
            <input placeholder={"email"} id={"email_input"} type="email"
             required='required' 
             onChange={(e) => setEmail(e.target.value)}/>
            <br/>
            <label htmlFor="password_input">Password</label>
            <input placeholder={"password"} id={"password_input"} type="password"
             required='required' onChange={(e) => setPassword(e.target.value)}/>
            <br/>
            <button variant="primary" type="submit" id='btnAddTodo'>Login</button>
          </form>
        </>
    )
  }
  
  export default LoginForm;