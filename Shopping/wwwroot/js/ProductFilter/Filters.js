var btnCheapPrice = document.getElementById("BtnCheapPrice");
var btnHighPrice = document.getElementById("BtnHighPrice");
var inputCheapWithHighPrice = document.getElementById("inputCheapHighPrice");

var btnNewDate = document.getElementById("BtnNewDate");
var btnOldDate = document.getElementById("BtnOldDate");
var inputNewWithOldDate = document.getElementById("inputNewOldDate");


btnCheapPrice.addEventListener('click',function(){
    btnHighPrice.style.color="black";
    btnHighPrice.style.border="1px solid gray";
    btnCheapPrice.style.color="#fab300";
    btnCheapPrice.style.border="1px solid #fab300";
    inputCheapWithHighPrice.value ="Cheap";
});

btnHighPrice.addEventListener('click',function(){
    btnCheapPrice.style.color="black";
    btnCheapPrice.style.border="1px solid gray";
    btnHighPrice.style.color="#fab300";
    btnHighPrice.style.border="1px solid #fab300"; 
    inputCheapWithHighPrice.value ="Expensive";
});

btnNewDate.addEventListener('click',function(){
    btnOldDate.style.color="black";
    btnOldDate.style.border="1px solid gray";
    btnNewDate.style.color="#fab300";
    btnNewDate.style.border="1px solid #fab300";
    inputNewWithOldDate.value="New";
});

btnOldDate.addEventListener('click',function(){
    btnNewDate.style.color="black";
    btnNewDate.style.border="1px solid gray";
    btnOldDate.style.color="#fab300";
    btnOldDate.style.border="1px solid #fab300";
    inputNewWithOldDate.value="Old";
});