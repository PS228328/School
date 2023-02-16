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
    @method('PUT')
    @csrf
    <input name="passwordCheck" required><br>
    <button type="submit">Controleer wachtwoord</button>
</form>
<p>{{$hash}}</p>
</body>
</html>
