var SignInPasswordInput = document.getElementById("SignInPasswordInput");
var SignInPasswordShow = document.querySelector(".SignInPasswordShow");

SignInPasswordShow.addEventListener('click',function(){
if(SignInPasswordShow.className=="fa-sharp fa-solid fa-eye SignInPasswordShow"){
    SignInPasswordInput.type="text"
    SignInPasswordShow.className="fa-solid fa-eye-slash SignInPasswordShow"
}else{
    SignInPasswordInput.type="password" 
    SignInPasswordShow.className="fa-sharp fa-solid fa-eye SignInPasswordShow"
}
});