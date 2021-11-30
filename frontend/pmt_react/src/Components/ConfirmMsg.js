import React from 'react';


const ConfirmMsg =(props)=>{


    if(!props.message){
        return <span>Cannot Confirm The Project</span>
    }
    else
        return <span></span>
}

export default ConfirmMsg;