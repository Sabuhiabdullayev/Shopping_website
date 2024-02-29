$(document).ready(function () {

    $(".Category2Block").hide();
    $(".Category3Block").hide();
    $("#Catalog").on("change", function () {
        $("#CatalogText").val($(this).find("option:selected").text());
    });
    $("#Category3").on("change", function () {
        $("#Category3Text").val($(this).find("option:selected").text());
    });
});
$(function () {
    $("#Catalog").change(function () {
        $(".Category2Block").hide();
        $(".Category3Block").hide();
        $("#Category2").empty();
        $("#Category3").empty();
        $.ajax({
            url: '/Product/Category2json',

            dataType: 'json',
            data: { id: $("#Catalog").val() },


            success: function (data) {
                if (data.length != 0) {
                    $(".Category2Block").show()
                }
                $("#Category2").append('<option>Kategoriya seçiniz...</option>');


                $.each(data, (Category2json, deger) => {

                    $("#Category2").append('<option value="' + deger.value + '">' + deger.text + '</option>');

                });

            }
        });

    });
});

$(function () {
    $("#Category2").change(function () {
        $(".Category3Block").hide();

        $("#Category3").empty();
        $.ajax({
            url: '/Product/Category1json',

            dataType: 'json',
            data: { id: $("#Category2").val() },


            success: function (data) {
                if (data.length != 0) {
                    $(".Category3Block").show()
                }
                $("#Category3").append('<option>Kategoriya seçiniz...</option>');


                $.each(data, (Category1json, deger2) => {

                    $("#Category3").append('<option value="' + deger2.value + '">' + deger2.text + '</option>');

                });

            }
        });

    });
});













