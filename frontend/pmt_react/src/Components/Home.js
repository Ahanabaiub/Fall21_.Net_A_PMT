import axios from 'axios';
import { useState, useEffect } from 'react';
//import { Link } from 'react-router-dom';


const Home = ()=>{
    const[projects,setProjects] = useState([]);
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

    const status = {
        1 : "Open",
        2 : "In Progress",
        3 : "Completed"
    }

    function Confirm(id){
        axios.get('https://localhost:44397/api/project/confirm',{params: {id:id}})
        .then(
            resp=>console.log("Resp : "+resp.data)
        )
        .catch(
            e=>console.log("Error-custom: "+ e)
        )
        //console.log('Button Clicked---- '+id);
    }

    function Complete(id){
        axios.get('https://localhost:44397/api/project/complete',{params: {id:id}})
        .then(
            resp=>console.log("Resp : "+resp.data)
        )
        .catch(
            e=>console.log("Error-custom: "+ e)
        )
        //console.log('Button Clicked---- '+id);
    }

    const checkStatus=(p,id)=>{
        if(p==1){
            return <button onClick={()=>Confirm(id)}>Confirm</button>
        }
        else if(p==2){
            return <div>
                <button onClick={()=>Complete(id)}>Complete</button>{' '}
                <button onClick={()=>console.log("view members clicked")}>Members</button>
            </div>
        }
        else{
            return "";
        }

    }

    return(
        <div>
             <h1>This is Home Page</h1>
            <h1>.....View projects.....</h1>
            
            <table>
                <thead>
                  <tr>
                        <th>Name</th>
                        {/* <th>Supervisor</th> */}
                        <th>Status</th>
                        <th>Created-At </th>
                        <th>Option</th>
                  </tr>
                </thead>
                <tbody>
                    {
                       projects.map(p=>(
                        <tr key={p.id}>
                            <td>{p.name}</td>
                            {/* <td>{p.supervisor_id}</td> */}
                            <td>{status[p.status]}</td>
                            <td>{p.created_at}</td>
                            <td>{ checkStatus(p.status,p.id) }</td>
                        </tr>
                    ))
                    }
                </tbody>
            </table>
        </div>
    );
}

//checkStatus(p.status,p.id)

export default Home;