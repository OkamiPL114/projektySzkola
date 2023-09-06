import "./HorizontalNav.css";

export default function HorizontalNav(props){
    return(
        <nav>
            {props.links.map((link, index) => (
                <span key={index}>
                    &nbsp; &nbsp; &nbsp;
                    <a href="#"> {link} </a>
                </span>
            ))}
        </nav>
    );
}