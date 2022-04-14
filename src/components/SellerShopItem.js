import React from "react";
import { Link } from "react-router-dom";

function SellerShopItem({ image, name, itemID, price, stock }) {
  
  function deleteItem(itemID) {
    fetch(`https://localhost:7235/delete-Item-by-id/${itemID}`, {
      method: 'DELETE',
      header: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
      }
    })
    window.location.reload(false)
  }

  return (
    <div className="sellershopItem">
      <div>
        <div style={{ backgroundImage: `url(${image})` }}>
        </div>
        <div >
          <div1>
            <p> Name: {name} </p>
            <p> ItemID: {itemID}</p>
            <p> Price:  ${price} </p>
            <p> Stock: {stock} </p>
          </div1>
          <div1>

            <div2>
              <Link to="/removeitem"><button button onClick={() => deleteItem(itemID)} name={name} type="input">Remove Item</button></Link>
            </div2>
          </div1>
        </div>
      </div>
    </div>


  );
}

export default SellerShopItem;
