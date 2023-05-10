import "./Header.css";

function Header(props) {
    return (
        <h1 className="header">{props.myText}</h1>
    );
}

export default Header;