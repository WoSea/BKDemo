import React ,{Component} from "react";

// const Person = ()=>{
//     return ( <p>Can put your code here. I am {Math.floor(Math.random()*30)} year old</p>
//     );
// }

class Person extends Component{
    render(){
        return ( <p>Can put your code here. I am {Math.floor(Math.random()*30)} year old</p>
        );
    }
}

export default Person;