$(document).ready(function () {

    $("#Category2").change(function () {
        $("#AllInputDiv").html("");
        var Category2 = $(this).find("option:selected").text();
        switch (Category2) {
            // Elektronika Start

            case "Telefonlar":
                $("#AllInputDiv").html(
                    ProductName + CarBrand + Model + Color + New + Delivery + PlaceOfResidence
                );
                break;
            case "Aksesuarlar":
                $("#AllInputDiv").html(
                    ProductName + New + Delivery + PlaceOfResidence
                );
                break;
            case "Noutbok və netboklar":
                $("#AllInputDiv").html(
                    ProductName + CarBrand + Model + Color + New + Delivery + PlaceOfResidence
                );
                break;
            case "Televizorlar":
                $("#AllInputDiv").html(
                    ProductName + CarBrand + Color + New + Size + Delivery + PlaceOfResidence
                );
                break;
            case "Masaüstü komputerlər":
                $("#AllInputDiv").html(
                    ProductName + CarBrand + New + Delivery + PlaceOfResidence
                );
                break;
            case "Fototexnika":
                $("#AllInputDiv").html(
                    ProductName + CarBrand + Model + Color + New + Delivery + PlaceOfResidence
                );
                break;
            case "Planşetlər və elektron kitablar":
                $("#AllInputDiv").html(
                    ProductName + CarBrand + Model + Color + Size + New + Delivery + PlaceOfResidence
                );
                break;
            // Elektronika Stop

            //  Daşınmaz Əmlak Start
            case "Mənzillər":
                $("#AllInputDiv").html(
                    ProductName + ProductType + NumberOfRooms + M20TheHouse + BuildingType + BuildingFloor + PlaceOfResidence

                );
                break;
            case "Obyekt":
                $("#AllInputDiv").html(
                    ProductName + ProductType + NumberOfRooms + M20TheHouse + BuildingType + PlaceOfResidence

                );
                break;
            case "Xaricdə mülk":
                $("#AllInputDiv").html(
                    ProductName + ProductType + NumberOfRooms + M20TheHouse + BuildingType

                );
                break;
            case "Torpaq Sahəsi":
                $("#AllInputDiv").html(
                    ProductName + ProductType + LandOfSale + PlaceOfResidence
                );
                break;
            case "Villalar və Bağ Evləri":
                $("#AllInputDiv").html(
                    ProductName + ProductType + NumberOfRooms + M20TheHouse + LandOfSale + PlaceOfResidence
                );
                break;
            //  Daşınmaz Əmlak Stop

            // Neqliyyat Start
            case "Maşınlar":
                $("#AllInputDiv").html(
                    ProductName + CarBrand + Model + Color + EngineBox + CarBody + Year + CarMileageKm + ProductType
                );
                break;
            case "Traxtorlar":
                $("#AllInputDiv").html(
                    ProductName + CarBrand + Model + Color + Year + CarMileageKm + ProductType
                );
                break
            case "Helikopterlər":
                $("#AllInputDiv").html(
                    ProductName + CarBrand + Model + Color + Year + ProductType
                );
                break
            case "Qoşqular":
                $("#AllInputDiv").html(
                    ProductName + CarBrand + Color + Year + ProductType
                );
                break
            //  Neqliyyat Stop

            // Heyvanlar ve Yemleri Start
            case "Heyvanlar":
                $("#AllInputDiv").html(
                    Animals + ProductName
                );
                break;
            case "Heyvanlar üçün Yemlər":
                $("#AllInputDiv").html(
                    Feedsforanimals + ProductName
                );
                break;
            // Heyvanlar ve Yemleri Stop

            // Şəxsi Əşyaları Start
            case "Şəxsi geyimlər":
                $("#AllInputDiv").html(
                    Gender + ClothingType + Size + ProductName
                );
                break;
            case "Şəxsi aksesuarlar":
                $("#AllInputDiv").html(
                    Gender + ClothingType + ProductName
                );
                break;
            //  Şəxsi Əşyalar Stop


        }
        // Children's World - Uşaq Aləmi Start
        if (Category2 == "Oyuncaqlar" || Category2 == "Uşaq maşınları" || Category2 == "Yürütəclər" || Category2 == "Uşaq geyimləri" || Category2 == "Uşaq dekarasyon") {
            $("#AllInputDiv").html(
                ProductName + ProductType
            );
        }
        // Children's World - Uşaq Aləmi Stop
        // Ev və Bağ üçün Start
        if (Category2 == "Təmir işləri" || Category2 == "Mebellər" || Category2 == "Məişət əşyalar" || Category2 == "Ərzaq") {
            $("#AllInputDiv").html(
                TypeofGoods + ProductName
            );
        }

        // Ev və Bağ üçün Stop
        // Hobbies and Leisure - Hobbi və Asudə Start
        if (Category2 == "Kitablar və jurnallar" || Category2 == "Səyahətlər" || Category2 == "İdman avadanliqlar" || Category2 == "Velosipedlər" || Category2 == "Musiqi alətləri") {
            $("#AllInputDiv").html(
                ProductName + ProductType
            );
        };
        // Hobbies and Leisure - Hobbi və Asudə Stop
        // Biznes və Xidmətlər Start
        if (Category2 == "Hazır bizneslər" || Category2 == "Hazır biznes obyekt" || Category2 == "Biznes üçün avadanlıqlar") {
            $("#AllInputDiv").html(
                BusinessArea + ProductName
            );
        };

        // Biznes və Xidmətlər Stop
        // Jobs - İş Elanları Start
        if (Category2 == "İş axtaranlar" || Category2 == "Vakansiyalar") {
            $("#AllInputDiv").html(Jobs);
        }
        // Jobs - İş Elanları Stop

    });
})

// Product Name - Elan Adı
var ProductName = '<div class="InputDiv ProductName" asp-for="ProductName">' +
    '  <b class="InputName " >Elan Adı <i class="fa fa-star-of-life"></i></b>' +
    ' <input type="text" class="Input " name="ProductName" required>' +
    '</div>';
// Car Brand - Marka
var CarBrand = ' <div class="InputDiv CarBrand">' +
    '  <b class="InputName" >Marka <i class="fa fa-star-of-life"></i></b>' +
    '  <input type="text" class="Input" name="CarMake">' +
    '         </div>';
// Model 
var Model = '   <div class="InputDiv Model">' +
    '        <b class="InputName">Model <i class="fa fa-star-of-life"></i></b>' +
    '       <input type="text" class="Input" name="ProductModel">' +
    '         </div>';
// Color - Rəng
var Color = '      <div class="InputDiv Color">' +
    '          <b class="InputName" >Rəngi</b>' +
    '          <input type="text" class="Input" name="Color">' +
    '         </div>';

// Engine Box - Mühərriklər Qutusu
var EngineBox = '<div class="InputDiv EngineBox">' +
    '             <b class="InputName" >Mühərriklər sm3<i class="fa fa-star-of-life"></i></b>' +
    '            <input type="number" class="Input" min="100" step="100" name="CarEngineBox" placeholder="1800">' +
    '        </div>' +
    '       <div class="InputDiv VehicleFuelType">' +
    '            <b class="InputName" >Yanacaq Növü<i class="fa fa-star-of-life"></i></b>' +
    '           <select class="Input" name="VehicleFuelType">' +
    '               <option value=""></option>' +
    '               <option value="Benzin">Benzin</option>' +
    '               <option value="Dizel">Dizel</option>' +
    '               <option value="Elektrikli">Elektrikli</option>' +
    '              <option value="Hibrit">Hibrit</option>' +
    '           </select>' +
    '       </div>';
