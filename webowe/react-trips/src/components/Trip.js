import "./Trip.css";

function Trip(props){
    let heartsRating = "";
    for(let i = 0; i < props.trip.rating; i++){
        heartsRating += "❤";
    }

    return(
        <div className="trip">
            <h2>{props.trip.location}</h2>
            <p>budżet: <b>{props.trip.budget}zł</b></p>
            <br/>
            <p>Czas pobytu w dniach: <b>{props.trip.days}</b></p>
            <br/>
            <p>Ocena: <span className="redColor">{heartsRating}</span></p>
            {heartsRating = ""}
            <form onSubmit={props.onDelete}>
                <input type="hidden" value={props.trip.id}/>
                <button type="submit">Usuń</button>
            </form>
        </div>
    );
}

export default Trip;