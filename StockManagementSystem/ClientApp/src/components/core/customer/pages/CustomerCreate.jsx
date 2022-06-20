import React, { Component, useState } from 'react';
import { Form } from 'reactstrap';
import axios from "axios";
import { error } from 'jquery';

const CustomerCreate = () => {
    const [errors, setErrors] = useState({})
    const [customerModel, setCustomerModel] = useState({ id: 0, name: "", totalBill: 0, departmentId:0 });

    
    const validate = (fieldValues = customerModel) => {
            console.log(fieldValues)
            let temp = { ...errors }
        if ('name' in fieldValues) {
            temp.name = " ";
            temp.name += fieldValues.name ? "" : " This field is required."
            temp.name += fieldValues.name.length > 5 ? "" : " Minimum size is 5."
        }

        if ('departmentId' in fieldValues) {
            temp.departmentId = ""
            temp.departmentId += fieldValues.departmentId > 0 ? "":"Department is Required"
        }
               
            setErrors({
                ...temp
            })

            if (fieldValues == customerModel)
                return Object.values(temp).every(x => x == "")
        }
    



    const handleSubmit = (e) => {
        e.preventDefault();
        if (validate()) {
            e.preventDefault();
            axios.post("api/customer/postCustomer", customerModel).then(data => alert("Succesfully Saved"))
        }
        
    }
    const handleInputChange = (e) => {
       
        const { name, value } = e.target;
        const fieldsValue = { [name]:value };
        setCustomerModel({ ...customerModel, ...fieldsValue });
        validate(fieldsValue);
    }
    return (<>
        <h1>Cutomer</h1>
        <form onSubmit={handleSubmit}>
            <div className="form-group">
                <label >Name:</label>
                <input className="form-control" type="text" name="name" onChange={handleInputChange} />
                {errors.name && <div style={{ color: "red" }}>{errors.name}</div>}
            </div>
            <div className="form-group">
                <label >Total Bill:</label>
                <input className="form-control" type="number" name="totalBill" onChange={handleInputChange} />
            </div>
            <select className="form-group" name="departmentId" onChange={handleInputChange}>
                <option value="0">---select---</option>
                <option value="1">Premimum</option>
                <option value="2">Casual</option>
            </select>
            {errors.departmentId && <div style={{ color: "red" }}>{errors.departmentId}</div>}

            <button className="btn btn-danger" type="submit">Save</button>
             </form>
        
   </>
        
        )
}

export default CustomerCreate;