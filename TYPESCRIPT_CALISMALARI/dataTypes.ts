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

enum Color{
    Red=5,
    Yellow=10,
    Blue=15
}

let color:Color
color=Color.Red

let renk:string = Color[10]
console.log("seçtiğim renk : {0} ",renk)