//this is how you'd do it with node.js, and webpack
import postComponent from './post.vue';
//Vue.component('post', {
//    props: ['entry'],
//    template: '<li>' +
//        '<h3>{{ entry.title }}</h3>' +
//        '<p>{{ entry.body }}</p>' +
//        '</li>'
//})
var app = new Vue({
    el: "#app",
    data: {
        Header1: "Hello Vue!",
        HideToggleText: "Hide",
        ShowToggleText: "Show"
    },
    components: [postComponent],
    methods: {
        //toggleP: function () {
        //    app.showPostList = !app.showPostList;
        //}
    }
});

