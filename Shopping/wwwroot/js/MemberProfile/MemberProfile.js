var AllProduct =document.querySelector(".MemberAllProduct");
var Premium =document.querySelector(".MemberPremium");
var Vip =document.querySelector(".MemberVip");
var Popular =document.querySelector(".ViewPopular");
var Description =document.querySelector(".MemberDescription");

var AllProductDiv =document.querySelector(".MemberAllProductDiv");
var PremiumDiv =document.querySelector(".MemberPremiumDiv");
var VipDiv =document.querySelector(".MemberVipDiv");
var MemberPopularDiv =document.querySelector(".MemberPopularDiv");
var DescriptionDiv =document.querySelector(".MemberDescriptionDiv");

AllProduct.addEventListener('click',function(){
    PremiumDiv.style.display="none";
    MemberPopularDiv.style.display="none";
    VipDiv.style.display="none";
    DescriptionDiv.style.display="none";
    AllProductDiv.style.display="block";
    
});
Premium.addEventListener('click',function(){
    PremiumDiv.style.display="block";
    MemberPopularDiv.style.display="none";
    VipDiv.style.display="none";
    DescriptionDiv.style.display="none";
    AllProductDiv.style.display="none";
    
});
Vip.addEventListener('click',function(){
    PremiumDiv.style.display="none";
    MemberPopularDiv.style.display="none";
    VipDiv.style.display="block";
    DescriptionDiv.style.display="none";
    AllProductDiv.style.display="none";
    
});
Popular.addEventListener('click',function(){
    PremiumDiv.style.display="none";
    MemberPopularDiv.style.display="block";
    VipDiv.style.display="none";
    DescriptionDiv.style.display="none";
    AllProductDiv.style.display="none";
    
});
Description.addEventListener('click',function(){
    PremiumDiv.style.display="none";
    MemberPopularDiv.style.display="none";
    VipDiv.style.display="none";
    DescriptionDiv.style.display="block";
    AllProductDiv.style.display="none";
    
});


var Default=document.querySelector(".Default");
var Update = document.querySelector(".Update");

var MemberDescriptionWebSiteUpdateSet = document.querySelector(".MemberDescriptionWebSiteUpdateSet");
var MemberDescriptionWebSiteUpdateGet = document.querySelector(".MemberDescriptionWebSiteUpdateGet");

MemberDescriptionWebSiteUpdateGet.addEventListener('click',function(){

    Update.style.display="block" 
    Default.style.display="none"
    MemberDescriptionWebSiteUpdateGet.style.display="none"
    MemberDescriptionWebSiteUpdateSet.style.display="block"
});
MemberDescriptionWebSiteUpdateSet.addEventListener('click',function(){

    Update.style.display="none" 
    Default.style.display="block"
    MemberDescriptionWebSiteUpdateGet.style.display="block"
    MemberDescriptionWebSiteUpdateSet.style.display="none"
});
