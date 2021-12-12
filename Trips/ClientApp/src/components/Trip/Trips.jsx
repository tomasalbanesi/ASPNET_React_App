import React, { Component } from 'react';

export class Trips extends Component
{
    constructor(props)
    {
        super(props); // Envio las propiedades a la clase Component
        this.state = {
            trips: [],
            loading: true
        }
    }

    renderAllTripsTable(trips) {

        return (
            <table className="table table-striped">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Description</th>
                        <th>Date started</th>
                        <th>Date completede</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>a</td>
                        <td>a</td>
                        <td>a</td>
                        <td>a</td>
                        <td> - </td>
                    </tr>
                    <tr>
                        <td>a</td>
                        <td>a</td>
                        <td>a</td>
                        <td>a</td>
                        <td> - </td>
                    </tr>
                </tbody>
            </table>
            
        );
    }

    render() {

        let content = this.state.loading ? (
            <p>
                <em>Loading...</em>
            </p>
        ) : (
            this.renderAllTripsTable(this.state.trips)
        )

        return (    
            <div>
                <h1>All trips</h1>
                <p>Here you can see all trips</p>
                {content}
            </div>
        );
    }
}