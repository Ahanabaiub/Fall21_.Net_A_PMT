import axios from 'axios';
import { useState, useEffect } from 'react';


const Home = ()=>{
    const[projects,setProjects] = useState([]);

    useEffect(
        ()=>{

            axios.get('https://localhost:44397/api/project/All')
            .then(
                resp=>setProjects(resp.data)
            )
            .catch(
                e=>console.log(e)
            )

        }, []
    );

    return(
        <div>
            <h1>.....View projects.....</h1>
            
            <table>
                <thead>
                  <tr>
                        <th>Name</th>
                        <th>Supervisor</th>
                        <th>Status</th>
                        <th>Created At :</th>
                  </tr>
                </thead>
                <tbody>
                    {
                       projects.map(p=>(
                        <tr key={p.id}>
                            <td>{p.name}</td>
                            <td>{p.supervisor_id}</td>
                            <td>{p.status}</td>
                            <td>{p.created_at}</td>
                        </tr>
                    ))
                    }
                </tbody>
            </table>
        </div>
    );
}

export default Home;