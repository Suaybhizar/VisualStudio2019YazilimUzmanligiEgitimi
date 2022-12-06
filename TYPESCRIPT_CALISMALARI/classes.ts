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

class Person{
    _fullName:string
    constructor(fullName:string){
        this._fullName=fullName;
    }

    test(){
        return "Merhaba " + this._fullName
    }
}

class A extends Person{
   private _X:String
    constructor(fn:String){
        super (fn)
    }
    tetsA(){}
}

let a =new A("Suayb Hızar");
