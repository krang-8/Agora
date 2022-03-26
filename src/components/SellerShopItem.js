import React from "react";

function SellerShopItem({ image, name, itemID, price, stock }) {
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
            <div1>
              <button name={name} type="submit">Update Item</button>
              <br></br>
            </div1>
            <div2>
              <button name={name} type="input">Update Stock</button>
            </div2>
          </div1>
        </div>
      </div>
    </div>
    // <div className="sellershopItem">
    //   <div className="row">
    //   <div className="columnleft">dsad</div>
    //     <div className="columnright">asdas</div>
    //   </div>

    // </div>
    // <h1>Hi</h1>

  );
}

export default SellerShopItem;
