import React from "react";
import { useParams } from "react-router";


const Project = ()=>{

    const {id} = useParams();
    return <h1>View Project {id}</h1>
}

export default Project;