import React from 'react'

function list(X){
    return <option>{X}</option>
}

function AdminCustomerItem({ name, username, password, BuyerID, Address, Cart, Credits }) {



    return (
        <div className="adminCustomerItem">

            <div1>
                <p> <b>Name:</b> {name} </p>
                <p> <b>Username:</b> {username}</p> 
                <p> <b>Password</b>: {password}</p>
                <p> <b>BuyerID:</b> {BuyerID}</p>
                <p> <b>Cart:</b> {Cart} </p>
                <p> <b>Credits:</b> ${Credits}</p>
                <p> <b>Address:</b> <select id='addresslist'><option>Address List</option>{Address.map(list)}</select> </p>
            </div1>

            <div1>
                {/* <div1><button>Change Password</button></div1> */}
                <div1><button>Delete Account</button></div1>
                <div1><button>Update Account</button></div1>
                
            </div1>

        </div>
    )
}

export default AdminCustomerItem