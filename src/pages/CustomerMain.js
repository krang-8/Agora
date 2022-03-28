import React from 'react'
import { Link } from 'react-router-dom'
import "../styles/Customermain.css"
import background from "../assets/ShopingBanner.png"
function CustomerMain() {
  return (
    <div className="customermain" >
      <h1 className="customerTitle">Customer Home</h1>

      <div5>
      <Link to="/shop"><button>Shop</button></Link>
      <Link to="/pastorders"><button>Past Orders</button></Link>
      </div5>
    </div>
  )
}

export default CustomerMain