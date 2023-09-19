import React, {useState} from "react";
import './App.css';
import Trips from "./components/Trips";
import AddTrip from "./components/AddTrip";

function App() {
	const [trips, setTrips] = useState([{id: crypto.randomUUID(), location: "Kraków", budget: 110, days: 1, rating: 4}]);
	function addHandler(newTrip){
		setTrips(prevTrips => [...prevTrips, {id: crypto.randomUUID(), ...newTrip}]);
	}
	function deleteHandler(idToDelete){
		const newTrips = trips.filter(trip => trip.id !== idToDelete);
		setTrips(newTrips);
	}
	return (
		<>
			<AddTrip onAdd={addHandler}/>
			<Trips trips={trips} onDelete={deleteHandler}/>
		</>
	);
}

export default App;
