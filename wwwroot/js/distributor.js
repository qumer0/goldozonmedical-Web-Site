function loadDistricts() {
    var selectedCity = document.getElementById("cityDropdown").value;
    var districtDropdown = document.getElementById("districtDropdown");

    // İlçeleri sıfırla
    districtDropdown.innerHTML = "<option value=''>Tüm İlçeler</option>";

    if (selectedCity) {
        // AJAX ile ilçeleri yükle
        fetch('/Distributor/GetDistricts?cityName=' + selectedCity)
            .then(response => response.json())
            .then(data => {
                data.forEach(district => {
                    var option = document.createElement("option");
                    option.value = district.name;
                    option.text = district.name;
                    districtDropdown.add(option);
                });
            });
    }
}