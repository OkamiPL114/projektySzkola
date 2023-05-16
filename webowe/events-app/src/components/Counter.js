import { useState } from "react"; //useState - hook stanu
import "./Counter.css"

function Counter() {
    const [count, setCount] = useState(0); //0 - wartość początkowa stanu                                  
    function decreaseClickHandler() {
        setCount(previousCount => { return previousCount - 1});
    }
    function increaseClickHandler() {
        setCount(prevCount => prevCount + 1);
    }

    return (
        <>
            <p>Licznik kliknięć</p>
            <button onClick={decreaseClickHandler}> - </button> <br/>
            {count} <br/>
            <button onClick={increaseClickHandler}> + </button> <br/>
        </>
    )
}

export default Counter;