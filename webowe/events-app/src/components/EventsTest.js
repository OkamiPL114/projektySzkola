import "./EventsTest.css";

function showAlertHandler() {
    alert("naciśnięto przycisk");
}

function nameChangeHandler() {
    console.log("zmieniono pole imię");
}

function lastnameFocusHandler() {
    alert("pole nazwisko stało się aktywne");
}

function lastnameBlurHandler() {
    alert("pole nazwisko przestało być aktywne");
}

function EventsTest() {
    return (
        <>
            <h2>Demo zdarzeń</h2>
            Imię: <input type="text" onChange={nameChangeHandler}/> <br/> <br/>
            Nazwisko: <input type="text" onFocus={lastnameFocusHandler} onBlur={lastnameBlurHandler}/> <br/> <br/>
            Wiek: <input type="number" /> <br/> <br/>
            <button onClick={showAlertHandler}>Pokaż okno</button> <br/>
        </>
    )
}

export default EventsTest;