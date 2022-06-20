import React, { useState } from 'react';
import axios from 'axios';
import "./LogIn.css"



const Register = () => {
    const [registeredUser, setRegisteredUser] = useState({ userName: "", password: "", confirmPassword: "", email: "", fullName: "", BirthDate: new Date() });

    const handleSubmit = () => {
        
        axios.post("api/Auth/Register", registeredUser).then(res => {
            console.log(res);
        })
    }


    const handleInputChange = (e) => {
       
        const { name, value } = e.target;
        const fieldsValue = { [name]: value };
        setRegisteredUser({ ...registeredUser, ...fieldsValue });


    }



    return (

        <div className="card ">

            <h3 style={{ textAlign: 'center' }}>Register</h3>

            <div className="login-form">
                <div className="form-group">
                    <input type="text" placeholder="Full Name" name="fullName" className="form-control" onChange={handleInputChange} />
                </div>
                <div className="form-group">
                    <input type="text" placeholder="User Name" name="userName" className="form-control" onChange={handleInputChange} />
                </div>
                <div className="form-group">
                    <input type="password" placeholder="Password" name="password" className="form-control" onChange={handleInputChange} />
                </div>
                <div className="form-group">
                    <input type="password" placeholder="Confirm Password" name="confirmPassword" className="form-control" onChange={handleInputChange} />
                </div>
                <div className="form-group">
                    <input type="text" placeholder="Email" name="email" className="form-control" onChange={handleInputChange} />
                </div>
               
                <div className="form-group">
                    <input type="checkbox" id="rememberme" name="rememberMe" />
                    <label for="rememberme" style={{ marginLeft: "2px" }}> Remember me</label><br />
                </div>
                <button className="btn btn-success" onClick={handleSubmit} > Register</button>
            </div>
        </div>


    )
}

export default Register