import './App.css';
import {useState, useEffect} from 'react';
import {
    BrowserRouter as Router,
    Routes,
    Route,
} from 'react-router-dom';
import {fakecart} from './fakedata/fakecart.js';
import NavBar from './components/Navbar.jsx';
import Cart from './components/checkout/Cart.jsx';
import AdminPage from "./admin/AdminPage.jsx";
import ProfileBar from "./components/ProfileBar.jsx";
import ProductList from './components/products/ProductList.jsx';
import LoginForm from './components/login/LoginForm.jsx';
import NewUserForm from './components/login/NewUserForm.jsx';
import SuperAdminPage from "./admin/SuperAdminPage.jsx";
import { setAuthToken } from './components/SetAuthToken';

function addToCart(productId) {
    console.log("Add " + productId + " From the App")
    //add item to the current Cart
}

function removeFromCart(productId) {
    console.log("Remove " + productId + " From the App")
    //remove item from the current Cart
}

function getCurrentCart() {
    return fakecart;
    //update to get from localstorage
}


function App() {
    const [currentCart, setCurrentCart] = useState(getCurrentCart());

    const token = localStorage.getItem("token").token;
    if (token) {
        setAuthToken(token);
    }

    const [products, setProducts] = useState([]);

    useEffect(() => {
      const getData = async () => {
          const response = await fetch("https://localhost:7148/api/Product");
          const productResults = await response.json();
          setProducts(productResults.data);
      }
      getData();
  }, []);
    return (
        <div className="App">
            <Router>
                <header className={"top_header"}>
                    <ProfileBar/>
                    <NavBar/>
                </header>
                <Routes>
                    <Route exact path='/create-new-user' element={< NewUserForm/>}></Route>
                    <Route exact path='/login' element={< LoginForm/>}></Route>
                    <Route exact path='/'
                           element={< ProductList products={products} addToCart={addToCart}/>}></Route>
                    <Route exact path='/cart'
                           element={< Cart products={currentCart} removeFromCart={removeFromCart}/>}></Route>
                    <Route exact path='/admin' element={< AdminPage/>}></Route>
                    <Route exact path='/admin/super' element={< SuperAdminPage/>}></Route>
                </Routes>
            </Router>
        </div>
    )
}

export default App;
