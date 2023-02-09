import React, {useState} from "react";
import axios from 'axios';
import { useNavigate } from "react-router-dom";

function NewUserForm({onSubmit}) {
  const url = "https://localhost:7148/api/User/register";

  const [ email, setEmail ] = useState('');
  const [ password, setPassword] = useState('');
  const [ repassword, setRePassword] = useState('');
  const [ role, setRole ] = useState('user');
  const [ storeId, setStoreId] = useState(0);

  const passwordCheck = (e) => {
    setRePassword(e.target.value)
    if (password !== repassword) {
      alert('Passwords not match');
    }
  }

  const handleChange = (e) => {
    setRole(e.target.value);
  };


  let navigate = useNavigate();
    const postData = (e) => {
      e.preventDefault();
      axios.post(url, {
          email: email,
          password: password,
          role: role,
          storeId: storeId
    }).then(response => {
      if(response.status === 201){
        localStorage.setItem("email",email);
        navigate('/login');
      }
      else 
      {
        alert('User already exists');
      }
    }).catch(error => {
        console.log(error)
    });
    }

    return (
        <>
          <h3>Create new user</h3>
          <form onSubmit={postData} className={"create_user_form"}>
            <label htmlFor="email_input">Email</label>
            <input placeholder={"email"} id={"email_input"} type="email" 
            required='required' onChange={(e) => setEmail(e.target.value)}/>
            <br/>
            <label htmlFor="password_input">Password</label>
            <input placeholder={"password"} id={"password_input"} type="password" required='required'
             onChange={(e) => setPassword(e.target.value)}/>
            <br/>
            <label htmlFor="confirmed_password_input">Confirm password</label>
            <input placeholder={"confirm password"} id={"confirmed_password_input"} type="password" required='required'
        onChange={passwordCheck}/>
            <br/>
            <label htmlFor="type_input">Type of User</label>
            <select placeholder={"user"} id={"type_input"} onChange={(e) =>handleChange(e)}>
              <option value={"user"}>User</option>
              <option value={"admin"}>Admin</option>
            </select>
            <br/>
            <label htmlFor="store_input">StoreId</label>
            <input placeholder={"store"} id={"store_input"} type="number"
            onChange={(e) => setStoreId(e.target.value)}/>
            <br/>
            <input type={'submit'}/>
          </form>
        </>
    )
  }
  
  export default NewUserForm;