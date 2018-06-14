
GetPlayers = function () {
    fetch("/CharacterWizard/GetPlayers").then(function (response) { return response.json(); })
        .then(function (result) {
            CharWiz.players = result;
        });
}


var CharWiz = new Vue({
    el: '#characterBuilder',
    data: {
        players: {},
        selectedPlayer:"None",
        playerCharacters: {},
        visiblePlayerList: false,
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
            fetch("/CharacterWizard/GetNewCharacter").then(function (response) { return response.json(); })
                .then(function (result) {
            }); 
        },
        switchPlayer: function () {
            fetch("/CharacterWizard/GetCharacters").then(function (response) { return response.json(); })
                .then(function (result) {
                });
        },
        GetPlayerCharacters: function (playerId) {
            fetch("/CharacterWizard/GetPlayerCharacters",
                    {
                        method: 'POST', // or 'PUT'
                        body: ""+playerId, // data can be `string` or {object}!
                        headers: {
                            'Content-Type': 'application/json'
                        }
                    }).then(function (response) { return response.json(); })
                .then(function (result) {
                    CharWiz.playerCharacters = result;
                });
        } 
    },
    mounted: function () {
        this.$nextTick(GetPlayers);
    }
});
