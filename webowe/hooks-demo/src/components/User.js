import "./User.css";

export default function User(props){
    return(
        <div className="card">
            <h3>{props.data.firstName} {props.data.lastName}</h3>
            <p>{props.data.email}</p>
        </div>
    );
}