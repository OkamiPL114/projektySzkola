import './App.css';
import 'bootstrap/dist/css/bootstrap.css';
import React, {useState} from 'react';

function App() {
	const kursy = ["Programowanie w C#", "Angular dla początkujących", "Kurs Django"];
  	const [daneOsobowe, setDaneOsobowe] = useState("");
  	const [nrKursu, setNrKursu] = useState("");
	
	function daneOsoboweHandler(event){
		setDaneOsobowe(event.target.value);
	}
	function nrKursuHandler(event){
		setNrKursu(event.target.value);
	}
	function zapiszHandler(event){
		event.preventDefault();
		console.log(daneOsobowe);
		if(nrKursu > 0 && nrKursu < kursy.length + 1){
			console.log(kursy[nrKursu-1]);
		}
		else{
			console.log("Nieprawidłowy numer kursu");
		}
	}
	return (
       	<div className='app'>
			<h2>Liczba kursów: {kursy.length}</h2>
			<ol>
				{kursy.map((kurs, index) => (
					<li key={index}>{kurs}</li>
				))}
			</ol>
			<form onSubmit={zapiszHandler}>
				<div className='form-group'>
					<label htmlFor='imieNazwisko' className='controls'>Imię i nazwisko</label>
					<input type='text' className='form-control' id='imieNazwisko' value={daneOsobowe} onChange={daneOsoboweHandler}/>
				</div>
				<div className='form-group'>
					<label htmlFor='numerKursu' className='controls'>Numer kursu</label>
					<input type='number' className='form-control' id='numerKursu' value={nrKursu} onChange={nrKursuHandler}/>
				</div>
				<button type='submit' className='btn btn-primary btn-margin'>Zapisz do kursu</button>
			</form>
		</div>
  	);
}

export default App;
