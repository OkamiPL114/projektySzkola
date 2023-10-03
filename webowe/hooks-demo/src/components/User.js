import "./User.css";

export default function User(props){
    function deleteHandler(event){
        event.preventDefault();
        props.onDelete(props.data.id);
    }
    return(
        <div className="card">
            <h3>{props.data.firstName} {props.data.lastName}</h3>
            <p>{props.data.email}</p>
            <form onSubmit={deleteHandler}>
                <input type="hidden" value={props.data.id}/>
                <button type="submit">Usuń</button>
            </form>
        </div>
    );
}