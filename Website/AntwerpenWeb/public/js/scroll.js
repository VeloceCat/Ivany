// ===== Scroll to Top ==== 
$(window).scroll(function() {
    if ($(this).scrollTop() >= 1) {        // If page is scrolled more than 50px
        $('#scroll').fadeIn(200);    // Fade in the arrow
    } else {
        $('#scroll').fadeOut(200);   // Else fade out the arrow
    }
});


$('#scroll').click(function() {      // When arrow is clicked
    $('body,html').animate({
        scrollTop : 0                       // Scroll to top of body
    }, 500);
});