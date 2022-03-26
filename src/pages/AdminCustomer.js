import React from 'react'
import { Link } from 'react-router-dom';
import Admincustomer from '../components/AdminCustomer';
import { CustomerList } from '../helpers/AdminCustomerList';
import "../styles/AdminCustomer.css";
function AdminCustomer() {
  return (
    <div className="adminCustomer">
      <h1 className="adminCustomerTitle">Admin - Customer </h1>  
      <Link to="/addnewitem"><button type="submit">Add New Item</button></Link> 
      <div className="adminCustomerList">
        {CustomerList.map((AdminCustomer, key) => {
          return (
            <Admincustomer
              key={key}
              name={AdminCustomer.name}
              username={AdminCustomer.username}
              password={AdminCustomer.password}
              Address={AdminCustomer.Address}
              Cart={AdminCustomer.Cart}
              BuyerID={AdminCustomer.BuyerID}
            />
          );
        })}
      </div>
    </div>
  )
}

export default AdminCustomer