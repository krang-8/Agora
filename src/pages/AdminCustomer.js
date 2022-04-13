import React from 'react'
import { Link } from 'react-router-dom';
import AdminCustomerItem from '../components/AdminCustomerItem';
import { CustomerList } from '../helpers/AdminCustomerList';
import "../styles/AdminCustomer.css";
import { useState, useEffect } from "react";

function AdminCustomer() {
  const [status, setStatus] = useState('');
  const [list, setList] = useState([]);
  useEffect(()=>{
     setStatus('Loading');
     fetch('https://localhost:7235/get-all-Buyers')
       .then(response => response.json())
       .then(setList)
       .then(()=>setStatus('Success'))
       .catch(()=>setStatus('Error'));
   }, []);
  return (
    <div className="adminCustomer">
      <h1 className="adminCustomerTitle">Admin - Customer </h1>  
      <Link to="/admin"><button >Return to main</button></Link> 
      <div className="adminCustomerList">
        {list.map((AdminCustomer, key) => {
          return (
            <AdminCustomerItem
              key={key}
              name={AdminCustomer.name}
              username={AdminCustomer.username}
              password={AdminCustomer.password}
              Address={[AdminCustomer.Address1,AdminCustomer.Address2,AdminCustomer.Address3]}
              Cart={AdminCustomer.CartID}
              Credits={AdminCustomer.Credits}
              BuyerID={AdminCustomer.BuyerId}
            />
          );
        })}
      </div>
    </div>
  )
}

export default AdminCustomer