// Car Body - Maşın Kuzov
var CarBody = '       <div class="InputDiv  CarBody">' +
    '           <b class="InputName" >Kuzov<i class="fa fa-star-of-life"></i></b>' +
    '           <input type="text" class="Input" name="CarBody">' +
    '      </div>';
// Year  - İli
var Year = '           <div class="InputDiv  Year">' +
    '               <b class="InputName" >İli<i class="fa fa-star-of-life"></i></b>' +
    '               <input type="number" min="1800" class="Input" name="Year" placeholder="2023">' +
    '     </div>';
// Car Mileage Km - Yürüş Km
var CarMileageKm = '               <div class="InputDiv  CarMileageKm" >' +
    '                   <b class="InputName">Yürüş km<i class="fa fa-star-of-life"></i></b>' +
    '                    <input type="number" min="0" name="CarMileagekm" class="Input">' +
    '       </div>';
// Product Type - Elan Növü
var ProductType = ' <div class="InputDiv  ProductType">' +
    ' <b class="InputName" >Elan Növü<i class="fa fa-star-of-life"></i></b>' +
    ' <select class="Input" name="RentForSale">' +
    '   <option value="">Siyahıdan seçin</option>' +
    '  <option value="Satılır">Satılır</option>' +
    ' <option value="Kirayə">Kirayə</option>' +
    ' </select>' +
    ' </div>';
// Place Of Residence - Ərazi
var PlaceOfResidence = '  <div class="InputDiv PlaceOfResidence">' +
    '<b class="InputName">Ərazi</b>' +
    ' <input type="text" class="Input" name="PlaceOfResidence">' +
    '  </div>';
// land Of Sale  - Sahə Sot
var LandOfSale = '  <div class="InputDiv LandOfSale">' +
    ' <b class="InputName" >Sahə Sot <i class="fa fa-star-of-life"></i></b>' +
    ' <input type="number" min="0" class="Input"  name="LandForSale" placeholder="120">' +
    ' </div>';
//  Number Of Rooms - Otaq Sayısı
var NumberOfRooms = '   <div class="InputDiv NumberOfRooms">' +
    '  <b class="InputName" > Otaq Sayısı <i class="fa fa-star-of-life"></i></b>' +
    '  <input type="number" min="1"  max="30" class="Input" name="NumberOfRooms">' +
    '  </div>';
// M 20 The House
var M20TheHouse = '    <div class="InputDiv M2OTheHouse">' +
    '  <b class="InputName" >m2 <i class="fa fa-star-of-life"></i></b>' +
    '  <input type="number" min="1" class="Input" placeholder="100 m2" name="Fieldm2">' +
    ' </div>';
// Building Type - Bina Yeni?
var BuildingType = '  <div class="InputDiv  BuildingType">' +
    '   <b class="InputName">Bina Yeni?</b>' +
    '<span class="Inputcheckbox" >' +
    '<input type="checkbox" name="BuildingType"> <span>Bina Yeni?</span>' +
    '</span>' +
    '    </div>';
//  Building Floor - Mərtəbə
var BuildingFloor = '  <div class="InputDiv BuildingFloor">' +
    ' <b class="InputName"> Mərtəbə <i class="fa fa-star-of-life"></i></b>' +
    '  <input type="text" class="Input" name="BuildingFloor" placeholder="15/10">' +
    ' </div>';
//  New Yeni
var New = '   <div class="InputDiv">' +
    ' <b class="InputName" >Yeni? </b>' +
    ' <span class="Inputcheckbox" >' +
    ' <input type="checkbox" name="ProductNew"> <span>Yeni?</span> ' +
    '</span>' +
    ' </div>';

// Delivery - Çatdırılma
var Delivery = '<div class="InputDiv Delivery">' +
    '<b class="InputName" >Çatdırılma</b>' +
    '   <span class="Inputcheckbox" >' +
    '<input type="checkbox"> <span>Çatdırılma?</span> ' +
    '</span>' +
    '</div>';
//  Type of Goods - Malın növü
var TypeofGoods = '  <div class="InputDiv">' +
    ' <b class="InputName"> Malın növü <i class="fa fa-star-of-life"></i></b>' +
    '  <input type="text" class="Input" name="TypeOfGoods" placeholder="malın növünü qeyd edin">' +
    ' </div>';
