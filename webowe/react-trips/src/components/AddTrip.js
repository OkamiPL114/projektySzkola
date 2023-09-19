import React, {useState} from "react";
import "./AddTrip.css";

export default function AddTrip(props){
    const [location, setLocation] = useState("");
    const [budget, setBudget] = useState(0);
    const [days, setDays] = useState(0);
    const [rating, setRating] = useState(0);

    function locationHandler(event){
        setLocation(event.target.value);
    }
    function budgetHandler(event){
        setBudget(event.target.value);
    }
    function daysHandler(event){
        setDays(event.target.value);
    }
    function ratingHandler(event){
        setRating(event.target.value);
    }

    function submitHandler(event){
        event.preventDefault();
        if(location.trim().length < 3) return;
        if(budget < 0) return;
        if(days < 1) return;
        if(rating < 1 || rating > 5) return;
        
        const newTrip = {
            location: location,
            budget: budget,
            days: days,
            rating: rating,
        };
        props.onAdd(newTrip);
        setLocation("");
        setRating(0);
        setDays(0);
        setRating(0);
    }
    return(
        <div className="form">
            <img src="./img/trip.jpg" alt="obraz"/>
            <h1>Dodaj nową wycieczkę</h1>
            <form onSubmit={submitHandler}>
                Lokacja: <input type="text" value={location} onChange={locationHandler}/> <br/> <br/>
                Budżet: <input type="number" value={budget} onChange={budgetHandler}/> <br/> <br/>
                Czas pobytu w dniach: <input type="number" value={days} onChange={daysHandler}/> <br/> <br/>
                Ocena (od 1 do 5): <input type="number" min={1} max={5} value={rating} onChange={ratingHandler}/> <br/> <br/>
                <button type="submit">Dodaj</button>
            </form>
        </div>
    );
}