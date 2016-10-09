var sequenceGen = (function () {
    //
    var prefix = 'ADVS';
    var postFix = 'SSNC';

    function generate() {
        var randomStr = '';
        for (var index = 0; index < 10; ++index) {
            randomStr += Math.floor(Math.random() * 10);
        }
        return prefix + '-' + randomStr + '-' + postFix;
    }   
    return {
        generate: generate
    };
})();

console.log(sequenceGen.generate());