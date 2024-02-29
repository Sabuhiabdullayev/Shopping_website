


var Electronica = document.getElementById("Electronica");
var RealEstat =document.getElementById("RealEstate");
var Transportation = document.getElementById("Transportation");
var ForHomeAndGarden = document.getElementById("ForHomeAndGarden");
var BusinessandServices = document.getElementById("BusinessandServices");
var PersonalItems = document.getElementById("PersonalItems");
var ChildrensWorld = document.getElementById("ChildrensWorld");
var HobbyLeisure = document.getElementById("HobbyLeisure");
var AnimalFeeds = document.getElementById("AnimalFeeds");
var JobAnnouncements = document.getElementById("JobAnnouncements");

var CatalogFormInput = document.getElementById("CatalogFormInput");

Electronica.addEventListener('click',function(){
    CatalogFormInput.value="Elektronika"
});
RealEstat.addEventListener('click',function(){
    CatalogFormInput.value="Daşınmaz Əmlak"
});
Transportation.addEventListener('click',function(){
    CatalogFormInput.value="Nəqliyyat"
});
ForHomeAndGarden.addEventListener('click',function(){
    CatalogFormInput.value="Ev və Bağ üçün"
});
BusinessandServices.addEventListener('click',function(){
    CatalogFormInput.value="Biznes və Xidmətlər"
});
PersonalItems.addEventListener('click',function(){
    CatalogFormInput.value="Şəxsi Əşyalar"
});
ChildrensWorld.addEventListener('click',function(){
    CatalogFormInput.value="Uşaq Aləmi"
});
HobbyLeisure.addEventListener('click',function(){
    CatalogFormInput.value="Hobbi Asudə"
});
AnimalFeeds.addEventListener('click',function(){
    CatalogFormInput.value="Heyvanlar Yemlər"
});
JobAnnouncements.addEventListener('click',function(){
    CatalogFormInput.value="İş Elanlar"
});