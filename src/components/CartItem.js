import React from "react";
import { useState } from "react";

function CartItem({ image, name, price, quantity }) {


  return (
    <div className="cartItem">
      <div style={{ backgroundImage: `url(${image})` }}>
        <br></br>
      </div>
      <div>
      <h1> {name} </h1>
        <p> ${price} </p> 

        

      </div>

    </div>
  );
}

export default CartItem;
