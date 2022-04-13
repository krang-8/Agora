import React from "react";
// import { ShopList } from "../helpers/ShopList";
import ShopItem from "../components/ShopItem";
import "../styles/Shop.css";
import { useState, useEffect } from "react";


function Shop(){
  const [status, setStatus] = useState('');
  const [list, setList] = useState([]);
  useEffect(()=>{
     setStatus('Loading');
     fetch('https://localhost:7235/get-all-Items')
       .then(response => response.json())
       .then(setList)
       .then(()=>setStatus('Success'))
       .catch(()=>setStatus('Error'));
   }, []);
   return (
    <div className="shop">
      <h1 className="shopTitle">Our Items</h1>
      <div className="shopList">     
        {list.map((shopItem, key) => {
          return (
            <ShopItem
              key={key}
              image={shopItem.image}
              name={shopItem.itemName}
              price={shopItem.itemPrice}
            />
          );
        })}
      </div>
    </div>
  );
 }

// function Shop() {
//   return (
//     <div className="shop">
//       <h1 className="shopTitle">Our Items</h1>
//       <div className="shopList">

        
//         {ShopList.map((shopItem, key) => {
//           return (
//             <ShopItem
//               key={key}
//               image={shopItem.image}
//               name={shopItem.name}
//               price={shopItem.price}
//             />
//           );
//         })}
//       </div>
//     </div>
//   );
// }

export default Shop;
