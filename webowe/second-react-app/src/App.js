import Header from "./components/Header";
import Content from "./components/Content";
import Footer from "./components/Footer";
import Card from "./ui/Card";
import Form from "./components/Form";

function App() {
	const headerText = "Witaj w React";
	const msg = "To jest zwykły tekst w HTML";
	return (
		<>
			<Header myText={headerText}/>
			<Card>
				<Content/>
			</Card>
			<Card>
				<p>{msg}</p>
			</Card>
			<Form/>
			<Footer/>
		</>
  	);
}

export default App;