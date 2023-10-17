import './Navigation.css';
import {NavLink} from 'react-router-dom';

export default function Navigation(){
    return(
        <>
            <NavLink to={'/home'} className="navItem">Strona główna</NavLink>
            <NavLink to={'/contact'} className="navItem">Kontakt</NavLink>
            <NavLink to={'/about'} className="navItem">O nas</NavLink>
        </>
    );
}