import "./App.css"
import Header from './components/Header.jsx';
import Main from "./components/Main";
import Footer from "./components/Footer";

function App() {
	const employees = ["Adam", "Joanna", "Hubert", "Edward", "Ewa"];

	return (
		<>
			<Header/>
			<Main users={employees}/>
			<Footer/>
		</>
	);
}
export default App;