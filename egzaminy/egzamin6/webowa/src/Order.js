import "./Order.css";

export default function Order(){
    return(
        <div>
            <h2>Twoje zamówienie</h2>
            <hr/>
            <p>Suma: 0zł</p>
            <form>
                <button type="submit">Wyczyść zamówienie</button>
            </form>
        </div>
    );
}