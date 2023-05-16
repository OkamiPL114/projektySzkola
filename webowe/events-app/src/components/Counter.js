import { useState } from "react"; //useState - hook stanu
import "./Counter.css"

function Counter() {
    const [count,setCount] = useState(0); //0 - wartość początkowa stanu                                  
    function decreaseClickHandler() {
        setCount(count-1);
    }
    function increaseClickHandler() {
        setCount(count+1);
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