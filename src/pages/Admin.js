import React from 'react'  
import { Link } from "react-router-dom";
import "../styles/Admin.css";


function Admin() {

  return (
      
    <div className="adminmain">
      <h1 className="adminTitle">Admin</h1>  
      <div5>
      <Link to="/admincustomer"><button>Customer</button></Link>
      <Link to="/adminseller"><button>Seller</button></Link>
      <Link to="/adminitems"><button>Item</button></Link>
      </div5>
    </div>
  )
}



export default Admin