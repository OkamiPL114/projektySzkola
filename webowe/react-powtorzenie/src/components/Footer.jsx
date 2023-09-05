import "./Footer.css"

function Footer() {
    const year = new Date().getFullYear();
    const author = "Kapitan Pazur";
    return(
        <footer>
            <p>created by {author}, {year}</p>
        </footer>
    );
}
export default Footer;