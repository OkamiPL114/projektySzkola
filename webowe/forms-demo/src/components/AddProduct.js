import "./AddProduct.css";
import React, {useState} from "react";

export default function AddProduct(props){
    const [enteredName, setEnteredName] = useState("");
    const [enteredRating, setEnteredRating] = useState(3);

    function nameHandler(event){
        setEnteredName(event.target.value);
    };
    function ratingHandler(e){
        setEnteredRating(e.target.value);
    };
    function submitHandler(e){
        e.preventDefault(); //zapobieganie odświerzeniu strony po wysłaniu formularza
        if(enteredName.trim().length === 0) return;
        
        props.onAdd(enteredName, enteredRating);
        setEnteredName("");
        setEnteredRating(3);
    };
    return(
        <>
            <h1>Dodaj nowy produkt</h1>
            <form onSubmit={submitHandler}>
                <div>
                    <label htmlFor="name">Nazwa</label> &nbsp;
                    <input type="text" id="name" placeholder="nazwa" value={enteredName} onChange={nameHandler}/>
                    <br/> <br/>
                    <label htmlFor="rating">Ocena</label> &nbsp;
                    <input type="number" id="rating" value={enteredRating} placeholder="ocena (1-5)" min={1} max={5} onChange={ratingHandler}/>
                    <br/> <br/>
                    <button type="submit">Dodaj</button>
                </div>
            </form>
        </>
    );
};