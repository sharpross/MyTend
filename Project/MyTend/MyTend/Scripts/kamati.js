/**
 * Created by vidrickiy on 30.12.2015.
 */
var kamati = kamati || {};

kamati.animation = {};

kamati.animation.dots = (function(){
    var selfEl = null,
        defaultTimeout = 700,
        selfTimeout = defaultTimeout,
        innerHtml = '',
        dot = '.',
        value = '',
        timerId = null;

    var enabled = function(){
        selfEl.removeAttribute("disabled");
    }

    var disabled = function(){
        selfEl.setAttribute("disabled", true)
    }

    var animation = function(){
        if(value.length >= 3){
            value = '';
        } else {
            value += dot;
        }

        selfEl.innerHTML = innerHtml + value;
    }

    //public Constructor
    var Constr = function(el, timeout){
        if(!el){
            throw "Not set 'el'";
        }
        if(timeout){
            selfTimeout = timeout;
        }

        selfEl = el;
        innerHtml = selfEl.innerHTML;
    }

    Constr.prototype = {
        constructor: kamati.animation.dots,
        start: function(){
            timerId = setInterval(animation, selfTimeout);
            disabled();
        },
        stop: function(){
            clearInterval(timerId);
            enabled();
            selfEl.innerHTML = innerHtml;
        }
    }

    return Constr;
}());