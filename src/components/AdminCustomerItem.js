import React from 'react'

function list(X){
    return <option>{X}</option>
}

function deleteBuyer(BuyerID, Cart){

    fetch(`https://localhost:7235/delete-Buyer-by-id/${BuyerID}`,{
         method:'DELETE',
        header:{'Accept':'application/json',
                'Content-Type':'application/json'}
    })
    fetch(`https://localhost:7235/delete-cart-by-id/${Cart}`,{
        method:'DELETE',
       header:{'Accept':'application/json',
               'Content-Type':'application/json'}
   })
    window.location.reload(false)

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
                <div1><button onClick={() => deleteBuyer(BuyerID, Cart)}>Delete Account</button></div1>
                
            </div1>

        </div>
    )
}

export default AdminCustomerItem