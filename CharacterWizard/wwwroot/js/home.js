
var app = new Vue({
    el: '#characterBuilder',
    data: {
        visibleCheckList: true,
        Header1: 'Hello Vue!',
        creationItems: [
            {
                title: 'Item 1',
                status: 'Complete',
                desc: 'the first item'
            },
            {
                title: 'Item 2',
                status: 'Incomplete',
                desc: 'the second item'
            },
            {
                title: 'Item 3',
                status: 'Incomplete',
                desc: 'the third item'
            }
            ]
        },
        methods: {
            startCreationWizard: function () {
                
            }
        }
});
