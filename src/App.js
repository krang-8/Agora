import "./App.css";
import Navbar from "./components/Navbar";
import Footer from "./components/Footer";
import Home from "./pages/Home";
import Shop from "./pages/Shop";
import About from "./pages/About";
import SignIn from "./pages/SignIn";
import SellerControl from "./pages/SellerControl";
import Cart from "./pages/Cart"
import UpdateItem from "./pages/UpdateItem"
import UpdateStock from "./pages/UpdateStock"
import AddNewItem from "./pages/AddNewItem"
import { BrowserRouter as Router, Route, Switch } from "react-router-dom";
import Admin from "./pages/Admin"
import AdminCustomer from "./pages/AdminCustomer";
import AdminSeller from "./pages/AdminSeller";
import AdminItems from "./pages/AdminItems";


function App() {
  return (
    <div className="App">
      <Router>
        <Navbar />
        <Switch>
          <Route path="/" exact component={Home} />
          <Route path="/shop" exact component={Shop} />
          <Route path="/about" exact component={About} />
          <Route path="/signin" exact component={SignIn} />
          <Route path="/additems" exact component={SellerControl} />
          <Route path="/cart" exact component={Cart}/>
          <Route path="/updateitem" exact component={UpdateItem}/>
          <Route path="/updatestock" exact component={UpdateStock}/>
          <Route path="/addnewitem" exact component={AddNewItem}/>
          <Route path="/admin" exact component={Admin}/>
          <Route path="/admin/customer" exact component={AdminCustomer}/>
          <Route path="/admin/seller" exact component={AdminSeller}/>
          <Route path="/admin/items" exact component={AdminItems}/>
        </Switch>
        <Footer />
      </Router>
    </div>
  );
}

export default App;
