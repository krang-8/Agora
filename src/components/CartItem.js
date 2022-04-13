import React from "react";
import { useState } from "react";

function CartItem({ image, name, price, quantity }) {
  const [counter, setCounter] = useState(1);
  const incrementCounter = () => setCounter(counter + 1);
  let decrementCounter = () => setCounter(counter - 1);
  if(counter<=0) {
    decrementCounter = () => setCounter(1);
  }

  return (
    <div className="cartItem">
      <div style={{ backgroundImage: `url(${image})` }}>
        <br></br>
      </div>
      <div>
      <h1> {name} </h1>
        <p> ${price} </p>
        <p><button type="button" onClick={decrementCounter}>-</button> {quantity} <button type="button" onClick={incrementCounter}>+</button></p>
      </div>
    </div>
  );
}

export default CartItem;
