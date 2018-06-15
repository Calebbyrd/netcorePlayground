
InitCharacterWizard = function () {
    fetch("/CharacterWizard/GetPlayers").then(function (response) { return response.json(); })
        .then(function (result) {
            CharWiz.players = result;
        });
    CharWiz.fullPageMessage = "Welcome Adventurer. Would you like to"
    CharWiz.fullPageOptions = [
        {
            text: "Choose your Fate",
            callback: function () {
                CharWiz.fullPageVisible = false;
                CharWiz.sheetVisible = true;
            }
        }, {
            text: "Seek Guidance",
            callback: function () {
                CharWiz.fullPageVisible = false;
                CharWiz.sheetVisible = true;
            }
        }
    ];
}


var CharWiz = new Vue({
    el: '#characterBuilder',
    data: {
        players: {},
        selectedPlayer: "None",
        characters: {},
        selectedCharacter: "None",
        playerCharacters: {},
        visiblePlayerList: false,
        fullPageVisible: true,
        fullPageMessage: "",
        fullPageOptions: {},
        sheetVisible: false,
        Header1: 'Hello Vue!'
    },
    methods: {
        startCreationWizard: function () {
            fetch("/CharacterWizard/GetNewCharacter").then(function (response) { return response.json(); })
                .then(function (result) {
                });
        },
        GetPlayerCharacters: function (player) {
            CharWiz.selectedPlayer = player.playerName;
            fetch("/CharacterWizard/GetPlayerCharacters",
                {
                    method: 'POST',
                    body: "" + player.playerId,
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
        this.$nextTick(InitCharacterWizard);
    }
});