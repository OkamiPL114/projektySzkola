import React from "react";
import "./Products.css";
import Card from "../ui/Card";

export default function Products(props){
    return(
        <>
            {props.items.length === 0 && <h1>Brak ocenionych produktów</h1>}
            {props.items.length > 0 && props.items.map((item, index) => (
                <Card key={index}>
                    <h2>{item.name}</h2>
                    <p>Ocena: <b>{item.rating}</b></p>
                </Card>
            ))}
        </>
    );
};