// import React ,{Component} from "react";
import React  from "react";
import './Person.css';

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
    return ( 
    <div className="Person">
    <p   onClick={props.click}>Welcome. {props.name} is {props.age} year old</p>
    <h3  >{props.children}</h3> 
    <input type="text" onChange={props.changed}></input>
    </div>
    );

};
export default Person;