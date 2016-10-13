function Beverage() {//like abstract base class
    this._cost = 0;
}

Beverage.prototype.cost = function () {
    return this._cost;
}

//Coffee extends Beverage
function Coffee() {
    Beverage.call(this);
    this._cost = 5;
}

Coffee.prototype = Object.create(Beverage.prototype);
//from line 1 to 15, is inheritance pattern


//BeverageDecorator extends Beverage
function BeverageDecorator(beverage) {
    Beverage.call(this);
    this.beverage = beverage;
}

BeverageDecorator.prototype = Object.create(Beverage.prototype);
BeverageDecorator.prototype.cost = function () {
    return this._cost + this.beverage.cost();
}


//sugar extends BeverageDecorator
function Sugar(beverage) {
    BeverageDecorator.call(this, beverage);
    this._cost = 0.15;
}

Sugar.prototype = Object.create(BeverageDecorator.prototype);

var coffee = new Coffee();
var coffee_sugar = new Sugar(coffee);

