function toBase64(element) {
    var file = element.files[0];
    var reader = new FileReader();

    reader.onloadend = function() {
        document.getElementById("photo").src = reader.result;
    }
    reader.readAsDataURL(file);
}

window.saveImage = (imgId) => { 
    return document.getElementById(imgId).src;
}
