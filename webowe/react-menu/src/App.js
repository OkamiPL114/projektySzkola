import "./App.css";
import HorizontalNav from "./components/HorizontalNav";
import VerticalNav from "./components/VerticalNav";
import React, {useState} from "react";

function App(){
	const [toggleMenu, setToggleMenu] = useState(false);
	const navLinks = ["Home", "Ceny", "O nas", "Kontakt"];

	function toggleMenuHandler(){
		setToggleMenu(prevState => !prevState);
	}
	return(
		<>
			{!toggleMenu && <HorizontalNav links={navLinks}/>}
			<button onClick={toggleMenuHandler}>Menu</button>
			<div>
				{toggleMenu && <VerticalNav links={navLinks}/>}
				<main>
					zawartość
				</main>
			</div>
		</>
	);
}

export default App;