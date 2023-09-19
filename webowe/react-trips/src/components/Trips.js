import "./Trips.css";
import Trip from "./Trip"

function Trips(props){
    function onDeleteHandler(idToDelete){
        props.onDelete(idToDelete);
    }
    return(
        <>
            <h1>Lista wycieczek</h1>
            {props.trips.length === 0 && <h2>Brak wycieczek</h2>}
            {props.trips.length > 0 &&  
            <div>    
                {props.trips.map(trip => (
                    <Trip key={trip.id} trip={trip} onDelete={onDeleteHandler}/>
                ))}
            </div>
            }
        </>
    );
}

export default Trips;