//  Business Area - Biznes Sahəsi
var BusinessArea = '  <div class="InputDiv">' +
    ' <b class="InputName"> Biznes Sahəsi <i class="fa fa-star-of-life"></i></b>' +
    '  <input type="text" class="Input" name="BusinessArea" placeholder="biznes sahəsini qeyd edin">' +
    ' </div>';
// Job - İş Elanları
var Jobs = '<div class="InputDiv " >' +
    '<b class="InputName"> Fəaliyyət sahəsi <i class="fa fa-star-of-life"></i></b>' +
    '<select class="Input" name="WorkArea">' +
    '   <option value="">Siyahıdan seçin</option>' +
    '   <option value="Avtobiznes və servis">Avtobiznes və servis</option>' +
    '   <option value="Dizayn">Dizayn</option>' +
    '   <option value="Ev personalı və təmizlik">Ev personalı və təmizlik</option>' +
    '   <option value="Gözəllik, Fitness, İdman">Gözəllik, Fitness, İdman</option>' +
    '   <option value="HR, kadrlar">HR, kadrlar</option>' +
    '   <option value="Hüquqşünaslıq">Hüquqşünaslıq</option>' +
    '   <option value="İnformasiya texnologiyaları, telekom">İnformasiya texnologiyaları, telekom</option>' +
    '   <option value="İnzibati heyət">İnzibati heyət</option>' +
    '   <option value="Maliyyə">Maliyyə</option>' +
    '   <option value="Marketinq, reklam, PR">Marketinq, reklam, PR</option>' +
    '   <option value="Nəqliyyat, loqistika, anbar">Nəqliyyat, loqistika, anbar</option>' +
    '   <option value="Restoran işi və turizm">Restoran işi və turizm</option>' +
    '   <option value="Satış">Satış</option>' +
    '   <option value="Sənaye və istehsalat">Sənaye və istehsalat</option>' +
    '   <option value="Təhlükəsizlik">Təhlükəsizlik</option>' +
    '   <option value="Təhsil və elm">Təhsil və elm</option>' +
    '   <option value="Tibb və əczaçılıq">Tibb və əczaçılıq</option>' +
    '   <option value="Tikinti və təmir">Tikinti və təmir</option>' +
    ' </select></div>' + '<div class="InputDiv" >' +
    '<b class="InputName"> İş Grafiki <i class="fa fa-star-of-life"></i></b>' +
    '<select class="Input" name="WorkSchedule">' +
    '   <option value="">Siyahıdan seçin</option>' +
    '   <option value="Tam">Tam</option>' +
    '   <option value="Natamam">Natamam</option>' +
    '   <option value="Növbəli">Növbəli</option>' +
    '   <option value="Sərbəst">Sərbəst</option>' +
    ' </select>' +
    '</div>' + '<div class="InputDiv" >' +
    '<b class="InputName"> Çalışma <i class="fa fa-star-of-life"></i></b>' +
    '<select class="Input" name="WorkPlace">' +
    '   <option value="">Siyahıdan seçin</option>' +
    '   <option value="İş Yerində">İş Yerində</option>' +
    '   <option value="Uzaqdan">Uzaqdan</option>' +
    '   <option value="Fərqi yoxdur">Fərqi yoxdur</option>' +
    ' </select>' +
    '</div>' +
    '<div class="InputDiv" >' +
    '<b class="InputName"> Təhsil <i class="fa fa-star-of-life"></i></b>' +
    '<select class="Input" name="Edaction">' +
    '   <option value="">Siyahıdan seçin</option>' +
    '   <option value="Ali">Ali</option>' +
    '   <option value="Natamam ali">Natamam ali</option>' +
    '   <option value="Orta texniki">Orta texniki</option>' +
    '   <option value="Orta xüsusi">Orta xüsusi</option>' +
    '   <option value="Orta">Orta</option>' +
    ' </select>' +
    '</div>' + ProductName;


// Animals - Heyvanlar
var Animals = '<div class="InputDiv" >' +
    '<b class="InputName"> Cinsi <i class="fa fa-star-of-life"></i></b>' +
    '  <input type="text" class="Input" name="AnimalSpecies" placeholder="Cinsi qeyd edin">' +
    '</div>';

