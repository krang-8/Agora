import React from "react";

function ShopItem({ image, name, price }) {


  function sayHello() {
    alert('Added to Cart! (PLACEHOLDER)' + "   " + name);
    // add api call to add item to CART_LIST in database
  }
  

  return (
    <div className="shopItem">
      <div style={{ backgroundImage: `url(${image})` }}> </div>
      <h1> {name} </h1>
      <p> ${price} </p>
      <button onClick={() => sayHello(ShopItem)}>Add To Cart</button>
    </div>
  );
}

export default ShopItem;
