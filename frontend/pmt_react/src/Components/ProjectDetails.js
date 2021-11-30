import React from 'react';
import { useParams } from 'react-router';
import ProjectList from './ProjectList';


const ProjectDetails = ()=>{

    let {id} = useParams();
   
    return(
        <>
            {/* {console.log("Pamar id : "+id)} */}
            <h1>Product Id {id}</h1>
        </>
    );

}

export default ProjectDetails;