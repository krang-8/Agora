import React from 'react'
import { SellerShopList } from "../helpers/SellerShopList";
import SellerShopItem from "../components/SellerShopItem";
import { Link } from "react-router-dom";
import "../styles/SellerShop.css";

function SellerControl() {
  return (
    <div className="sellershop">
      <h1 className="sellershopTitle">Your SellerShop </h1>  
      <Link to="/addnewitem"><button type="submit">Add New Item</button></Link> 
      
      <div className="sellershopList">
        {SellerShopList.map((SellershopItem, key) => {
          return (
            <SellerShopItem
              key={key}
              image={SellershopItem.image}
              name={SellershopItem.name}
              price={SellershopItem.price}
              stock={SellershopItem.stock}
              itemID={SellershopItem.itemID}
            />
          );
        })}
      </div>
    </div>
  )
}

export default SellerControl