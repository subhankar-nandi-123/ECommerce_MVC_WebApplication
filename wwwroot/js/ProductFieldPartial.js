

function toggleHeartDefault(ele) {
    ele.style.display = "none";
    ele.parentNode.getElementsByClassName("heart-fill")[0].style.display = "flex";
}

function toggleHeartFill(ele) {
    ele.style.display = "none";
    ele.parentNode.getElementsByClassName("heart-default")[0].style.display = "flex";
}