
var hamburgerButton = document.getElementById("hamburgerbutton")
var ham = document.querySelector(".hamburgercontainer")



function toggleMenu() {
    
    var xKonumu = ham.getBoundingClientRect().left;
    if(xKonumu<= -250){
        
        ham.style.transform = 'translate(249px,0px)';  // 250px sağa
        ham.style.transition = 'transform 0.6s ease-out';  // Yumuşak geçiş için transition
        hamburgerButton.style.transform = 'rotate(-90deg)'
        hamburgerButton.style.transition = 'transform 0.6s ease'; 
    }
    else{
        ham.style.transform = 'translate(-249px, 0px)';  // 250px sola
        ham.style.transition = 'transform 0.6s ease-in';  // Yumuşak geçiş için transition
        hamburgerButton.style.transform = 'rotate(0deg)'
        hamburgerButton.style.transition = 'transform 0.6s ease'; 
    }
    
}

// Menü dışına tıklanıldığında kapat
document.addEventListener('click', function (event) {
    
    var xKonumu = ham.getBoundingClientRect().left;
    // Eğer tıklanan alan hamburger menüsü veya menü tuşu değilse menüyü kapat
    if(xKonumu > -250){
        if (!ham.contains(event.target) && !hamburgerButton.contains(event.target)) {
            toggleMenu();
        }
    }
    
});





hamburgerButton.addEventListener('click', function (event) {
    event.stopPropagation();  // Tıklamanın menüyü kapatmaması için gerekli
    toggleMenu();
});

