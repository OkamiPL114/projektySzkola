import './App.css';
import 'bootstrap/dist/css/bootstrap.css';
import React, {useState} from 'react';
import AddUser from './components/AddUser';
import Users from './components/Users';

function App() {
	const [users, setUsers] = useState([]);
	function addHandler(name, email, isValid){
		const newUser = {
			id: crypto.randomUUID(),
			name,
			email,
			isValid
		}
		setUsers(prevUsers => [...prevUsers, newUser])
	}
	return (
		<div className='m-3'>
			<h1>Użytkownicy</h1>
			<AddUser onAdd={addHandler}/>
			<Users users={users}/>
		</div>
	);
}

export default App;