import "./Posts.css";
import photos from "../obrazy.json";

export default function Posts(props){
    return(
        <div>
            {props.posts.map((photo, index) => (
                <div className="post" key={index}>
                    <div className="leftPart">
                        <img id="photo" alt="zdjęcie z posta"/>
                        <label htmlFor="photo">{photo.author}</label>
                    </div>
                    <div className="middlePart">
                        <label>{photo.description}</label>
                    </div>
                    <div className="rightPart">
                        <label>{photo.dateAdded}</label>
                    </div>
                </div>
            ))}
        </div>
    );
}