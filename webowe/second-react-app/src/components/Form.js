import React from 'react'

function Form() {
    function changeHandler() {
        console.log("zmiana");
    }
    function submitHandler(evt) {
        evt.preventDefault();
        console.log("wysłano formularz");
    }
    return (
        <div>
            <form onSubmit={submitHandler}>
                <input type="number" onChange={changeHandler}/>
                <button type="submit">Dodaj</button>
            </form>
        </div>
    );
}

export default Form;