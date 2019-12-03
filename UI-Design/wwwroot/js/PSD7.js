$(document).ready(function(){
	slideShow();
	$('.carousel').carousel({
		interval: 1000
	});
	$('.warp_info').hover(function(){
		$(this).find('.info_menu')[0].style.display= "block";
		$(this).find('.info_menu')[0].className+=" animationplay";
	},
	function(){
		$(this).find('.info_menu')[0].style.display= "none";}
	);
    $('.booktable').hover(function(){
        $('.booktable a')[0].style.color= 'white';
    }, function(){
        $('.booktable a')[0].style.color= '#383838';
    });
})
	var slideIndex = 0;
	var slideShow = () => {
		console.log(slideIndex);
		var slide = $('.intro-slider');
        slideIndex++;
        var x = $('.alt_slide');
		if(slideIndex > slide.length){
			slideIndex = 1;
		}
		for(var i = 0; i<slide.length; i++){
			slide[i].style.display = 'none';
		}
        slide[slideIndex - 1].style.display = 'block';
        setTimeout(2000, x.slideDown('slow'));
		setTimeout(slideShow, 5500);
	}

