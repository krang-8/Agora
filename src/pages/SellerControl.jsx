import React from 'react'
import { SellerShopList } from "../helpers/SellerShopList";
import SellerShopItem from "../components/SellerShopItem";
import { Link } from "react-router-dom";
import "../styles/SellerShop.css";
import { useState, useEffect } from "react";


function SellerControl() {
  
const [status, setStatus] = useState('');
const [list, setList] = useState([]);
useEffect(()=>{
   setStatus('Loading');
   fetch('https://localhost:7235/get-seller-items/4')
     .then(response => response.json())
     .then(setList)
     .then(()=>setStatus('Success'))
     .catch(()=>setStatus('Error'));
 }, []);


  return (
    <div className="sellershop">
      <h1 className="sellershopTitle">Your SellerShop </h1>  
      <Link to="/addnewitem"><button type="submit">Add New Item</button></Link> 
      <div className="sellershopList">
        {list.map((SellershopItem, key) => {
          return (
            <SellerShopItem
              key={key}
              image={SellershopItem.image}
              name={SellershopItem.itemName}
              price={SellershopItem.itemPrice}
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