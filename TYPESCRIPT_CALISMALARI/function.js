//named function
// function add(n1:number,n2:number):number{
//     return n1+n2;
// }
// console.log(add(15,5))
//-------------------------------------------------
//anonymus function
// let add:number=function (n1:number,n2:number):number {
//     return n1+n2; 
// }
// let result=add(10,20)
// console.log("Sonuç: "+result)
//-------------------------------------------------
// function add(n1:number,n2:number=30):number{
// return n1+n2
// }
// console.log(add(15,25))
// console.log(add(15))
//------------------------------------------------
//optional paramater
//NOT : opsiyonel parametreler her zamana en sonda olmalıdır
// function add(n1:number,n2?:number):number{
//     if(n2===undefined)
//         return n1
//     return n1+n2
// }
// console.log(add(10))
// console.log(add(10,60))
//-------------------------------------------------------
//rest parameter (rest=geriye kalan...) (C# params)
function restTest(city) {
    var others = [];
    for (var _i = 1; _i < arguments.length; _i++) {
        others[_i - 1] = arguments[_i];
    }
    return city + " " + others.join(" , ");
}
console.log(restTest("Ankara"));
console.log(restTest("Ankara", "İzmir"));
console.log(restTest("Ankara", "İzmir", "İstanbul"));
