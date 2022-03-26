import React from 'react'

function AdminCustomer({ name, username, password, BuyerID, Address, Cart, Credits }) {
    return (
        <div className="adminCustomerItem">
            {/* <div1> */}
                <div1>
                    <p> Name: {name} </p>
                    <p> Password: {password}</p>
                    <p> BuyerID: {BuyerID}</p>
                    <p> Cart: {Cart} </p>
                    <p> Credits: {Credits}</p>
                    <p> Address: {Address} </p>
                </div1>
            {/* </div1> */}
        </div>
    )
}

export default AdminCustomer