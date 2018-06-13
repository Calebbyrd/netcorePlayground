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
        ShowToggleText: "Show",
        showPostList: true,
        showNewPost: false,
        newPost: {
            title: "",
            body: ""
        },
        posts: [
            {
                title: "test1",
                body: "test post info 1"
            }, {
                title: "test2",
                body: "test post info 2"
            }, {
                title: "test3",
                body: "test post info 3"
            }]
    },
    components: [postComponent],
    methods: {
        toggleP: function () {
            app.showPostList = !app.showPostList;
        },
        showNewPostForm: function() {
            app.showNewPost = !app.showNewPost;
        },
        submitNewPost: function () {
            
            app.posts.push({title: app.newPost.title, body: app.newPost.body});
            app.newPost.title = "";
            app.newPost.body = "";
            app.showNewPostForm();
        }
    }
});

