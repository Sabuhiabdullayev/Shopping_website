<div class="InputDiv ProductName">
    <b class="InputName " >Elan Adı <i class="fa fa-star-of-life"></i></b>
    <input type="text" class="Input " asp-for="ProductName" required>
               </div>
    <div class="InputDiv CarBrand">
        <b class="InputName" >Marka <i class="fa fa-star-of-life"></i></b>
        <input type="text" class="Input" asp-for="CarMake">
               </div>
        <div class="InputDiv Model">
            <b class="InputName">Model <i class="fa fa-star-of-life"></i></b>
            <input type="text" class="Input" asp-for="ProductModel">
               </div>
            <div class="InputDiv Color">
                <b class="InputName" >Rəngi</b>
                <input type="text" class="Input" asp-for="Color">
               </div>
                <div class="InputDiv EngineBox">
                    <b class="InputName" >Mühərriklər sm3<i class="fa fa-star-of-life"></i></b>
                    <input class="Input" asp-for="CarEngineBox">
                       
                </div>
                <div class="InputDiv VehicleFuelType">
                    <b class="InputName" >Yanacaq Növü<i class="fa fa-star-of-life"></i></b>
                    <select class="Input" asp-for="VehicleFuelType">
                        <option value=""></option>
                        <option value="Benzin">Benzin</option>
                        <option value="Dizel">Dizel</option>
                        <option value="Elektrikli">Elektrikli</option>
                        <option value="Hibrit">Hibrit</option>
                    </select>
                </div>
                <div class="InputDiv  CarBody">
                    <b class="InputName" >Kuzov<i class="fa fa-star-of-life"></i></b>
                    <input type="text" class="Input" asp-for="CarBody">
               </div>
                    <div class="InputDiv  Year">
                        <b class="InputName" >İli<i class="fa fa-star-of-life"></i></b>
                        <input type="number" min="1800" class="Input" asp-for="Year" placeholder="2023">
               </div>
                        <div class="InputDiv  CarMileageKm" >
                            <b class="InputName">Yürüş km<i class="fa fa-star-of-life"></i></b>
                            <input type="number" min="0" asp-for="CarMileagekm" class="Input">
               </div>
                            <div class="InputDiv  BuildingType">
                                <b class="InputName">Bina Yeni?</b>
                                <div class="checkbox-wrapper-39">
                                    <label>
                                        <input type="checkbox" class="inputcheckbox1" />
                                        <span class="checkbox1"></span>
                                        <input type="hidden" value="Xeyir" asp-for="BuildingType" class="BuildingTypevalue">
                    </label>
                  </div>
                                </div>
                                <div class="InputDiv  ProductType">
                                    <b class="InputName" >Elan Növü<i class="fa fa-star-of-life"></i></b>
                                    <select class="Input" asp-for="RentForSale">
                                        <option value="Satılır">Satılır</option>
                                        <option value="Kirayə">Kirayə</option>
                                    </select>
                                </div>
                                <div class="InputDiv LandOfSale">
                                    <b class="InputName" >Sahə Sot <i class="fa fa-star-of-life"></i></b>
                                    <input type="number" min="0" class="Input" placeholder="120" asp-for="LandForSale">
               </div>
                                    <div class="InputDiv BuildingFloor">
                                        <b class="InputName"> Mərtəbə <i class="fa fa-star-of-life"></i></b>
                                        <input type="text" class="Input" placeholder="15/10" asp-for="BuildingFloor">
               </div>
                                        <div class="InputDiv M2OTheHouse">
                                            <b class="InputName" >Evin m2 <i class="fa fa-star-of-life"></i></b>
                                            <input type="number" min="1" class="Input" placeholder="100" asp-for="Fieldm2">
               </div>
                                            <div class="InputDiv NumberOfRooms">
                                                <b class="InputName" > Otaq Sayısı <i class="fa fa-star-of-life"></i></b>
                                                <input type="number" min="1" class="Input" placeholder="2" asp-for="NumberOfRooms">
                                            </div>
                                            <div class="InputDiv New">
                                                <b class="InputName" >Yeni? </b>
                                                <div class="checkbox-wrapper-39">
                                                    <label>
                                                        <input type="checkbox" class="inputcheckbox2" />
                                                        <span class="checkbox2"></span>
                                                        <input type="hidden" value="Xeyir" asp-for="ProductNew" class="Yearvalue">
                    </label>
                  </div>

                                                </div>

                                                <div class="InputDiv Delivery">
                                                    <b class="InputName" >Çatdırılma</b>
                                                    <div class="checkbox-wrapper-39">
                                                        <label>
                                                            <input type="checkbox" class="inputcheckbox3" />
                                                            <span class="checkbox3"></span>
                                                            <input type="hidden" value="Xeyir" asp-for="Delivery" class="Deliveryvalue">
                    </label>
                  </div>
                                                    </div>