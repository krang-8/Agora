import React from 'react'
import { useState } from 'react';
  
import { Link } from "react-router-dom";
import "../styles/Admin.css";


function Admin() {

  return (
      
    <div className="admin">
      <h1 className="adminTitle">Admin</h1>  
      <div5>
      <Link to="/admin/customer"><button>Customer</button></Link>
      <Link to="/admin/seller"><button>Seller</button></Link>
      <Link to="/admin/items"><button>Item</button></Link>
      </div5>
    </div>
  )
}



export default Admin