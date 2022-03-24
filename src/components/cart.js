import React, { useRef } from "react";
import cartICON from "../assets/shopping-cart.png"
import OnClickOut from "../hooks/onClickOut";
import {
    Wrapper,
    Icon,
    CartCount,
    CartSideBar,
    EmptyCart,
    SideBarHeader,
    Card,
    CardBody,
    CardImage,
    CardTitle,
    CardRemove,
    CardRow,
    ClearButton,
  } from "../styles/cartStyle";
export default function Cart({
    isToggle,
    setToggle,
    carts,
    removeProductFromCart,
    clearCart,
  }) {
    const $sideBarRef = useRef();
  
    // # handle the onclick outside
    OnClickOut($sideBarRef, () => setToggle(false));
  
    console.log(carts);
  
    return (
      <>
        <Wrapper onClick={() => setToggle(true)}>
          <Icon icon={cartICON} />
          <CartCount>{carts.length}</CartCount>
        </Wrapper>
  
        <CartSideBar ref={$sideBarRef} className={isToggle ? "expand" : "shrink"}>
          <SideBarHeader>shopping cart</SideBarHeader>

        </CartSideBar>
      </>
    );
  }