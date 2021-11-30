import axios from 'axios';
import { useState, useEffect } from 'react';
import { Link, Switch, Route } from 'react-router-dom';
import ConfirmMsg from './ConfirmMsg';
import ProjectDetails from './ProjectDetails';
import ProjectList from './ProjectList';
//import { Link } from 'react-router-dom';


const Home = ()=>{
    const[projects,setProjects] = useState([]);
    const[confirmed,setConfirmed] = useState(true);
   // const[status,setStatus] = useState(1);
    useEffect(
        ()=>{

            axios.get('https://localhost:44397/api/project/All')
            .then(
                resp=>setProjects(resp.data)
            )
            .catch(
                e=>console.log(e)
            )

        }, [projects]
    );

    function Confirm(id){
        axios.get('https://localhost:44397/api/project/confirm',{params: {id:id}})
        .then(
            resp=>{
                console.log("Resp confirm: "+resp.data);
                setConfirmed(resp.data);
            }
        )
        .catch(
            e=>console.log("Error-custom: "+ e)
        )
        //console.log('Button Clicked---- '+id);

        
    }

    function Complete(id){
        axios.get('https://localhost:44397/api/project/complete',{params: {id:id}})
        .then(
            resp=>console.log("Resp complete: "+resp.data)
        )
        .catch(
            e=>console.log("Error-custom: "+ e)
        )
        //console.log('Button Clicked---- '+id);
    }

    const projectOptions=(p,id)=>{
        if(p==1){
            return <button onClick={()=>{Confirm(id)}}>Confirm</button>
        }
        else if(p==2){
            return( <div>
                <button onClick={()=>Complete(id)}>Complete</button>{' '}
               <Link to={`/project/${id}`}><button>Details</button></Link>
            </div>)
        }
        else{
            return;
        }

    }

    return(
        <div>
             <h1>This is Home Page</h1>
            <h1>.....View projects.....</h1>
            <ConfirmMsg message={confirmed} />
            <ProjectList projects={projects}  projectOptions={projectOptions} />
        </div>
    );
}

//checkStatus(p.status,p.id)

export default Home;