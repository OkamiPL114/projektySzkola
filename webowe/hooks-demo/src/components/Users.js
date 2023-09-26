import User from "./User";
import "./Users.css";
import React, {useState, useEffect} from "react";

export default function Users(props){
    const [filteredUsers, setFilteredUsers] = useState(props.users);
    const [enteredEmail, setEnteredEmail] = useState("");
    
    function filterHandler(event){
        setEnteredEmail(event.target.value);
    }

    useEffect(() => {
        setFilteredUsers(prevUsers => prevUsers.filter(user => user.email.includes(enteredEmail)));
    }, [enteredEmail]);

    return(
        <>
            <form>
                <input type="text" onChange={filterHandler} value={""}/>
            </form>
            {filteredUsers.map(user => (
                <User key={user.id} data={user}/>
            ))}
        </>
    );
}