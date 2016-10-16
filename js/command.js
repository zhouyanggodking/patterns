//fn: represented as reciever's action
function Command(fn, undo, value) {
    this.execute = fn;
    this.value = value;
    this.undo = undo;
}

//AddCommand extends Command
function AddCommand(value) {
    Command.call(this, add, sub, value);
}

//SubCommand extends Command
function SubCommand(value) {
    Command.call(this, sub, add, value);
}

//named function to replace anonymous function
function add(val) {
    return val + this.value;
}

function sub(val) {
    return val - this.value;
}

function Calculator() {
    this._currentValue = 0;
    this.commands = [];//executed command list
}

Calculator.prototype = {
    execute: function (command) {
        this._currentValue = command.execute(this._currentValue);
        this.commands.push(command);
    },
    undo: function(){
        var cmd = this.commands.pop();
        this._currentValue = cmd.undo(this._currentValue);
    },
    getCurrentValue: function () {
        return this._currentValue;
    }
};

var calc = new Calculator;