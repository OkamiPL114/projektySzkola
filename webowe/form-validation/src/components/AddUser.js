import './AddUser.css';
import React, {useState, useEffect} from 'react';

export default function AddUser(props){
    const [name, setName] = useState("");
    const [email, setEmail] = useState("");
    const [nameClasses, setNameClasses] = useState("form-control");
    const [emailClasses, setEmailClasses] = useState("form-control");
    function nameChangedHandler(event){
        setName(event.target.value);
    }
    function emailChangedHandler(event){
        setEmail(event.target.value);
    }
    function submitHandler(event){
        event.preventDefault();
        props.onAdd(name, email, (isValidName() && isValidEmail()));
        setName("");
        setEmail("");
    }

    function isValidName(){
        if(name.length < 2 || name[0] !== name[0].toUpperCase()){
            return false;
        }
        return true;
    }
    function isValidEmail(){
        if(email.length < 7){
            return false;
        }
        let atSigns = 0;
        for(let i = 0; i < email.length; i++){
            if(email[i] === "@"){
                atSigns++;
            }
        }
        if(atSigns !== 1){
            return false;
        }
        return true;
    }
    useEffect(() => {
        if(name.length !== 0){
            if(isValidName()){
                setNameClasses("form-control valid");
            }
            else {
                setNameClasses("form-control invalid");
            }
        }
    }, [name]);
    useEffect(() => {
        if(email.length !== 0){
            if(isValidEmail()){
                setEmailClasses("form-control valid");
            }
            else {
                setEmailClasses("form-control invalid");
            }
        }
    }, [email]);
    return(
        <>
            <form className='m-2 userForm' onSubmit={submitHandler}>
                <div className='mb-3'>
                    <label htmlFor='userName' className='form-label'>Imię: </label>
                    <input required type='text' className={nameClasses} id='userName' value={name} onChange={nameChangedHandler}/>
                </div>
                <div className='mb-3'>
                    <label htmlFor='userEmail' className='form-label'>Email: </label>
                    <input required type='text' className={emailClasses} id='userEmail' value={email} onChange={emailChangedHandler}/>
                </div>
                <button type='submit' className='btn btn-primary'>Dodaj</button>
            </form>
        </>
    );
}