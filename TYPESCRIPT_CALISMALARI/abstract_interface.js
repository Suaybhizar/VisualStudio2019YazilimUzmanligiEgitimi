//abstract classlar
var Apple = /** @class */ (function () {
    function Apple() {
    }
    Apple.prototype.save = function () {
        throw new Error("Method not implemented.");
    };
    Apple.prototype.calculate = function (x) {
        throw new Error("Method not implemented.");
    };
    return Apple;
}());
var Orange = /** @class */ (function () {
    function Orange() {
    }
    Orange.prototype.save = function () {
        throw new Error("Method not implemented.");
    };
    Orange.prototype.calculate = function (x) {
        throw new Error("Method not implemented.");
    };
    Orange.prototype.testOrange = function () {
    };
    return Orange;
}());
var obj1 = new Orange();
obj1.calculate(10);
function test(product) {
}
test(new Orange());
