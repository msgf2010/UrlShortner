$(() => {
    $("#submit").on('click', () => {
        const urlOrigin = $("#url-origin").val();
        $.post('/home/ShortenUrl', { UrlOriginal: urlOrigin }, function (UrlShortened) {
            $("#url-result").val(UrlShortened);
        });
    });
});