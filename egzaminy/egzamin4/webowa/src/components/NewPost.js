import "./NewPost.css";
import photos from "../obrazy.json";
import React, {useState} from 'react';

export default function NewPost(props){
    const [description, setDescription] = useState("");
    const [name, setName] = useState("");
    const [selectedImage, setSelectedImage] = useState(1);

    function selectImage(event){
        event.preventDefault();
        let arg = event.target.getAttribute('data-arg'); /* tak nie można!!!!!!!!!!!!!!!!! */
        setSelectedImage(parseInt(arg) + 1);
    }

    function descriptionChanged(event){
        setDescription(event.target.value);
    }
    function nameChanged(event){
        setName(event.target.value);
    }

    function submitHandler(event){
        event.preventDefault();
        if(description.trim().length === 0 || name.trim().length === 0){
            return;
        }
        let newPost = {
            author: name,
            description: description,
            dateAdded: Date.now,
            image: selectedImage
        }
        props.addNewPost(newPost);
        setDescription("");
        setName("");
        setSelectedImage(1);
    }
    return(
        <div className={`newPost ${props.isVisible ? "visible" : "invisible"}`}>
            <form onSubmit={submitHandler}>
                <div className="addNewPost">
                    <div className="description">
                        <textarea rows={7} cols={35} onChange={descriptionChanged} value={description}></textarea>
                    </div>
                    <div className="author">
                        <label htmlFor="author">Imię</label> <br/>
                        <input type="text" id="author" onChange={nameChanged} value={name}/> <br/>
                        <button type="submit">Dodaj post</button>
                        <p>Wybrana grafika</p>
                        <p>Obraz {selectedImage}</p>
                    </div>
                    <div>
                        <img src={photos.find(photo => photo.tytul === `Obraz ${selectedImage}`).adres} alt="wybrany obraz" className="selectedImage"/>
                    </div>
                </div>
                <div className="cards">
                    {photos.map((photo, index) => (
                        <div key={index} id={`photo${index}`} className="card">
                            <img src={photo.adres} className="cardImg" alt="zdjęcie"/>
                            <p>{photo.tytul}</p>
                            <button onClick={selectImage} data-arg={index}>Wybierz</button> {/* zrób to na formularzach!!!!!!!!! */}
                        </div>
                    ))}
                </div>
            </form>
        </div>
    );
}