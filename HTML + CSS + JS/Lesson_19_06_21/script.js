

let context = document.querySelector('.context');



document.addEventListener('contextmenu', function () {
    event.preventDefault();
    console.dir(event);
    console.log(event.screenX);
    console.log(event.screenY);
    context.style.top = event.screenY + 'px';
    context.style.left = event.screenX + 'px';
    context.style.display = "flex";
});