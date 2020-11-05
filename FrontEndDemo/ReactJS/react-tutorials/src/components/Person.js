import React ,{Component} from "react";

const Person = (props)=>{
    return ( 
    <div>
    <p onClick={props.click}>Welcome. {props.name} is {props.age} year old</p>
    <h3>{props.children}</h3>
    </div>
    );

}

// class Person extends Component{
//     render(){
//         return ( <p>Can put your code here. I am {Math.floor(Math.random()*30)} year old</p>
//         );
//     }
// }

export default Person;