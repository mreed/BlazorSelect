window.BlazorSelect = {
    getScrollWidth: function (element) {
        console.log(`ScrollWidth: ${element.scrollWidth}`);
        return element.scrollWidth;
       
    },
    changeWidth: function (element, width) {
        console.log(`changeWidth: ${element} width = ${width}`);
        element.style.width = width;
        console.log(`${element} width = ${element.style.width}`);
    },
    hasActiveChild: function (element) {
        console.log(document.activeElement);
        let result = element.contains(document.activeElement);
        console.log(`does element contain activeElement? ${result}`);
        return result;
    },
    focusElement: function (element) {
        element.focus();
    },
    getKey: function (objRef, element) {
        console.log("getKey");
        element.onkeydown = function (event) {
            console.log("onkeydown");
            if (event.keyCode === 40) {
                event.preventDefault();
                console.log("downarrow");
            } //downarrow 40, enter 13,  uparrow 38
            if (event.keyCode === 38) {
                event.preventDefault();
                console.log("uparrow");
            }
            if (event.keyCode === 13) {
                event.preventDefault();
                console.log("enter");
            }
            objRef.invokeMethodAsync('onkeydown', event.keyCode);
        }

    }
};