//Feedsforanimals - Heyvanlar üçün Yemlər
var Feedsforanimals = '<div class="InputDiv" >' +
    '<b class="InputName"> Yemin Adı <i class="fa fa-star-of-life"></i></b>' +
    '  <input type="text" name="FeedsforAnimals" class="Input" placeholder="Yemin adını qeyd edin">' +
    '</div>';

// Gender - Cinsiyyət 
var Gender = '<div class="InputDiv" >' +
    '<b class="InputName"> Cinsiyyət <i class="fa fa-star-of-life"></i></b>' +
    '<select class="Input" name="Gender">' +
    '   <option value="">Siyahıdan seçin</option>' +
    '   <option value="Kişilər">Kişilər</option>' +
    '   <option value="Qadınlar">Qadınlar</option>' +
    '   <option value="Hamı üçün">Hamı üçün</option>' +
    ' </select>' +
    '</div>';
// Clothing Type - Geyim  Növü
var ClothingType = '<div class="InputDiv" >' +
    '<b class="InputName"> Geyim növü <i class="fa fa-star-of-life"></i></b>' +
    '<select class="Input" name="ClothingType">' +
    '   <option value="">Siyahıdan seçin</option>' +
    '   <option value="Klassik">Klassik</option>' +
    '   <option value="Sport">Sport</option>' +
    ' </select>' +
    '</div>';

// Size - Ölçü
var Size = '<div class="InputDiv" >' +
    '<b class="InputName"> Ölçü <i class="fa fa-star-of-life"></i></b>' +
    '  <input type="text" class="Input" name="Size" placeholder="ölçüsünü qeyd edin">' +
    '</div>';



window.onload = function () {
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





var Img1=document.getElementById("Img1");
var Img2=document.getElementById("Img2");
var Img3=document.getElementById("Img3");
var Img4=document.getElementById("Img4");
var Img5=document.getElementById("Img5");
var Img6=document.getElementById("Img6");
var Img7=document.getElementById("Img7");
var Img8=document.getElementById("Img8");
var Img9=document.getElementById("Img9");
var Img10=document.getElementById("Img10");


Img1.addEventListener('change',(events)=>{
if(Img1.textContent !=null){
    Img1.style.display="none";
   Img2.style.display="Block";
document.querySelector(".LabelImg1").style.display="none";
document.querySelector(".LabelImg2").style.display="block";

}
});
Img2.addEventListener('change',(events)=>{
   if(Img2.textContent !=null){
    Img2.style.display="none";
      Img3.style.display="Block";
    document.querySelector(".LabelImg2").style.display="none";
document.querySelector(".LabelImg3").style.display="block";

   }
   });
   Img3.addEventListener('click',(events)=>{
      if(Img3.textContent !=null){
        Img3.style.display="none";
         Img4.style.display="Block";
        document.querySelector(".LabelImg3").style.display="none";
document.querySelector(".LabelImg4").style.display="block";
      }
      });

      Img4.addEventListener('click',(events)=>{
         if(Img4.textContent !=null){
            Img4.style.display="none";
            Img5.style.display="Block";
            document.querySelector(".LabelImg4").style.display="none";
document.querySelector(".LabelImg5").style.display="block";
         }
         });

         Img5.addEventListener('click',(events)=>{
            if(Img5.textContent !=null){
                Img5.style.display="none";
               Img6.style.display="Block";
               document.querySelector(".LabelImg5").style.display="none";
document.querySelector(".LabelImg6").style.display="block";
            }
            });
      Img6.addEventListener('click',(events)=>{
      if(Img6.textContent !=null){
        Img6.style.display="none";
         Img7.style.display="Block";
         document.querySelector(".LabelImg6").style.display="none";
document.querySelector(".LabelImg7").style.display="block";
      }
   });
      Img7.addEventListener('click',(events)=>{
         if(Img7.textContent !=null){
            Img7.style.display="none";
            Img8.style.display="Block";
            document.querySelector(".LabelImg7").style.display="none";
document.querySelector(".LabelImg8").style.display="block";
         }
         });
     
         Img8.addEventListener('click',(events)=>{
            if(Img8.textContent !=null){
                Img8.style.display="none";
               Img9.style.display="Block";
               document.querySelector(".LabelImg8").style.display="none";
document.querySelector(".LabelImg9").style.display="block";
            }
            });
            Img9.addEventListener('click',(events)=>{
               if(Img9.textContent !=null){
                Img9.style.display="none";
                  Img10.style.display="Block";
                  document.querySelector(".LabelImg9").style.display="none";
document.querySelector(".LabelImg10").style.display="block";
               }
               });
               

   var phone1 = document.getElementById("phone");
   var phone2 = document.getElementById("Phone2");
   phone1.addEventListener('change',(events)=>{
if(phone1.textContent !=null){
   phone2.style.display="Block";
}

   });

   let imgInput1 = document.getElementById('image-input1');
   let imgInput2 = document.getElementById('image-input2');
   let imgInput3 = document.getElementById('image-input3');
   let imgInput4 = document.getElementById('image-input4');
   let imgInput5 = document.getElementById('image-input5');
   let imgInput6 = document.getElementById('image-input6');
   let imgInput7 = document.getElementById('image-input7');
   let imgInput8 = document.getElementById('image-input8');
   let imgInput9 = document.getElementById('image-input9');
   let imgInput10 = document.getElementById('image-input10');
  
   

   let img1=document.getElementById("preview1");
   let img2=document.getElementById("preview2");
   let img3=document.getElementById("preview3");
   let img4=document.getElementById("preview4");
   let img5=document.getElementById("preview5");
   let img6=document.getElementById("preview6");
   let img7=document.getElementById("preview7");
   let img8=document.getElementById("preview8");
   let img9=document.getElementById("preview9");
   let img10=document.getElementById("preview10");

  
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
  imgInput3.addEventListener('change', function (e) {
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
               document.getElementById("preview3").src = dataurl;
           }
           img3.src = e.target.result;
       }
       reader.readAsDataURL(imageFile);
   }
});
imgInput4.addEventListener('change', function (e) {
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
               document.getElementById("preview").src = dataurl;
           }
           img4.src = e.target.result;
       }
       reader.readAsDataURL(imageFile);
   }
});
imgInput5.addEventListener('change', function (e) {
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
               document.getElementById("preview5").src = dataurl;
           }
           img5.src = e.target.result;
       }
       reader.readAsDataURL(imageFile);
   }
});
imgInput6.addEventListener('change', function (e) {
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
               document.getElementById("preview6").src = dataurl;
           }
           img6.src = e.target.result;
       }
       reader.readAsDataURL(imageFile);
   }
});
imgInput7.addEventListener('change', function (e) {
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
               document.getElementById("preview7").src = dataurl;
           }
           img7.src = e.target.result;
       }
       reader.readAsDataURL(imageFile);
   }
});
imgInput8.addEventListener('change', function (e) {
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
               document.getElementById("preview8").src = dataurl;
           }
           img8.src = e.target.result;
       }
       reader.readAsDataURL(imageFile);
   }
});
imgInput9.addEventListener('change', function (e) {
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
               document.getElementById("preview9").src = dataurl;
           }
           img9.src = e.target.result;
       }
       reader.readAsDataURL(imageFile);
   }
});
imgInput10.addEventListener('change', function (e) {
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
               document.getElementById("preview10").src = dataurl;
           }
           img10.src = e.target.result;
       }
       reader.readAsDataURL(imageFile);
   }
});


