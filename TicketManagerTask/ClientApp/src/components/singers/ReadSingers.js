import React, { Component } from 'react';
import authService from '../api-authorization/AuthorizeService'

export class ReadSingers extends Component {
    static displayName = ReadSingers.name;

    constructor(props) {
        super(props);
        this.state = { singers: [], loading: true };
    }

    componentDidMount() {
        this.populateSingerData();
    }

    handleDelete(id) {
    {
            fetch('api/Singers/' + id, {
                method: 'delete'
            }).then(data => {
                this.setState(
                    {
                        singers: this.state.singers.filter((rec) => {
                            return (rec.id != id);
                        })
                    });
            });
        }
    }

    static renderSingersTable(singers) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                    </tr>
                </thead>
                <tbody>
                    {singers.map(singer =>
                        <tr key={singer.id}>
                            <td>{singer.id}</td>
                            <td>{singer.name}</td>
                            <td><button type="button" className="btn btn-success">Edit</button></td>
                            <td><button type="button" onClick={(id) => this.handleDelete(singer.id)} className="btn btn-danger">Delete</button></td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : ReadSingers.renderSingersTable(this.state.singers);

        return (
            <div>
                <h1 id="tabelLabel" >Singer List</h1>
                {contents}
            </div>
        );
    }

    async populateSingerData() {
        const token = await authService.getAccessToken();
        const response = await fetch('api/singers', {
            headers: !token ? {} : { 'Authorization': `Bearer ${token}` }
        });
        const data = await response.json();
        this.setState({ singers: data, loading: false });
    }
}

export default ReadSingers;