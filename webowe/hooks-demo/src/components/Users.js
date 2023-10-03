import User from "./User";
import "./Users.css";

export default function Users(props){
    function deleteHadnler(id){
        props.onDelete(id);
    }
    return(
        <div>
            {props.users.map(user => (
                <User key={user.id} data={user} onDelete={deleteHadnler}/>
            ))}
        </div>
    );
}