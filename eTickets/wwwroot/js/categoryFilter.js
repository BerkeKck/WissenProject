$(document).ready(function () {

    var urlParams = new URLSearchParams(window.location.search);
    var categoryId = urlParams.get('categoryId');

    // Set the selected category in the dropdown if categoryId is found in the query string
    if (categoryId) {
        $('#category').val(categoryId);
    }
    $('#searchButton').click(function () {
        var selectedCategory = $('#category').val();

        var query = '';
        if (selectedCategory) {
            query += 'categoryId=' + selectedCategory;
        }

        if (query) {
            window.location.href = '/AdminPanel/MovieList?' + query;
        } else {
            window.location.href = '/AdminPanel/MovieList';
        }
    });
});