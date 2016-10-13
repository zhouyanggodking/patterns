//like $.extend()

//demo: person/dog walk, eat, run
function Person(name) {
    this.name = name;
}

function Dog(name) {
    this.name = name;
}

//mixin methods
var walker = {
    walk: function () {
        console.log(this.name + ' is walking');
    }
};

var eater = {
    eat: function () {
        console.log(this.name + ' is eating');
    }
};

var runner = {
    run: function () {
        console.log(this.name + ' is running');
    }
};

//extend(target, arg1, arg2, ...)
function extend(target) {
    if (!target) {
        return target;
    }
    for (var ii = 1; ii < arguments.length; ++ii) {
        for (var key in arguments[ii]) {
            if (arguments[ii].hasOwnProperty(key)) {
                target[key] = arguments[ii][key];
            }
        }
    }
    return target;
}

var godking = new Person('godking');
var sweetie = new Dog('sweetie');

extend(godking, walker, runner, eater);
extend(sweetie, walker, runner, eater);

godking.walk();
godking.run();
godking.eat();

sweetie.walk();
sweetie.run();
sweetie.eat();

//mixin version 2
//merge methods of source into target
function mixin(target, source, methods) {
    for (var ii = 2; ii < arguments[ii]; ++ii) {
        var method = arguments[ii];
        target[method] = source[method].bind(source);
    }
    return target;
}




