window.onload = function () {
    // Resize map - IE 8, 7, 6, 5
    function resizeMap() {
        /*
        const MAIN_MAP = AspMap.find('mainMap');
        const MAIN_WIDTH = window.innerWidth
            || document.documentElement.clientWidth
            || document.body.clientWidth;
        const MAIN_HEIGHT = window.innerHeight
            || document.documentElement.clientHeight
            || document.body.clientHeight;
        //let [dWidth, dHeight] = [MAIN_WIDTH,MAIN_HEIGHT];
        //console.log(`WIDTH: ${dWidth} - HEIGHT: ${dHeight}`);
        map.resizeTo(MAIN_WIDTH, MAIN_HEIGHT);
        */
    }
    resizeMap();
    
    // Extra large devices (large desktops, 1200px and up)
    var mediaExtraLarge = matchMedia('(min-width: 1200px)');
    mediaExtraLarge.addListener(function (mediaQuery) {
        if (mediaQuery.matches) {
            console.log("Coincide - Media Extra Large !!");
            resizeMap();
        } else {
            console.log("No coincide - Media Extra Large !!");
        }
    });

    // Large devices (desktops, 992px and up)
    var mediaLarge = matchMedia('(min-width: 992px)');
    mediaLarge.addListener(function (mediaQuery) {
        if (mediaQuery.matches) {
            console.log("Coincide - Media Large !!");
            resizeMap();
        } else {
            console.log("No coincide - Media Large !!");
        }
    });

    // Medium devices (tablets, 768px and up)
    var mediaMedium = matchMedia('(min-width: 768px)');
    mediaMedium.addListener(function (mediaQuery) {
        if (mediaQuery.matches) {
            resizeMap();
            console.log("Coincide - Medium !!");
        } else {
            console.log("No coincide - Medium !!");
        }
    });

    // Small devices (landscape phones, 576px and up)
    var mediaSmall = matchMedia('(min-width: 576px)');
    mediaSmall.addListener(function (mediaQuery) {
        if (mediaQuery.matches) {
            resizeMap();
            console.log("Coincide - Small !!");
        } else {
            console.log("No coincide - Small !!");
        }
    });

    function mouseMoveHandler(sender, e) {
        document.getElementById("hfXCoord").value = e.latitude
        document.getElementById("hfYCoord").value = e.longitude
    }

    function ActMouseMove() {
        var mapXY = AspMap.getMap('mainMap');
        mapXY.add_mouseMove(mouseMoveHandler);
    }
}
/********************************** PRIMERA VERSIÓN
// Extra large devices (large desktops, 1200px and up)
var mediaExtraLarge = matchMedia('(min-width: 1200px)');
mediaExtraLarge.addListener(function (mediaQuery) {
    if (mediaQuery.matches) {
        console.log("Coincide - Media Extra Large !!");
        resizeMap();
    } else {
        console.log("No coincide - Media Extra Large !!");
    }
});

// Large devices (desktops, 992px and up)
var mediaLarge = matchMedia('(min-width: 992px)');
mediaLarge.addListener(function (mediaQuery) {
    if (mediaQuery.matches) {
        console.log("Coincide - Media Large !!");
        resizeMap();
    } else {
        console.log("No coincide - Media Large !!");
    }
});

// Medium devices (tablets, 768px and up)
var mediaMedium = matchMedia('(min-width: 768px)');
mediaMedium.addListener(function (mediaQuery) {
    if (mediaQuery.matches) {
        console.log("Coincide - Medium !!");
        resizeMap();
    } else {
        console.log("No coincide - Medium !!");
    }
});

// Small devices (landscape phones, 576px and up)
var mediaSmall = matchMedia('(min-width: 576px)');
mediaSmall.addListener(function (mediaQuery) {
    if (mediaQuery.matches) {
        console.log("Coincide - Small !!");
        resizeMap();
    } else {
        console.log("No coincide - Small !!");
    }
});
*/



