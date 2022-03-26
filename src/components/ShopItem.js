import React from "react";

function ShopItem({ image, name, price }) {
  return (
    <div className="shopItem">
      <div style={{ backgroundImage: `url(${image})` }}> </div>
      <div2 >
        <h7> {name} </h7>
        <p> ${price} </p>
      </div2>
      <div2>
      <button>Add to Cart</button>
      </div2>
      
    </div>
  );
}

export default ShopItem;
