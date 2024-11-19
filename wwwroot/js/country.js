let countries = [
    { id: 1, name: "Argentina", url: "customurl" },
    { id: 2, name: "Belgium", url: "customurl" },
    { id: 3, name: "China", url: "customurl" },
    { id: 4, name: "Finland", url: "customurl" },
    { id: 5, name: "Hong kong", url: "customurl" }
];

$(function () {
    createCountryDropdown();
});

function createCountryDropdown() {
    var countryDropdown = document.getElementById("countriesDropdownActual");
    countryDropdown.innerHTML = "";

    $.each(countries, function (index, country) {

        var li = document.createElement('li');
        var a = document.createElement('a');
        a.setAttribute('class', 'dropdown-item');
        a.setAttribute('href', country.url);
        a.setAttribute('id', 'country-' + country.id);
        a.innerText = country.name;
        li.appendChild(a);
        countryDropdown.appendChild(li);
    });
}

