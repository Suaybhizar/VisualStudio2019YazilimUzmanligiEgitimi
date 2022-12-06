//DOMContentLoaded derswek eğer öncelikle html dosyası tamamen render olacaktır
//Bu yüzden script dosyasını head in içerisinde yazılabilir 
//Eğer bu şekilde yazmazsak head içerisinde html dosyası render lanmadığı için sıkınt olacaktır.

document.addEventListener("DOMContentLoaded", init);

function init() {

    document.querySelector("#pTest").addEventListener("click", () => {
        alert("Merhaba AddEventListener");
    });

    //---------------------------------------------------------------------------------
    var inp = document.querySelector("#inp");

    let btn = document.querySelector("#btn");
    btn.addEventListener("click", () => {
        var val = inp.value;
        if (val == "") {
            inp.style.border = "1px solid blue";
            inp.style.backgroundColor = "red";
        }
    });

    //-----------------------------------------------------------------------------------

    // inp.addEventListener("input",(evt)=>{
    //     console.log(evt.currentTarget.value);
    // });


    //-------------------------------------------------------------------------------------

    // inp.addEventListener("change", (evt) => {
    //     console.log(evt.currentTarget.value);
    // });

    //-------------------------------------------------------------------------------------

    //deydown(klavyeden tuşa basıldığında çalışır)
    //keyup(basılan tuş bırıkıldığında çalışır)
    //keypress(tuşa basılıp bırakıldıktan sonra çalışır)

    //inp.addEventListener("keydown", (evt) => {
    //console.log(evt.currentTarget.value);
    //console.log(evt.which); //WHİCH BASILAN TUŞUN ASKİİ KOD DEĞERİNİ VERİR
    //console.log(String.fromCharCode(evt.which));//bu şekilde kullanıldığında aski kodun karşılığında ki karekteri verir.

    //});

    //-----------------------------------------------------------------------------------------

    inp.addEventListener("mouseenter", (evt) => {
        var element=evt.currentTarget;
        element.style.backgroundColor="yellow";
    });
    
    inp.addEventListener("mouseleave", (evt) => {
        var element=evt.currentTarget;
        element.style.backgroundColor="blue";
    });


}