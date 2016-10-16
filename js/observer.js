//demo for event manager

function EventMgr() {
    this.subscribers = {}; 
}

EventMgr.prototype = {
    subscribe: function (eventType, callBack) {
        if (!this.subscribers[eventType]) {
            this.subscribers[eventType] = [];
        }
        if (this.subscribers[eventType].indexOf(callBack) === -1) {
            this.subscribers[eventType].push(callBack);
        }
    },
    unsubscribe: function (eventType, callBack) {
        var listeners = this.subscribers[eventType];
        if (!listeners) {
            return;
        }
        var index = listeners.indexOf(callBack);
        if (index > -1) {
            listeners.splice(index, 1);
        }
    },
    //eventObj => published data
    publish: function (eventType, eventObj) {
        var listeners = this.subscribers[eventType];
        if (listeners) {
            eventObj.eventType = eventType;//
            for (var ii = 0; ii < listeners.length; ++ii) {
                listeners[ii](eventObj);
            }
        }
    }
};


var evtMgr = new EventMgr();

function handler () {
    console.log('test/demo event hanlder');
}

evtMgr.subscribe('test/demo', handler);

evtMgr.publish('test/demo', {});

evtMgr.unsubscribe('test/demo', handler);

evtMgr.publish('test/demo', {});