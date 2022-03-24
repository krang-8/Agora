import React, { useState } from "react";
import Logo from "../assets/AGORA.png";
import { Link } from "react-router-dom";
import ReorderIcon from "@material-ui/icons/Reorder";
import "../styles/Navbar.css";
import 'react-dropdown/style.css';
import Cart from './cart.js'

function Navbar() {
  const [openLinks, setOpenLinks] = useState(false);
  const isToggle = Cart.isToggle
  const setToggle = Cart.setToggle
  const context = Cart.context
  const toggleNavbar = () => {
    setOpenLinks(!openLinks);
  };

  const options = [
    'one', 'two', 'three'
        ];
const defaultOption = options[0];
  return (
    <div className="navbar">
      <div className="leftSide" id={openLinks ? "open" : "close"}>
        
        <img src={Logo} />
        <div className="hiddenLinks">
          <Link to="/"> Home </Link>
          <Link to="/shop"> Shop </Link>
          <Link to="/about"> About </Link>
          <Link to="/signin"> Sign In </Link>
        </div>
      </div>
      <div className="rightSide">
        <Link to="/"> Home </Link>
        <Link to="/shop"> Shop </Link>
        <Link to="/about"> About </Link>
        <Link to="/signin"> Sign In  </Link>
        <Cart
          
        />
      

        <button onClick={toggleNavbar}>
          <ReorderIcon />
        </button>
      </div>
      
    </div>
  );
}

export default Navbar;
