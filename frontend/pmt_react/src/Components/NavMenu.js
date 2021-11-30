import { Link } from "react-router-dom";



const NavMenu = ()=>{

    const id = 9;

    return(
        <div>
            <Link to="/create">Create</Link>{' '}
            {/* <Link to={`project/${id}`}>Product</Link> */}
            
        </div>
    );
}

export default NavMenu;