import React, { useState } from "react";
import Logo from "../assets/AGORA.png";
import CartIcon from "../assets/carticon.png"
import { Link } from "react-router-dom";
import ReorderIcon from "@material-ui/icons/Reorder";
import "../styles/Navbar.css";
import 'react-dropdown/style.css';

function Navbar() {
  const [openLinks, setOpenLinks] = useState(false);

  const toggleNavbar = () => {
    setOpenLinks(!openLinks);
  };


  return (
    <div className="navbar">
      <div className="leftSide" id={openLinks ? "open" : "close"}>
        <Link to="/"><img src={Logo} /></Link>
        <div className="hiddenLinks">
          <Link to="/"> Home </Link>
          <Link to="/shop"> Shop </Link>
          <Link to="/about"> About </Link>
          <Link to="/signin"> Sign In </Link>
          <Link to="/cart"><img src={CartIcon} /></Link>
        </div>
      </div>
      <div className="rightSide">
        <Link to="/"> Home </Link>
        <Link to="/shop"> Shop </Link>
        <Link to="/about"> About </Link>
        <Link to="/signin"> Sign In  </Link>
        <Link to="/cart"><img src={CartIcon} /></Link>
        <button onClick={toggleNavbar}>
          <ReorderIcon />
        </button>
      </div>
    </div>
  );
}

export default Navbar;
