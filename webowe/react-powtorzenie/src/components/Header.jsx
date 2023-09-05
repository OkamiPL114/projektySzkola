import "./Header.css"
import Smile from '../assets/smile.png'

function Header() {
    return(
        <header>
            <h1>Powtórka z Reacta</h1>
            <img src={Smile} alt="uśmieszek" className="logo"/>
        </header>
    );
}
export default Header;