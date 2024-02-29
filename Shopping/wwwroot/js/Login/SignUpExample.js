var SignInPasswordInput1 = document.getElementById("SignInPasswordInput1");
var SignInPasswordShow1 = document.querySelector(".SignInPasswordShow1");

SignInPasswordShow1.addEventListener('click',function(){
if(SignInPasswordShow1.className=="fa-sharp fa-solid fa-eye SignInPasswordShow1"){
    SignInPasswordInput1.type="text"
    SignInPasswordShow1.className="fa-solid fa-eye-slash SignInPasswordShow1"
}else{
    SignInPasswordInput1.type="password" 
    SignInPasswordShow1.className="fa-sharp fa-solid fa-eye SignInPasswordShow1"
}
});

var SignInPasswordInput2 = document.getElementById("SignInPasswordInput2");
var SignInPasswordShow2 = document.querySelector(".SignInPasswordShow2");

SignInPasswordShow2.addEventListener('click',function(){
if(SignInPasswordShow2.className=="fa-sharp fa-solid fa-eye SignInPasswordShow2"){
    SignInPasswordInput2.type="text"
    SignInPasswordShow2.className="fa-solid fa-eye-slash SignInPasswordShow2"
}
else{
    SignInPasswordInput2.type="password" 
    SignInPasswordShow2.className="fa-sharp fa-solid fa-eye SignInPasswordShow2"
}
});


window.onload = function() {
    MaskedInput({
       elm: document.getElementById('phone'), // select only by id
       format: '+994 (__) ___-__-__',
       separator: '+994 (   )-'
    });
   
      MaskedInput({
       elm: document.getElementById('phone2'), // select only by id
       format: '+994 (__) ___-__-__',
       separator: '+994 ()-'
    });
 };
 
 // masked_input_1.4-min.js
 // angelwatt.com/coding/masked_input.php
 (function(a){a.MaskedInput=function(f){if(!f||!f.elm||!f.format){return null}if(!(this instanceof a.MaskedInput)){return new a.MaskedInput(f)}var o=this,d=f.elm,s=f.format,i=f.allowed||"0123456789",h=f.allowedfx||function(){return true},p=f.separator||"/:-",n=f.typeon||"_YMDhms",c=f.onbadkey||function(){},q=f.onfilled||function(){},w=f.badkeywait||0,A=f.hasOwnProperty("preserve")?!!f.preserve:true,l=true,y=false,t=s,j=(function(){if(window.addEventListener){return function(E,C,D,B){E.addEventListener(C,D,(B===undefined)?false:B)}}if(window.attachEvent){return function(D,B,C){D.attachEvent("on"+B,C)}}return function(D,B,C){D["on"+B]=C}}()),u=function(){for(var B=d.value.length-1;B>=0;B--){for(var D=0,C=n.length;D<C;D++){if(d.value[B]===n[D]){return false}}}return true},x=function(C){try{C.focus();if(C.selectionStart>=0){return C.selectionStart}if(document.selection){var B=document.selection.createRange();return -B.moveStart("character",-C.value.length)}return -1}catch(D){return -1}},b=function(C,E){try{if(C.selectionStart){C.focus();C.setSelectionRange(E,E)}else{if(C.createTextRange){var B=C.createTextRange();B.move("character",E);B.select()}}}catch(D){return false}return true},m=function(D){D=D||window.event;var C="",E=D.which,B=D.type;if(E===undefined||E===null){E=D.keyCode}if(E===undefined||E===null){return""}switch(E){case 8:C="bksp";break;case 46:C=(B==="keydown")?"del":".";break;case 16:C="shift";break;case 0:case 9:case 13:C="etc";break;case 37:case 38:case 39:case 40:C=(!D.shiftKey&&(D.charCode!==39&&D.charCode!==undefined))?"etc":String.fromCharCode(E);break;default:C=String.fromCharCode(E);break}return C},v=function(B,C){if(B.preventDefault){B.preventDefault()}B.returnValue=C||false},k=function(B){var D=x(d),F=d.value,E="",C=true;switch(C){case (i.indexOf(B)!==-1):D=D+1;if(D>s.length){return false}while(p.indexOf(F.charAt(D-1))!==-1&&D<=s.length){D=D+1}if(!h(B,D)){c(B);return false}E=F.substr(0,D-1)+B+F.substr(D);if(i.indexOf(F.charAt(D))===-1&&n.indexOf(F.charAt(D))===-1){D=D+1}break;case (B==="bksp"):D=D-1;if(D<0){return false}while(i.indexOf(F.charAt(D))===-1&&n.indexOf(F.charAt(D))===-1&&D>1){D=D-1}E=F.substr(0,D)+s.substr(D,1)+F.substr(D+1);break;case (B==="del"):if(D>=F.length){return false}while(p.indexOf(F.charAt(D))!==-1&&F.charAt(D)!==""){D=D+1}E=F.substr(0,D)+s.substr(D,1)+F.substr(D+1);D=D+1;break;case (B==="etc"):return true;default:return false}d.value="";d.value=E;b(d,D);return false},g=function(B){if(i.indexOf(B)===-1&&B!=="bksp"&&B!=="del"&&B!=="etc"){var C=x(d);y=true;c(B);setTimeout(function(){y=false;b(d,C)},w);return false}return true},z=function(C){if(!l){return true}C=C||event;if(y){v(C);return false}var B=m(C);if((C.metaKey||C.ctrlKey)&&(B==="X"||B==="V")){v(C);return false}if(C.metaKey||C.ctrlKey){return true}if(d.value===""){d.value=s;b(d,0)}if(B==="bksp"||B==="del"){k(B);v(C);return false}return true},e=function(C){if(!l){return true}C=C||event;if(y){v(C);return false}var B=m(C);if(B==="etc"||C.metaKey||C.ctrlKey||C.altKey){return true}if(B!=="bksp"&&B!=="del"&&B!=="shift"){if(!g(B)){v(C);return false}if(k(B)){if(u()){q()}v(C,true);return true}if(u()){q()}v(C);return false}return false},r=function(){if(!d.tagName||(d.tagName.toUpperCase()!=="INPUT"&&d.tagName.toUpperCase()!=="TEXTAREA")){return null}if(!A||d.value===""){d.value=s}j(d,"keydown",function(B){z(B)});j(d,"keypress",function(B){e(B)});j(d,"focus",function(){t=d.value});j(d,"blur",function(){if(d.value!==t&&d.onchange){d.onchange()}});return o};o.resetField=function(){d.value=s};o.setAllowed=function(B){i=B;o.resetField()};o.setFormat=function(B){s=B;o.resetField()};o.setSeparator=function(B){p=B;o.resetField()};o.setTypeon=function(B){n=B;o.resetField()};o.setEnabled=function(B){l=B};return r()}}(window));


