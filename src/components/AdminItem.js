import React from 'react'
import { Link } from 'react-router-dom'

function AdminItems({ image, name, itemID, price, stock }) {
  return (
    <div className="adminItem">
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
            <Link to="/updateitem"><button name={name} type="submit">Update Item</button></Link>
          </div2>
          <div2>
            <Link to="/updatestock"><button name={name} type="input">Update Stock</button></Link>
          </div2>
          <div2>
            <Link to="/removeitem"><button name={name} type="input">Remove Item</button></Link>
          </div2>
          </div1>
          
        </div>
      </div>
    </div>
  )
}

export default AdminItems

