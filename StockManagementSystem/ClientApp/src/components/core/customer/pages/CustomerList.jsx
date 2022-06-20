import React, { useEffect, useState } from "react";
import axios from 'axios';


export default function CustomerList() {
    const [customerList, setCustomerList] = useState([])

   const  url = "api/customer";
    useEffect(() => {
        axios.get(url).then(res => {
            setCustomerList(res.data)
            console.log(customerList)
        });
    }, [])

    const handleUdate = () => {
        console.log("Click");
       //const updatedData =  [
       //     { id: 1, name: "Sadia Tina", totalBill: 1200 },
       //     { id: 2, name: "Asif Akbar", totalBill:4500 }
       // ]

        axios.get("api/customer/getUpdatedValue").then(res => {
            setCustomerList(res.data)
            console.log(customerList)
        });
        /*setCustomerList(updatedData);*/
    }
    return (
        <>
        <table className="table">
            <thead>
                <th>
                    <td>Name</td>
                    <td>Total Bill</td>
                </th>
            </thead>
            <tbody>
                {customerList.map(cus => (
                    <tr>
                        <td>{cus.name}</td>
                        <td>{cus.totalBill}</td>
                    </tr>

                ))}
               
            </tbody>

            </table>
            <button onClick={handleUdate}>Update</button>
       </>
    )
}


