import React from 'react'
import { Link } from 'react-router-dom';
import AdminCustomerItem from '../components/AdminCustomerItem';
import { CustomerList } from '../helpers/AdminCustomerList';
import "../styles/AdminCustomer.css";
function AdminCustomer() {
  return (
    <div className="adminCustomer">
      <h1 className="adminCustomerTitle">Admin - Customer </h1>  
      <Link to="/admin"><button >Return to main</button></Link> 
      <div className="adminCustomerList">
        {CustomerList.map((AdminCustomer, key) => {
          return (
            <AdminCustomerItem
              key={key}
              name={AdminCustomer.name}
              username={AdminCustomer.username}
              password={AdminCustomer.password}
              Address={AdminCustomer.Address}
              Cart={AdminCustomer.Cart}
              Credits={AdminCustomer.Credits}
              BuyerID={AdminCustomer.BuyerID}
            />
          );
        })}
      </div>
    </div>
  )
}

export default AdminCustomer