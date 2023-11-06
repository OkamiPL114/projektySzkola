import "./NewPost.css";
import photos from "../obrazy.json";

export default function NewPost(){
    console.log(photos);
    return(
        <div className="newPost">
            <form>
                <div>
                    <div>
                        <textarea></textarea>
                    </div>
                    <div>
                        <label htmlFor="author">Imię</label> <br/>
                        <input type="text" id="author"/> <br/>
                        <p>Wybrana grafika</p>
                        <p>Obraz 1</p>
                    </div>
                    <div>
                        <img alt="wybrany obraz"/>
                    </div>
                </div>
                <div className="cards">
                    {photos.map((photo, index) => (
                        <div key={index} className="card">
                            <img src={photo.adres} className="cardImg"/>
                            <p>{photo.tytul}</p>
                            <button>Wybierz</button>
                        </div>
                    ))}
                </div>
            </form>
        </div>
    );
}