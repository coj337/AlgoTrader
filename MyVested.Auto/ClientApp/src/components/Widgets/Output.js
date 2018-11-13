﻿import React, { Component } from 'react';
import Select from 'react-select';

export class Output extends Component {
    state = {
        selectedOption: null
    }
    handleChange = (selectedOption) => {
        this.setState({ selectedOption });
    }

    render() {
        const options = [
            { value: 'all', label: 'All' },
            { value: 'system', label: 'System' },
            { value: 'indicator', label: 'Indicator' },
            { value: 'bot', label: 'Bot' }
        ];
        const { selectedOption } = this.state;
        return (
            <span>
                <div className="widgetHandle">Output</div>
                <div className="widgetBody">
                    <Select
                        value={selectedOption}
                        onChange={this.handleChange}
                        options={options}
                        className="outputSelect"
                        defaultValue="All"
                    />
                </div>
            </span>
        );
    }
}