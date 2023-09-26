import React, {useState} from "react";
import './App.css';
import AddUser from './components/AddUser';
import Users from "./components/Users";

function App() {
	let firstUser = {
		id: crypto.randomUUID(),
		firstName: "Ewa",
		lastName: "Nowak",
		email: "ewa.nowak@gmail.com"
	}
	const [users, setUsers] = useState([firstUser]);
    function addHandler(newUser){
		setUsers(prevUsers => [...prevUsers, {id:crypto.randomUUID(), ...newUser}]);
	}
	return (
        <>
			<h1>Baza użytkowników</h1>
			<AddUser onAdd={addHandler}/>
			<Users users={users}/>
        </>
    );
}

export default App;
