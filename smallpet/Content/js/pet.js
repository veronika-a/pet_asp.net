
(function ($) {
    $(function () {
        $('.menu__icon').on('click', function () {
            $(this).closest('.menu').toggleClass('menu_state_open');
        });
    });
})(jQuery);

$('.lead').hover(
    function () {
        $(this).fadeTo('slow', 0.5);
    },
    function () {
        $(this).fadeTo('normal', 1);
    }
);
$(window).scroll(function () {
    if ($(this).scrollTop() >= 1200) {

        $('.scrollup').fadeIn('slow', 'linear');
    }
    else {
        $('.scrollup').fadeOut('fast', 'swing');
    }
});

jQuery(document).ready(function ($) {
    //open popup
    $('.cd-popup-trigger').on('click', function (event) {
        event.preventDefault();
        $('.cd-popup').addClass('is-visible');
    });

    //close popup
    $('.cd-popup').on('click', function (event) {
        if ($(event.target).is('.cd-popup-close') || $(event.target).is('.cd-popup')) {
            event.preventDefault();
            $(this).removeClass('is-visible');
        }
    });
    //close popup when clicking the esc keyboard button
    $(document).keyup(function (event) {
        if (event.which == '27') {
            $('.cd-popup').removeClass('is-visible');
        }
    });
});