var inputcheckbox1=document.querySelector(".inputcheckbox1");
var BuildingTypevalue=document.querySelector(".BuildingTypevalue");
var checkbox1 = document.querySelector(".checkbox1");
inputcheckbox1.addEventListener('change',function(){
    if(inputcheckbox1.checked == true){
        BuildingTypevalue.value="Bəli";
    }else{
        BuildingTypevalue.value="Xeyir";
    }
    });

var inputcheckbox2=document.querySelector(".inputcheckbox2");
var checkbox2 = document.querySelector(".checkbox2");
var Yearvalue=document.querySelector(".Yearvalue");


inputcheckbox2.addEventListener('change',function(){
    if(inputcheckbox2.checked == true){
        Yearvalue.value="Bəli";
    }else{
        Yearvalue.value="Xeyir";
    }
    });
var inputcheckbox3 = document.querySelector(".inputcheckbox3");
var Deliveryvalue=document.querySelector(".Deliveryvalue");
var checkbox3 = document.querySelector(".checkbox3");


    inputcheckbox3.addEventListener('change',function(){
        if(inputcheckbox3.checked == true){
            Deliveryvalue.value="Var";
        }else{
            Deliveryvalue.value="Yox";
        }
        });

        var CommentStatusCheckbox = document.querySelector(".CommentStatusCheckbox");
var CommentStatusValue=document.querySelector(".CommentStatusValue");



CommentStatusCheckbox.addEventListener('change',function(){
        if(CommentStatusCheckbox.checked == true){
            CommentStatusValue.value="Active";
        }else{
            CommentStatusValue.value="Passive";
        }
        }); 