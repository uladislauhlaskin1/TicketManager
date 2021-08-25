import React, { Component } from 'react';
//var index = require('/../../Views/Singers/index.cshtml');
//var index = require('Singers.html');

export class Singers extends Component {
    static displayName = Singers.name;

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
                <h1>Singers</h1>

            </div>
        );
    }

    //render() {
    //    return (
    //        <iframe src={index}></iframe>   /* like this */
    //    );
    //}
}