import React from 'react'
import { Link } from 'react-router-dom';
import AdminItem from '../components/AdminItem'
import { ItemList } from '../helpers/AdminItemList'
import '../styles/Admin.css'
import { useState, useEffect } from "react";


function AdminItems() {
  const [status, setStatus] = useState('');
  const [list, setList] = useState([]);
  useEffect(()=>{
     setStatus('Loading');
     fetch('https://localhost:7235/get-all-Items')
       .then(response => response.json())
       .then(setList)
       .then(()=>setStatus('Success'))
       .catch(()=>setStatus('Error'));
   }, []);



  return (
    <div className="admin">
      <h1 className="adminTitle">Admin - Items</h1>  
      <Link to="/addnewitem"><button type="submit">Add New Item</button></Link> 
      <div className="AdminList">
        {list.map((Adminitem, key) => {
          return (
            <AdminItem
              key={key}
              image={Adminitem.image}
              name={Adminitem.itemName}
              price={Adminitem.itemPrice}
              stock={Adminitem.stock}
              itemID={Adminitem.itemID}
            />
          );
        })}
      </div>
    </div>
  )
}

export default AdminItems