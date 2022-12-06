// //default access modifier  public'tir
// class Employee{
//    private _firstName:string;
//    private _lastName:string;
//    private _age:number
//     constructor (firstName:String,lastName:String,age:number){
//         this._firstName=firstName;
//         this._lastName=lastName;
//         this._age=age;
//     }
//     get firstName(){
//         return this._firstName;
//     }
//     set firstName(fn:string){
//         this._firstName=fn;
//     }
//     get lastName(){
//         return this._lastName;
//     }
//     set lastName(ln:string){
//         this._lastName=ln;
//     }
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
//     getInfo(){
//         return "Merhaba ben "+ this._firstName + " " + this._lastName + " "+ this._age + " Yaşındayım";
//     }
// }
// //let employee=new Employee("Ali","Veli",25);
// let employee = new Employee("","",10)
// employee.firstName="Ahmet"
// employee.lastName="ali"
// console.log(employee.getInfo());
//---------------------------------------------------------------------------------
var Person = /** @class */ (function () {
    function Person(fullName) {
        this._fullName = fullName;
    }
    Person.prototype.test = function () {
        return "Merhaba " + this._fullName;
    };
    return Person;
}());
var A = /** @class */ (function (_super) {
    __extends(A, _super);
    function A(fn) {
        return _super.call(this, fn) || this;
    }
    A.prototype.tetsA = function () { };
    return A;
}(Person));
var a = new A("Suayb Hızar");
