import React, {useState, useEffect} from "react";
import './App.css';
import AddUser from './components/AddUser';
import Users from "./components/Users";

function App() {
	let defaultUsers = [
		{
			id: crypto.randomUUID(),
			firstName: "Ewa",
			lastName: "Nowak",
			email: "ewa.nowak@gmail.com"
		},
		{
			id: crypto.randomUUID(),
			firstName: "Jan",
			lastName: "Kowalski",
			email: "jan.kowalski@gmail.com"
		},
		{
			id: crypto.randomUUID(),
			firstName: "Paweł",
			lastName: "Zelewski",
			email: "pawel.zalewski@gmail.com"
		}
	];

	const [users, setUsers] = useState(defaultUsers);
	const [enteredEmail, setEnteredEmail] = useState("");
	const [filteredUsers, setFilteredUsers] = useState(defaultUsers);
    
	function addHandler(newUser){
		setUsers(prevUsers => [...prevUsers, {id:crypto.randomUUID(), ...newUser}]);
	}

	function filterEmailHandler(event){
		setEnteredEmail(event.target.value);
	}
	useEffect(() => {
		if(enteredEmail.trim().length > 0){
			setFilteredUsers(users.filter((user) => user.email.includes(enteredEmail.trim())));
		}
		else{
			setFilteredUsers(users);
		}
	}, [enteredEmail, users]);

	function deleteHandler(id){
		setUsers(prevUsers => prevUsers.filter(user => user.id !== id));
	}
	return (
        <>
			<h1>Baza użytkowników</h1>
			<AddUser onAdd={addHandler}/>
			<p>
				Filtruj po email-u: &nbsp;
				<input type="text" value={enteredEmail} onChange={filterEmailHandler}/>
			</p>
			{users.length === 0 && <h2>Brak użytkowników</h2>}
			{users.length > 0 && <Users users={filteredUsers} onDelete={deleteHandler}/>}
        </>
    );
}

export default App;
