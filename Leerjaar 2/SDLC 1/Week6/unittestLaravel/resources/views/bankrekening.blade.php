<!doctype html>
<html lang="nl">
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="stylesheet"
              href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css">
        <title>Bank</title>

        <style>
            button {width:100%; margin-top:20px;}
            .container {width:20%; min-width:300px;}
            h1 {margin-top:40px; margin-bottom:20px;}
            p, input {font-size:150%; }
        </style>
    </head>
    <body>
    <div class="container">
        <h1>Bankrekening</h1>
        <p>Saldo: {{ $saldo }}</p>
        <form action="bevroren" method="post">
            @csrf
            <input type="checkbox" onclick="submit()"
                   @if ($bevroren) {{ "checked" }} @endif> bevroren
        </form>
        <h1>Bankoverschrijving</h1>
        <form method="post">
            @csrf
            <div class="form-group">
            <label>Bedrag: </label><br/>
            <input type="text" pattern="[0-9]+(\.[0-9]{0,2})?" name="bedrag"
                   style="width:100%"/>
            <button class="btn btn-primary"
                   type="sumbit" formaction="opnemen">Opnemen</button>
            <button class="btn btn-primary"
                   type="sumbit" formaction="storten">Storten</button>
            </div>
        </form>
    </div>
    </body>
</html>
