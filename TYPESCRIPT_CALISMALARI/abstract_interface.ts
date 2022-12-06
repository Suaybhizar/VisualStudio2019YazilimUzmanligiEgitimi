//abstract classlar

// abstract class Product{
//     name:string;
//     price:number;

//     constructor(){}

//     save():void{
//         console.log("Ürün Bilgisi Kaydedildi.");
//     }

//    abstract calculate(x:number):number;
// } 

// class Apple extends Product {
// constructor(){
//     super();
// }

//     calculate(x: number): number {
//         throw new Error("Method not implemented.");
//     }
//     test():void{}

// }

// let apple:Apple=new Apple ();
// apple.calculate(10);

//------------------------------------------------------------

// interface

interface IProduct{
    name:string;
    price:number;

    save():void
    calculate(x:number):number;
}

class Apple implements IProduct{
    name: string;
    price: number;
    save(): void {
        throw new Error("Method not implemented.");
    }
    calculate(x: number): number {
        throw new Error("Method not implemented.");
    }

    test():void

}

class Orange implements IProduct{
    name: string;
    price: number;
    save(): void {
        throw new Error("Method not implemented.");
    }
    calculate(x: number): number {
        throw new Error("Method not implemented.");
    }
    testOrange():void{

    }
}

let obj1:IProduct=new Orange();
obj1.calculate(10);

function test(product:IProduct):void{

}

test(new Orange());