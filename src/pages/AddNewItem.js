import React, { useState } from "react";
import { Link } from 'react-router-dom'
import Cart from "../assets/cart.png";
import {useHistory} from 'react-router-dom'

function AddNewItem() {
    const history = useHistory();
    const [data, setData] = useState({
        itemID: "",
        itemPrice: "",
        SellerID: "",
        stock: "",
        itemName: "",
        Description: "",
        image: "",
    })
    function add_item() {


        fetch(`https://localhost:7235/create-Item`, {
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            method: 'POST',
            body: JSON.stringify({
                itemID: data.itemID,
                itemPrice: data.itemPrice,
                SellerID: data.SellerID,
                stock: data.stock,
                itemName: data.itemName,
                Description: data.Description,
                image: data.image,
            }),
        })
        .then((response) => response.json())
        .then((result) => {
          if(result === "Created Successfully"){
            console.log("SUCCESS");
          }
          else{
            alert("Error! All fields are required!")
          }
        })
    }
    function handle(e) {
        const newData = { ...data }
        newData[e.target.id] = e.target.value
        setData(newData)
        console.log(newData)
    }



    return (
        <div className="signin">
            <div
                className="leftSide"
                style={{ backgroundImage: `url(${Cart})` }}
            ></div>
            <div className="rightSide">
                <h1> Add New Item</h1>
                <form id="AddItem">
                    {/* <label htmlFor="name">Full Name</label> */}
                    {/* <input name="name" placeholder="Enter full name..." type="text" /> */}
                    <label htmlFor="itemnName">Item Name</label>
                    <input onChange={(e) => handle(e)} id="itemName" name="itemName" placeholder="Enter Item Name..." type="text" />
                    <label htmlFor="ItemID">Item ID</label>
                    <input onChange={(e) => handle(e)} id="itemID" name="itemID" placeholder="Enter ItemID..." type="number" />
                    <label htmlFor="price">Price</label>
                    <input onChange={(e) => handle(e)} id="itemPrice" name="itemPrice" placeholder="Enter Price..." type="number" />
                    <label htmlFor="stock">Stock</label>
                    <input onChange={(e) => handle(e)} id="stock" name="stock" placeholder="Enter Stock..." type="number" />
                    <label htmlFor="image">Image</label>
                    <input onChange={(e) => handle(e)} id="image" name="image" placeholder="Enter Image..." type="text" />
                    <label htmlFor="SellerID">SellerID</label>
                    <input onChange={(e) => handle(e)} id="SellerID" name="SellerID" placeholder="Enter SellerID..." type="number" />
                    <label htmlFor="Description">Description</label>
                    <input onChange={(e) => handle(e)} id="Description" name="Description" placeholder="Enter Description..." type="text" />

                    <div className="rightSide">
                        <div>
                            <button type="button" onClick={() => add_item()}>Submit</button>
                        </div>

                    </div>


                </form>
            </div>
        </div>
    )
}

export default AddNewItem