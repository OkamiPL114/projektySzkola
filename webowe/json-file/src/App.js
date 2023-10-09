import './App.css';
let users = require('./users.json');

function App() {
	return (
		<>
       		<h1>Użytkownicy</h1>
        	<div>
				{users.map(user => (
            	<div key={user.id} className={`user + ${user.age > 17 ? 'green' : 'red'}`}>
            		<p>{user.email}, {user.age} lat</p>
            		<p>Status {user.status ? "aktywny" : "nieaktywny"}</p>
          		</div>
        		))}
        	</div>
    	</>
	);
}

export default App;
