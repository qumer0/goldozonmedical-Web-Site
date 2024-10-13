
var hamburgerButton = document.getElementById("hamburgerbutton")
var ham = document.querySelector(".hamburgercontainer")
var products = document.getElementById("goToProducts")



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




document.addEventListener('DOMContentLoaded', function () {
    // İlk profil fotoğrafı için
    var profilePhoto1 = document.getElementById('profilePhoto1');
    var userOptions1 = document.getElementById('userOptions1');

    profilePhoto1.addEventListener('click', function () {
        if (userOptions1.style.display === 'none' || userOptions1.style.display === '') {
            userOptions1.style.display = 'block';
        } else {
            userOptions1.style.display = 'none';
        }
    });

    // İkinci profil fotoğrafı için
    var profilePhoto2 = document.getElementById('profilePhoto2');
    var userOptions2 = document.getElementById('userOptions2');

    profilePhoto2.addEventListener('click', function () {
        if (userOptions2.style.display === 'none' || userOptions2.style.display === '') {
            userOptions2.style.display = 'block';
        } else {
            userOptions2.style.display = 'none';
        }
    });
});
