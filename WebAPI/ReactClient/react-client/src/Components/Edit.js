import axios from "axios";
import React, {useState, useEffect} from "react";
import { useFetcher, useLocation } from "react-router-dom";

export function Edit() {
    const { state } = useLocation();
    const [employee, setEmployee] = useState({})
    const id = state.id;
    const URI = `https://localhost:7189/api/employees/${id}`

    useEffect(() => {
        axios.get(URI)
        .then((response) => {
            const data = response.data;
            setEmployee(data);
            console.log(employee)
        })
        .catch(error => console.log(error))
    }, [])

    if(employee.firstName === undefined) {
        return <div>Loading...</div>
    } else {
        return (
            <div className="d-flex justify-content-center flex-column">
                <div style={{alignSelf: "center"}}>
                    <h1>Edit employee</h1>
                </div>
                <div style={{width: "200px", alignSelf: "center"}}>
                    <input type="text"
                            className="form-control mb-4"
                            placeholder="First name"
                            defaultValue={employee.firstName}>
                    </input>
                    <input type="text"
                            className="form-control mb-4"
                            placeholder="Last name"
                            defaultValue={employee.lastName}>
                    </input>
                    <input type="string"
                            className="form-control mb-4"
                            placeholder="Phone number"
                            defaultValue={employee.phone}>
                    </input>
                    <button type="button" className="btn btn-success">Save</button>
                </div>
            </div>
        )
    }
}