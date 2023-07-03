import React, {useState, useEffect} from "react";
import axios from 'axios'

export function Home(props) {
    const [employees, setEmployees] = useState([{}])
    
    const URI = 'https://localhost:7189/api/employees'

    useEffect(() => {
        axios.get(URI)
            .then((response) => {
                setEmployees(response.data)
            })
            .catch((err) => console.log(err));
    }, [])
    
    if(employees.length === 1) {
        return <div>Loading...</div>
    } else {
        return (
            <section>
            <table className="table">
                <thead>
                    <tr>
                    <th scope="col">#</th>
                    <th scope="col">FirstName</th>
                    <th scope="col">LastName</th>
                    <th scope="col">Phone</th>
                    </tr>   
                </thead>
                <tbody>
                    {employees.map(employee => (
                        <tr>
                            <th scope="row">1</th>
                            <td>{employee.firstName}</td>
                            <td>{employee.lastName}</td>
                            <td>{employee.phone}</td>
                        </tr> 
                    ))}
                </tbody>
            </table>
        </section>
        )
    }
}