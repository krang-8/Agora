import React from 'react'

function list(X){
    return <option>{X}</option>
}

function deleteSeller(SellerId){

    fetch(`https://localhost:7235/delete-Seller-by-id/${SellerId}`,{
         method:'DELETE',
        header:{'Accept':'application/json',
                'Content-Type':'application/json'}
    })
    window.location.reload(false)

}
function AdminSellerItem({ name, username, password, SellerId, Address }) {



    return (
        <div className="AdminSellerItem">

            <div1>
                <p> <b>Name:</b> {name} </p>
                <p> <b>Username:</b> {username}</p> 
                <p> <b>Password</b>: {password}</p>
                <p> <b>SellerID:</b> {SellerId}</p>
                <p> <b>Address:</b> {Address} </p>
            </div1>

            <div1>
                {/* <div1><button>Change Password</button></div1> */}
                <div1><button onClick={() => deleteSeller(SellerId)}>Delete Account</button></div1>
                
            </div1>

        </div>
    )
}

export default AdminSellerItem