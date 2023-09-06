import "./VerticalNav.css";

export default function VerticalNav(props){
    return(
        <nav>
            {props.links.map((link, index) => (
                <span key={index}>
                    &nbsp; &nbsp; &nbsp;
                    <a href="#"> {link} </a>
                    <br/>
                </span>
            ))}
        </nav>
    );
}