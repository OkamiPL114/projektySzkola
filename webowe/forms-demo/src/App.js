import "./App.css";
import AddProduct from "./components/AddProduct";
import Products from "./components/Products";
import React, {useState} from "react";

export default function App(){
	const [products, setProducts] = useState([{name: "rower", rating: 5}]);
	function addHandler(enteredName, enteredRating){
		setProducts(prevProducts => [...products, {name: enteredName, rating: enteredRating}]);
	};
	return(
		<div>
			<AddProduct onAdd={addHandler}/>
			<hr/>
			<Products items={products}/>
		</div>
	);
};