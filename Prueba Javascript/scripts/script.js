$(function (){
    console.log("Ready to go!");
    player = 'Gil';

    $('.square').click(function (){
        let clickedSquare = $(this);

        if (clickedSquare.children().length > 0) {
            alert('That square has already been chosen.');
        } else {
            clickedSquare.append('<img id="imagen" src="img/' + player + '.jpg" />' );
            clickedSquare.append('<p>' + player + '</p>' );
            console.log('Clicked square number ' + clickedSquare.attr('id') + '!');
            togglePlayer();
            turnDisplayer();
            didPlayerWin(winner);
            noWinners(winner);
        }
    })

    function turnDisplayer()
    {
        $('#turnDisplayer').remove();
        $('#container').before("<h2 id='turnDisplayer'>It's " + player + " 's turn.");
    }

    function togglePlayer()
    {
        if (player == 'Gil'){
            player = 'Ozy';
        }else
        {
            player = 'Gil';
        }
    }

    function didPlayerWin()
    {
        var winner = false;

       if ($('#one').html() == $('#two').html() && $('#one').html() == $('#three').html() && $('#one').children().length > 0) {
            alert($('#one').find('p').html() + ' has won!');
            winner = true;
        } else if($('#one').html() == $('#four').html() && $('#one').html() == $('#seven').html() && $('#one').children().length > 0) {
            alert($('#one').find('p').html() + ' has won!');
            winner = true;
        } else if($('#one').html() == $('#five').html() && $('#one').html() == $('#nine').html() && $('#one').children().length > 0) {
            alert($('#one').find('p').html() + ' has won!');
            winner = true;
        } else if($('#two').html() == $('#five').html() && $('#two').html() == $('#eight').html() && $('#two').children().length > 0) {
            alert($('#two').find('p').html() + ' has won!');
            winner = true;
        } else if($('#three').html() == $('#six').html() && $('#three').html() == $('#nine').html() && $('#three').children().length > 0) {
            alert($('#three').find('p').html() + ' has won!');
            winner = true;
        } else if($('#four').html() == $('#five').html() && $('#four').html() == $('#six').html() && $('#four').children().length > 0) {
            alert($('#four').find('p').html() + ' has won!');
            winner = true;
        } else if($('#seven').html() == $('#eight').html() && $('#seven').html() == $('#nine').html() && $('#seven').children().length > 0) {
            alert($('#seven').find('p').html() + ' has won!');
            winner = true;
        } else if($('#three').html() == $('#five').html() && $('#three').html() == $('#seven').html() && $('#three').children().length > 0) {
            alert($('#three').find('p').html() + ' has won!');
            winner = true;
        }
        
        if (winner) {
            setTimeout(function () {
                window.location.reload(0.5);
            }, 2000);
        }

        return winner;
    }

    function noWinners()
    {
        if ($('#one').children().length > 0 && $('#two').children().length > 0 && $('#three').children().length > 0 && $('#four').children().length > 0
        && $('#five').children().length > 0 && $('#six').children().length > 0 && $('#seven').children().length > 0
        && $('#eight').children().length > 0 && $('#nine').children().length > 0 && (winner == false || winner == undefined)) {
            console.log(winner);
            alert('Nobody won...');
            setTimeout(function () {
                window.location.reload(1);
            }, 2000);
        }
    }
})