let imgInput1 = document.getElementById('image-input1');
let imgInput2 = document.getElementById('image-input2');


let img1=document.getElementById("preview1");
let img2=document.getElementById("preview2");


imgInput1.addEventListener('change', function (e) {
    if (e.target.files) {
        let imageFile = e.target.files[0];
        var reader = new FileReader();
        reader.onload = function (e) {
            var img = document.createElement("img");
            img.onload = function (event) {
                // Dynamically create a canvas element
                var canvas = document.createElement("canvas");

                // var canvas = document.getElementById("canvas");
                var ctx = canvas.getContext("2d");

                // Actual resizing
                ctx.drawImage(img, 0, 0, 300, 150);

                // Show resized image in preview element
                var dataurl = canvas.toDataURL(imageFile.type);
                document.getElementById("preview1").src = dataurl;
            }
            img1.src = e.target.result;
        }
        reader.readAsDataURL(imageFile);
    }
});
imgInput2.addEventListener('change', function (e) {
   if (e.target.files) {
       let imageFile = e.target.files[0];
       var reader = new FileReader();
       reader.onload = function (e) {
           var img = document.createElement("img");
           img.onload = function (event) {
               // Dynamically create a canvas element
               var canvas = document.createElement("canvas");

               // var canvas = document.getElementById("canvas");
               var ctx = canvas.getContext("2d");

               // Actual resizing
               ctx.drawImage(img, 0, 0, 300, 150);

               // Show resized image in preview element
               var dataurl = canvas.toDataURL(imageFile.type);
               document.getElementById("preview2").src = dataurl;
           }
           img2.src = e.target.result;
       }
       reader.readAsDataURL(imageFile);
   }
});


var Men = document.getElementById('Men');
var Women = document.getElementById('Women');
var Other = document.getElementById('Other');
var GengerInput = document.querySelector(".GengerInput");
Men.addEventListener('click',function(){
if(Men.checked){
    GengerInput.value="Kişi";
   Women.checked=false;
   Other.checked=false;
}
});
Women.addEventListener('click',function(){
    if(Women.checked){
        GengerInput.value="Qadın";
       Men.checked=false;
       Other.checked=false;
    }
    });

    Other.addEventListener('click',function(){
        if(Other.checked){
            GengerInput.value="Heç Biri";
           Women.checked=false;
           Men.checked=false;
        }
        });
        

