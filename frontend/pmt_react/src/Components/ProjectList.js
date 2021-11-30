import React from 'react';

const ProjectList = (props)=>{

    const status = {
        1 : "Open",
        2 : "In Progress",
        3 : "Completed"
    }

    return (
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
                       props.projects.map(p=>(
                        <tr key={p.id}>
                            <td>{p.name}</td>
                            {/* <td>{p.supervisor_id}</td> */}
                            <td>{status[p.status]}</td>
                            <td>{p.created_at}</td>
                            <td>{ props.projectOptions(p.status,p.id) }</td>
                        </tr>
                    ))
                    }
                </tbody>
        </table>       
    );


}

export default ProjectList;