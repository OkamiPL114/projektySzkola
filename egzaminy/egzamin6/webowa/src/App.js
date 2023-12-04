import './App.css';
import Dishes from './Dishes';
import Order from './Order';

function App() {
  	return (
		<div className='restaurant'>
			<h1 className='title'>Restauracja "Programista"</h1>
			<div className='dishes'><Dishes/></div>
			<div className='order'><Order/></div>
		</div>
  	);
}

export default App;