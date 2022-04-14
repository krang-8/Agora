import React, { useState } from "react";
import Cart from "../assets/cart.png";
import "../styles/SignIn.css";
import "../styles/Navbar.css";
import { Redirect } from "react-router-dom";
import Shop from "./Shop";
import { BrowserRouter as Router, Link , Route, Switch } from "react-router-dom";
import {useHistory} from 'react-router-dom'
var isAuthenticated = false;

function SignIn() {

    const history = useHistory();
    const [data, setData] = useState({
          username: "",
          password: ""
      })

      
      function Buyer_Login(){
        console.log(data.username)
        console.log(data.password)
        console.log(JSON.stringify({
          username: data.username,
          password: data.password
        }))
        fetch(`https://localhost:7235/buyer-log-in`, {
          headers:{
            'Accept': 'application/json',
            'Content-Type': 'application/json'
          },
          method: 'POST',
          body: JSON.stringify({
            username: data.username,
            password: data.password
          }),
      })
      .then((response) => response.json())
      .then((result) => {
        if(result === "Login Successful"){
          console.log("SUCCESS");
          history.push("/Shop")
        }
        else{
          
          console.log("FAIL")
        }
      })

    }
    function Seller_Login(){
      console.log(data.username)
      console.log(data.password)
      console.log(JSON.stringify({
        username: data.username,
        password: data.password
      }))
      fetch(`https://localhost:7235/seller-log-in`, {
        headers:{
          'Accept': 'application/json',
          'Content-Type': 'application/json'
        },
        method: 'POST',
        body: JSON.stringify({
          username: data.username,
          password: data.password
        }),
    })
    .then((response) => response.json())
    .then((result) => {
      if(result === "Login Successful"){
        console.log("SUCCESS");
        history.push("/AddItems")


      }
      else{
        
        console.log("FAIL")
      }
    })

  }
    function handle(e){
      const newData={...data}
      newData[e.target.id] = e.target.value
      setData(newData)
      console.log(newData)
    }
  

    
    return (
      
    <div className="signin">
      <div
        className="leftSide"
        style={{ backgroundImage: `url(${Cart})` }}
      ></div>
      <div className="rightSide">
        <h1> Sign In</h1>

        <form id="contact-form" onSubmit='return false'>
          {/* <label htmlFor="name">Full Name</label> */}
          {/* <input name="name" placeholder="Enter full name..." type="text" /> */}
          <label htmlFor="username">Username</label>
          <input onChange={(e) => handle(e)} id="username" name="username" placeholder="Enter Username..." type="username" />
          <label htmlFor="password">Password</label>
          <input onChange={(e) => handle(e)} id="password" name="password" placeholder="Enter password..." type="password" />
          <div className="rightSide">
            <div>
            <button type="button" onClick={() => Buyer_Login()}> Customer Sign In</button>
            <button type="button" onClick={() => Seller_Login()} > Seller Sign In</button>
            </div>
            
          </div>
          {/* <div><button type="submit">Customer Sign In</button> <a>  </a>
          <button type="submit">Seller Sign In</button></div> */}

        </form>
      </div>
    </div>
  );
        
}

export default SignIn;
