<script>
    var paraAppended = false;
</script>

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
<button onclick="ShowRedButton()">Controleer wachtwoord</button>
<script>
    function ShowRedButton()
    {
        if(paraAppended == false)
        {
            const para = document.createElement("p");
            para.innerText = "Het wachtwoord is niet correct";
            document.body.appendChild(para);
            paraAppended = true;
        }
    }
</script>
<p>HASH</p>
</body>
</html>
