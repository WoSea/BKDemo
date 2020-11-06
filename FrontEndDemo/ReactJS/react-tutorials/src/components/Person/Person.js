// import React ,{Component} from "react";
import React  from "react";
import './Person.css';
import Radium from 'radium';

// const Person = (props)=>{
//     return ( 
//     <div className="Person">
//     <p onClick={props.click}>Welcome. {props.name} is {props.age} year old</p>
//     <h3>{props.children}</h3> 
//     <input type="text" onChange={props.changed}></input>
//     </div>
//     );

// }

// class Person extends Component{
//     render(){
//         return ( <p>Can put your code here. I am {Math.floor(Math.random()*30)} year old</p>
//         );
//     }
// }
const Person = (props)=>{ 

    const styles={
        '@media(min-width:500)':{
            width:'450px',
        }
    }
    return ( 
    <div className="Person" style={styles}>
    <p   onClick={props.click}>Welcome. {props.name} is {props.age} year old</p>
    <h3  >{props.children}</h3> 
    <input type="text" onChange={props.changed}></input>
    </div>
    );

};
export default Radium(Person);