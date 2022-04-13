function myFunction() {
    document.getElementById("myDropdown").classList.toggle("show");
}

// Close the dropdown if the user clicks outside of it

window.addEventListener("click", ({ target }) => {
    const dropdowns = document.getElementsByClassName("dropdown-content");
    if (!target.matches('.dropbtn')) {
        for (let i = 0; i < dropdowns.length; i++) {
            if (dropdowns[i].classList.contains('show')) {
                dropdowns[i].classList.remove('show');
            }
        }
    }
})
