//fn: represented as reciever's action
function Command(fn, value) {
    this.execute = fn;
    this.value = value;
}

//AddCommand extends Command
function AddCommand(value) {
    Command.call(this, function (val) {
        return val + this.value;
    }, value);
}

function SubCommand(value) {
    Command.call(this, function (val) {
        return val - this.value;
    }, value);
}

function Calculator() {
    this._currentValue = 0;
}

Calculator.prototype = {
    execute: function (command) {
        this._currentValue = command.execute(this._currentValue);
    },
    getCurrentValue: function () {
        return this._currentValue;
    }
};

var calc = new Calculator;