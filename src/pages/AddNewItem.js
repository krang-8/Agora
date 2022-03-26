import React from 'react'
import { Link } from 'react-router-dom'
import Cart from "../assets/cart.png";

function AddNewItem() {
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
                    <label htmlFor="itemname">Item Name</label>
                    <input name="itemname" placeholder="Enter Item Name..." type="text" />
                    <label htmlFor="itemID">Item ID</label>
                    <input name="itemID" placeholder="Enter ItemID..." type="text" />
                    <label htmlFor="price">Price</label>
                    <input name="price" placeholder="Enter Price..." type="number" />
                    <label htmlFor="stock">Stock</label>
                    <input name="stock" placeholder="Enter Stock..." type="number" />
                    <label htmlFor="image">Image</label>
                    <input name="Image" placeholder="Enter Image..." type="file" />
                    <div className="rightSide">
                        <div>
                            <button type="submit">Submit</button>
                        </div>

                    </div>
            

                </form>
            </div>
        </div>
    )
}

export default AddNewItem