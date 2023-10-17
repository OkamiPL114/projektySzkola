import './App.css';
import {Route, Routes, Navigate} from 'react-router-dom';
import Home from './pages/Home';
import Contact from './pages/Contact';
import About from './pages/About';
import PageNotFound from './pages/PageNotFound';
import Navigation from './components/Navigation';

function App() {
    return (
		<>
			<Navigation/>
			<Routes>
				<Route path='/home' element={<Home/>}/>
				<Route path='/contact' element={<Contact/>}/>
				<Route path='/about' element={<About/>}/>

				{/* przekierowanie */}
				<Route path='/' element={<Navigate to={"/home"}/>}/>

				{/* 404 */}
				<Route path='*' element={<PageNotFound/>}/>
			</Routes>
		</>
    );
}

export default App;
