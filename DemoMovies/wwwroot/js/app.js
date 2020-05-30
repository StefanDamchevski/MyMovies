function openNav() {
    document.getElementById("mySidenav").style.width = "11%";
    document.getElementById("barContainer").style.display = "none";
}

function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
    document.getElementById("barContainer").style.display = "block";
}

window.onscroll = function () { StickyNav() };

var header = document.getElementById("barContainer");

var sticky = header.offsetTop;

function StickyNav() {
    if (window.pageYOffset >= sticky) {
        header.classList.add("sticky");
    } else {
        header.classList.remove("sticky");
    }
}