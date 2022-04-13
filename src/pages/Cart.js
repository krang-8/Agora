import React from 'react'
import { CartList } from "../helpers/CartList";
import CartItem from "../components/CartItem";
import "../styles/Cart.css";
import { useState, useEffect } from "react";

function Cart() {
  const [status, setStatus] = useState('');
  const [list, setList] = useState([]);
  useEffect(()=>{
     setStatus('Loading');
     fetch('https://localhost:7235/get-Cart-by-id/1000')
       .then(response => response.json())
       .then(setList)
       .then(()=>setStatus('Success'))
       .catch(()=>setStatus('Error'));
   }, []);  

   
  return (
        <div className="cart">
          <h1 className="cartTitle">Cart</h1>
          <button>Place Order</button>
          <div className="cartList">
            {list.map((cartItem, key) => {
              return (
                <CartItem
                  key={key}
                  image={cartItem.image}
                  name={cartItem.itemName}
                  price={cartItem.itemPrice}
                  quantity={cartItem.quantity}
                />
              );
            })}
          </div>
        </div>
      );
}

export default Cart