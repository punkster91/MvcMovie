// create a list of genres
// display them in the navbar

let genres = [
    { id: 1, name: "Action", url: "customurl" },
    { id: 2, name: "Animation", url: "customurl" },
    { id: 3, name: "Crime", url: "customurl" },
    { id: 4, name: "Family", url: "customurl" },
    { id: 5, name: "Horror", url: "customurl" }
];

// A utility class for genres
class GenreUtils {
    static getName(id) {
        const genre = genres.find(genre => genre.id === id);
        return genre.name;
    }
}

$(function () {
    createGenresDropdown();
});

function createGenresDropdown() {
    var genreDropdown = document.getElementById("genreDropdownActual");
    genreDropdown.innerHTML = "";

    $.each(genres, function (index, genre) {
        //  <li><a class="dropdown-item" href="#">Action</a></li>
        var li = document.createElement('li');
        var a = document.createElement('a');
        a.setAttribute('class', 'dropdown-item');
        a.setAttribute('href', genre.url);
        a.setAttribute('id', 'genre-' + genre.id);
        a.innerText = genre.name;
        li.appendChild(a);
        genreDropdown.appendChild(li);
    });
}