import React from 'react'
import { Link } from 'react-router-dom';
import "../styles/AdminSeller.css";
import { useState, useEffect } from "react";
import AdminSellerItem from '../components/AdminSellerItem';

function AdminSeller() {
  const [status, setStatus] = useState('');
  const [list, setList] = useState([]);
  useEffect(()=>{
     setStatus('Loading');
     fetch('https://localhost:7235/get-all-Sellers')
       .then(response => response.json())
       .then(setList)
       .then(()=>setStatus('Success'))
       .catch(()=>setStatus('Error'));
   }, []);
  return (
    <div className="AdminSeller">
      <h1 className="AdminSellerTitle">Admin - Seller </h1>  
      <Link to="/admin"><button >Return to main</button></Link> 
      <div className="AdminSellerList">
        {list.map((AdminSeller, key) => {
          return (
            <AdminSellerItem
              key={key}
              name={AdminSeller.name}
              username={AdminSeller.username}
              password={AdminSeller.password}
              Address={AdminSeller.Address}
              SellerId={AdminSeller.SellerId}
            />
          );
        })}
      </div>
    </div>
  )
}

export default AdminSeller