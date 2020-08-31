class ChartUserForm extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            a: 2,
            b: 2,
            c: 1,
            step: 1,
            RangeFrom: -1,
            RangeTo: 1
        };
        this.onSubmit = this.onSubmit.bind(this);
        this.onAChange = this.onAChange.bind(this);
        this.onBChange = this.onBChange.bind(this);
        this.onCChange = this.onCChange.bind(this);
        this.onStepChange = this.onStepChange.bind(this);
        this.onRangeFromChange = this.onRangeFromChange.bind(this);
        this.onRangeToChange = this.onRangeToChange.bind(this);
    }
    onAChange(e) {
        this.setState({
            a: e.target.value
        })
    }
    onBChange(e) {
        this.setState({
            b: e.target.value
        })
    }
    onCChange(e) {
        this.setState({
            c: e.target.value
        })
    }
    onStepChange(e) {
        this.setState({
            step: e.target.value
        })
    }
    onRangeFromChange(e) {
        this.setState({
            RangeFrom: e.target.value
        })
    }
    onRangeToChange(e) {
        this.setState({
            RangeTo: e.target.value
        })
    }

    onSubmit(e) {
        e.preventDefault();

        const udInput = {
            a: this.state.a,
            b: this.state.b,
            c: this.state.c,
            step: this.state.step,
            RangeFrom: this.state.RangeFrom,
            RangeTo: this.state.RangeTo
        }

        database.push(udInput);
        return udInput;

    }

    render() {
        return (
            <div>
                <form onSubmit={this.onSubmit}>
                    <h3>REACT form below</h3>
                    <label>
                        Function: y =
                    <input
                            type="number"
                            size={0.1}
                            value={this.state.a}
                            onChange={this.onAChange} />
                    </label>
                    <label>
                        * x^2 + 
                    <input
                            type="number"
                            size={0.5}
                            value={this.state.b}
                            onChange={this.onBChange} />
                    </label>
                    <label>
                        * x + 
                    <input
                            type="number"
                            size={0.5}
                            value={this.state.c}
                            onChange={this.onCChange} />
                    </label>
                    <div> </div>
                    <label>
                        Step:
                    <input
                            type="number"
                            value={this.state.step}
                            onChange={this.onStepChange} />
                    </label>
                    <div> </div>
                    <label>
                        From:
                    <input
                            type="number"
                            value={this.state.RangeFrom}
                            onChange={this.onRangeFromChange} />
                    </label>
                    <label>
                        to:
                    <input
                            type="number"
                            value={this.state.RangeTo}
                            onChange={this.onRangeToChange} />
                    </label>
                    <div> </div>
                    <input type="submit" value="React submit - not working :(" />
                </form>
            </div>
        );
    }
}

ReactDOM.render(
    <ChartUserForm />,
    document.getElementById("content")
);
