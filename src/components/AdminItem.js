import React from 'react'

function AdminItems({ image, name, itemID ,price, stock }) {
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
          </div>
        </div>
      </div>
  )
}

export default AdminItems
  