/********************************** SEGUNDA VERSIÓN

// Extra large devices (large desktops, 1200px and up)
function mediaExtraLarge(<<<mediaQuery) {
    if (mediaQuery.matches) { // If media query matches
        console.log("Coincide - Extra Large !!");
    } else {
        console.log("No coincide - Extra Large !!");
    }
}

// Large devices (desktops, 992px and up)
function mediaLarge(mediaQuery) {
    if (mediaQuery.matches) { // If media query matches
        console.log("Coincide - Large !!");
    } else {
        console.log("No coincide - Large !!");
    }
}

// Medium devices (tablets, 768px and up)
function mediaMedium(mediaQuery) {
    if (mediaQuery.matches) { // If media query matches
        console.log("Coincide - Medium !!");
    } else {
        console.log("No coincide - Medium !!");
    }
}

// Small devices (landscape phones, 576px and up)
function mediaSmall(mediaQuery) {
    if (mediaQuery.matches) { // If media query matches
        console.log("Coincide - Small !!");
    } else {
        console.log("No coincide - Small !!");
    }
}

// Extra large devices (large desktops, 1200px and up)
var minExtraLarge = window.matchMedia('(min-width: 1200px)')
mediaExtraLarge(minExtraLarge) // Call listener function at run time
minExtraLarge.addListener(mediaExtraLarge) // Attach listener function on state changes

// Large devices (desktops, 992px and up)
var minLarge = window.matchMedia('(min-width: 992px)')
mediaLarge(minLarge) // Call listener function at run time
minLarge.addListener(mediaLarge) // Attach listener function on state changes

// Medium devices (tablets, 768px and up)
var minMedium = window.matchMedia('(min-width: 768px)')
mediaMedium(minMedium) // Call listener function at run time
minMedium.addListener(mediaMedium) // Attach listener function on state changes

// Small devices (landscape phones, 576px and up)
var minSmall = window.matchMedia('(min-width: 576px)')
mediaSmall(minSmall) // Call listener function at run time
minSmall.addListener(mediaSmall) // Attach listener function on state changes
*/

/********************************** PRIMERA VERSIÓN 

// Extra large devices (large desktops, 1200px and up)
var mediaExtraLarge = matchMedia('(min-width: 1200px)');
mediaExtraLarge.addListener(function (mediaQuery) {
    if (mediaQuery.matches) {
        console.log("Coincide - Media Extra Large !!");
    } else {
        console.log("No coincide - Media Extra Large !!");
    }
});

// Large devices (desktops, 992px and up)
var mediaLarge = matchMedia('(min-width: 992px)');
mediaLarge.addListener(function (mediaQuery) {
    if (mediaQuery.matches) {
        console.log("Coincide - Media Large !!");
    } else {
        console.log("No coincide - Media Large !!");
    }
});

// Medium devices (tablets, 768px and up)
var mediaMedium = matchMedia('(min-width: 768px)');
mediaMedium.addListener(function (mediaQuery) {
    if (mediaQuery.matches) {
        console.log("Coincide - Medium !!");
    } else {
        console.log("No coincide - Medium !!");
    }
});

// Small devices (landscape phones, 576px and up)
var mediaSmall = matchMedia('(min-width: 576px)');
mediaSmall.addListener(function (mediaQuery) {
    if (mediaQuery.matches) {
        console.log("Coincide - Small !!");
    } else {
        console.log("No coincide - Small !!");
    }
});
*/

/********************************************* VALIDACIÓN SOPORTE DE ECMASCRIPT

let ES1 = !!(Array.prototype && Array.prototype.join),
    ES3 = !!(Array.prototype && Array.prototype.pop),
    ES51 = (function () { 'use strict'; return !this; })(),
    ES6 = !!Object.assign,
    ES7 = !!(Array.prototype && Array.prototype.includes);

if (ES7) {
    console.log('Tu navegador contiene características mínimas de ECMAScript 7');
} else if (ES6) {
    console.log('Tu navegador contiene características mínimas de ECMAScript 6');
} else if (ES51) {
    console.log('Tu navegador tiene soporte para ECMAScript 5.1');
} else if (ES3) {
    console.log('Tu navegador contiene características de ECMAScript 3');
} else if (ES1) {
    console.log('Tu navegador contiene características de ECMAScript 1');
} else {
    console.log('Tu navegador contiene características de ECMAScript desconocida');
}
*/

/* ECMAScript6 
let [titulo, subtitulo, contenido] = ['Soy el titulo', 'Soy el subtitulo', 'Soy el contenido'];
console.log(titulo);
console.log(subtitulo);
console.log(contenido);
*/

/* function* - yield 
function* cuadrados(){
    var n = 1; // comienza en 1
    while(true) {
        var c = n * n; // obtiene el cuadrado
        n++; // aumenta para la próxima iteración
        yield c; // devuelve el valor actual
    }
}

var n = 5;
var s2 = `El valor de n es ${n}`;

// Pueden abarcar múltiples líneas
var s3 = `Esta es una cadena
escrita en dos líneas`;
*/