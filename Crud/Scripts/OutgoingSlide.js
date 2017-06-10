(function () {
    var screenWidth = screen.width;
    var $outgoingWrapper = $('.Outgoing-Wrapper');
    if (screenWidth < 2 * 500) {
        alert(screenWidth);
        $('.Outgoing-Box')
            .css({
                'width': screenWidth 
            });
        $outgoingWrapper.scrollLeft(-200);

    }
    var enableScrolling = false;
    var startPos;
    var currentScrollPos;
    
    $outgoingWrapper.on("swipeleft", function (event) {
        var value = $outgoingWrapper.scrollLeft() + screenWidth;
        $outgoingWrapper.animate( {
               scrollLeft:value
            },
            "slow");
        
    });
    $outgoingWrapper.on("swiperight", function (event) {
        var value = $outgoingWrapper.scrollLeft() - screenWidth;
        $outgoingWrapper.animate({
            scrollLeft: value
        },
            "slow");
        
    });
    
   $outgoingWrapper.on("mousedown", function (event) {
        enableScrolling = true;
        startPos = event.pageX;
        currentScrollPos = $outgoingWrapper.scrollLeft();
    });
    $(document).on("mouseup", function () {
        if (enableScrolling) {
            enableScrolling = false;
        }

    });
   $outgoingWrapper.on("mousemove", function (event) {
        if (enableScrolling) {
            $('h2').text(startPos - event.pageX);
           $outgoingWrapper.scrollLeft(currentScrollPos - (event.pageX - startPos));
        }
    });
})();
