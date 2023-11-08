import "./Posts.css";
import photos from "../obrazy.json";

export default function Posts(props){
    return(
        <div>
            {props.posts.map((post, index) => (
                <div className="post" key={index}>
                    <div className="postLeft">
                        <img src={photos.find(photo => photo.tytul === `Obraz ${post.image}`).adres} id="photo" className="postImage" alt="zdjęcie z posta"/>
                        <label htmlFor="photo">{post.author}</label>
                    </div>
                    <div className="postMiddle">
                        <label className="postMiddleText">{post.description}</label>
                    </div>
                    <div className="postRight">
                        <label>abc{post.dateAdded}</label>
                    </div>
                </div>
            ))}
        </div>
    );
}