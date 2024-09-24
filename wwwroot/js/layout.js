
var hamburgerButton = document.getElementById("hamburgerbutton")




function toggleMenu() {
    var ham = document.querySelector(".hamburgercontainer")
    var xKonumu = ham.getBoundingClientRect().left;
    if(xKonumu<= -250){
        
        ham.style.transform = 'translate(249px,0px)';  // 250px sağa
        ham.style.transition = 'transform 0.8s ease-out';  // Yumuşak geçiş için transition
    }
    else{
        ham.style.transform = 'translate(-249px, 0px)';  // 250px sola
        ham.style.transition = 'transform 0.8s ease-in';  // Yumuşak geçiş için transition
    }
    
}

// Menü dışına tıklanıldığında kapat
document.addEventListener('click', function (event) {
    var ham = document.querySelector(".hamburgercontainer")
    // Eğer tıklanan alan hamburger menüsü veya menü tuşu değilse menüyü kapat
    if (!ham.contains(event.target) && !hamburgerButton.contains(event.target)) {
        toggleMenu();
    }
});





hamburgerButton.addEventListener('click', function (event) {
    event.stopPropagation();  // Tıklamanın menüyü kapatmaması için gerekli
    toggleMenu();
});