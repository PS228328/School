<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Home</title>
</head>
<body>
<h1>SDLC Applicatie</h1>
<h4>Wachtwoord</h4>
<form action="/" method="POST">
    @csrf
    <input name="password" required><br>
    <button type="submit">Verander wachtwoord</button><br>
</form>
<form action="/" method="POST">
    @method('PUT')
    @csrf
    <input name="passwordCheck" type="hidden" required><br>
    <button type="submit">Controleer wachtwoord</button>
</form>
@if($correct)
    <p>Het wachtwoord is goed</p>
@else
    <p>Het wachtwoord is fout</p>
@endif
</body>
</html>
