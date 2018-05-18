
    var app = new Vue({
        el: '#app',
        data: {
            app: 'myID',
            Header1: 'Hello Vue!',
            HideToggleText: 'Hide',
            ShowToggleText: 'Show',
            visiblePostList: true,
            posts: [
                {
                    title: 'test1',
                    body: 'test post info 1'
                }, {
                    title: 'test2',
                    body: 'test post info 2'
                }, {
                    title: 'test3',
                    body: 'test post info 3'
                }]
        },
        methods: {
            toggleP: function () {
                app.visiblePostList = !app.visiblePostList;
            }
        }
});