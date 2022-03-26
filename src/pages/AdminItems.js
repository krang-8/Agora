import React from 'react'
import { Link } from 'react-router-dom';
import AdminItem from '../components/AdminItem'
import { ItemList } from '../helpers/AdminItemList'
import '../styles/Admin.css'
function AdminItems() {
  return (
    <div className="admin">
      <h1 className="adminTitle">Admin - Items</h1>  
      <Link to="/addnewitem"><button type="submit">Add New Item</button></Link> 
      <div className="AdminList">
        {ItemList.map((Adminitem, key) => {
          return (
            <AdminItem
              key={key}
              image={Adminitem.image}
              name={Adminitem.name}
              price={Adminitem.price}
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