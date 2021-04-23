function toBase64(elementId) {
    const fileInput = document.getElementById(elementId);
    
    const file = fileInput.files[0];

    const reader = new FileReader();
    reader.readAsDataURL(file);
    reader.onloadend = () => {
        const base64String = reader.result;
        return base64String;
    };

    return ""
}