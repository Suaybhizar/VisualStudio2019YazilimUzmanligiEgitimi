// let sayi : number
// sayi=10
// sayi=10.2
//----------------------------
// let sayi:number=10
//----------------------------
// let sehir:string
// sehir="Ankara"
// console.log("Yaşadığım Şehir : "+sehir)
// let isDone:Boolean=true
// isDone=false
// let sehirler:string[]=["Ankara","Amasya","Erzurum"]
// console.log(sehirler.join(" "))
// let sayilar:number[]=[1,2,3]
// console.log(sayilar[0])
//-----------------------------------------
//tuple
// let dictionary:[string,number]
// dictionary=["school",1]
//------------------------------------------
//enums
var Color;
(function (Color) {
    Color[Color["Red"] = 5] = "Red";
    Color[Color["Yellow"] = 10] = "Yellow";
    Color[Color["Blue"] = 15] = "Blue";
})(Color || (Color = {}));
var color;
color = Color.Red;
var renk = Color[10];
console.log("seçtiğim renk : {0} ", renk);
