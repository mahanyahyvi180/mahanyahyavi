$(document).ready(function() {

var owl = $("#owl-product");

owl.owlCarousel({

    item : 1,
    responsive : {

        480 : {item : 1},
        768 : {item : 2},
       1024 : {item : 3},
       1200 : {item : 4},


    },


}) ;


});