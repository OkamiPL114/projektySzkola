import React, {useState} from "react";
import EventsTest from "./components/EventsTest";
import Counter from "./components/Counter";
import "./App.css"
import Credits from "./components/Credits";

function App() {
    const [theme, setTheme] = useState("lightTheme");
    const [showCredits, setShowCredits] = useState(false);

    function changeThemeHandler() {
        if(theme === "lightTheme"){
            setTheme("darkTheme");
        }else {
            setTheme("lightTheme");
        }
    }

    function showCreditsHandler() {
        if(!showCredits){
            setShowCredits(true);
        }else {
            setShowCredits(false);
        }
    }

    return (
        <>
            <div className={theme}>
                <h1>Test</h1>
                {false && <EventsTest />} <br/> {/*renderowanie warunkowe*/}
                <Counter/> <br/> <br/>
                <button onClick={changeThemeHandler}>Przełącz motyw jasny/ciemny</button>
                <p>About</p>
                <button onClick={showCreditsHandler}>Credits</button>
                { showCredits && <Credits/>}
            </div>
        </>
    )
}

export default App;