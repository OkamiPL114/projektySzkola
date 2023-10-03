import React, {useState} from "react";
import "./AddUser.css"

export default function AddUser(props){
    const [firstName, setFirstName] = useState("");
    const [lastName, setLastName] = useState("");
    const [email, setEmail] = useState("");
    function firstNameHandler(event){
        setFirstName(event.target.value);
    }
    function lastNameHandler(event){
        setLastName(event.target.value);
    }
    function emailHandler(event){
        setEmail(event.target.value);
    }
    function submitHandler(event){
        event.preventDefault();
        let newUser = {
            firstName: firstName,
            lastName: lastName,
            email: email
        }
        props.onAdd(newUser);
    }
    return (
        <>
            <h2>Nowy użytkownik</h2>
            <form onSubmit={submitHandler}>
                Imię: <input type="text" value={firstName} onChange={firstNameHandler}/> <br/> <br/>
                Nazwisko: <input type="text" value={lastName} onChange={lastNameHandler}/> <br/> <br/>
                Email: <input type="email" value={email} onChange={emailHandler}/> <br/> <br/>
                <button type="submit">Dodaj</button> <br/>
            </form>
        </>
    )
}