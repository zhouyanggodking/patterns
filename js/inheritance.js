function Beverage(name, temperature) {
    this.name = name;
    this.temperature = temperature;
}

Beverage.prototype.drink = function () {
    console.log('I\'m drinking ' + this.name);
}

function Coffee(type) {
    Beverage.call(this, 'coffee', 'hot');
    this.type = type;
}

Coffee.prototype = Object.create(Beverage.prototype);

Coffee.prototype.sip = function () {
    console.log('I\'m sipping ' + this.type + ' ' + this.name);
}

var cof = new Coffee('black');
cof.drink();
cof.sip();

//var b1 = new Beverage('Lemon', 'hot');
//var b2 = new Beverage('Apple juice', 'hot');

//b1.drink();
//b2.drink();


//var e = b1.drink === b2.drink;