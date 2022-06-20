import React, { useState } from 'react';
import axios from 'axios';
import "./LogIn.css"
import { Redirect, Route } from 'react-router-dom';
import Register from './Register';



const LogIn = (props) => {
    const [user, setUser] = useState({ userName: "", password: "", rememberMe: false });
   
    const handleSubmit = () => {
        
        axios.post("api/Auth/Login", user).then(result => {
            //console.log(result);
            //var token = result.data.result.token;
            /*localStorage.setItem("user", JSON.stringify(token));*/
            console.log("abc");
            localStorage.setItem("user", result.data.result);
            /*return <Redirect to='/customerCreate' />*/
            props.history.replace('/customerCreate')

           
        })
    }

  
    const handleInputChange = (e) => {
            
            const { name, value } = e.target;
           
            const fieldsValue = { [name]: value };

            setUser({ ...user, ...fieldsValue });

           
    }

    //test
    const getCustomerData = () => {
        /*const token = JSON.parse(localStorage.getItem('user'));*/
        const token = localStorage.getItem('user');
        var base64Payload = token.split('.')[1];
        var payload = Buffer.from(base64Payload, 'base64');
        /*return JSON.parse(payload.toString());*/
        console.log(payload.toString())
        axios.get("api/customer", { headers: { Authorization: 'Bearer ' + token }  })
    }

    if (localStorage.getItem("user")) {
        return (
            <Register/>
            )
    }

    else {
        return (

            <div className="card ">

                <h3 style={{ textAlign: 'center' }}>Log In </h3>

                <div className="login-form">

                    <div className="form-group">
                        <input type="text" placeholder="userName" name="userName" className="form-control" onChange={handleInputChange} />
                    </div>
                    <div className="form-group">
                        <input type="password" placeholder="password" name="password" className="form-control" onChange={handleInputChange} />
                    </div>
                    <div className="form-group">
                        <input type="checkbox" id="rememberme" name="rememberMe" />
                        <label for="rememberme" style={{ marginLeft: "2px" }}> Remember me</label><br />
                    </div>
                    <button className="btn btn-success" onClick={handleSubmit} > Log in</button>
                </div>

                {/*<div>*/}
                {/*    <button className="btn btn-success" onClick={getCustomerData}>Get Customer</button>*/}
                {/*</div>*/}
            </div>


        )
    }
   
    
}

export default LogIn