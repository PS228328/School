function loadXMLDoc() 
{
    var xmlhttp = new XMLHttpRequest();
    xmlhttp.onreadystatechange = function() 
    {
        if (this.readyState == 4 && this.status == 200) 
        {
            showStats(this);
        }
    }

    xmlhttp.open("GET", "XML/numbers.xml", true);
    xmlhttp.send();
}
  
function showStats(xml) 
{
    var xmlDoc = xml.responseXML;
    var items = "";
    var x = xmlDoc.getElementsByTagName("numberpair");

    for (var i = 0; i < x.length; i++) 
    {
        var number = x[i].getElementsByTagName("number")[0].childNodes[0].nodeValue;
        var amount = x[i].getElementsByTagName("keergevallen")[0].childNodes[0].nodeValue;
        var row = i + 1;

        switch(number)
        {
            case "0":
                classname = "green";
                break;
            case "1":
            case "3":
            case "5":
            case "7":
            case "9":
            case "12":
            case "14":
            case "16":
            case "18":
            case "19":
            case "21":
            case "23":
            case "25":
            case "27":
            case "30":
            case "32":
            case "34":
            case "36":
                classname = "red";
                break;
            default:
                classname = "black";
                break;
        }

        items += "<div class='number " + classname + "'><h2>" + number + "</h2><p>" + amount + " X</p></div>";
    }
    
    document.getElementById("numberContainer").innerHTML = items;
}