import React, {useState} from "react";
import "./Main.css"
import Card from "../ui/Card";

function Main(props) {
    const [grade, setGrade] = useState(5);
    
    function decreaseGradeHandler(){
        if(grade == 1) return;
        setGrade(previousGrade => previousGrade - 0.5);
    }
    function increaseGradeHandler(){
        if(grade == 5) return;
        setGrade(previousGrade => previousGrade + 0.5);
    }

    return(
        <main>
            <h1>Witojcie no stronce</h1>
            <div>
                Oceńta pan mnie te strone: <br />
                <button onClick={decreaseGradeHandler}>&#8681;</button>
                <span>{grade}</span>
                <button onClick={increaseGradeHandler}>&#8679;</button>
            </div>

            <h1>Nasz team:</h1>
            {props.users.map((user, index) => <Card key={index}>{user}</Card>)}
        </main>
    );
}
export default Main;