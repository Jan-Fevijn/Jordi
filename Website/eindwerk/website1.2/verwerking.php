<!DOCTYPE html>
<html>
<head>
    <title>Home</title>
    <link rel="stylesheet" type ="text/css" href="css/style.css">
</head>
<body>
<style>
    table {
  border-collapse: collapse;
  width: 100%;
  margin-top: 75px;
}

th, td {
  text-align: left;
  padding: 8px;
}


th {
  background-color: #4CAF50;
  color: white;
}
  .navbar {
  overflow: hidden;
  background-color: #333;
  position: fixed;
  top: 0;
  width: 100%;
}

.navbar a {
  float: left;
  display: block;
  color: #f2f2f2;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
  font-size: 17px;
}

.navbar a:hover {
  background: #ddd;
  color: black;
}
</style>


<div class="navbar">
  <a href="#home">Home</a>
  <a href="#klassen">Klassen</a>
  <a href="#contact">Contact</a>
</div>

<?php

//databank gegevens

$servername = "127.0.0.1";
$username = "root";
$password = "usbw";
$dbname = "databasegip";
$debug = true;

// Maak je connectie
$conn = new mysqli($servername, $username, $password, $dbname);


// controle van je connectie
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 
else
{
    if ($debug){
    /*echo "alles ok<br>";*/
    }
}
  if (isset($_POST["gebruikersnaam"]) && isset($_POST["wachtwoord"]) && !empty($_POST["gebruikersnaam"]) && !empty($_POST["wachtwoord"])){
        
        // controle gbr en ww
        $gbr = $_POST["gebruikersnaam"];
        $psw = $_POST["wachtwoord"];
        $sql_controlerGebruiker = "SELECT idsecretariaat FROM secretariaat WHERE  gebruikersnaam = '" . $gbr . "' and wachtwoord = '" . $psw ."'";        
        
        /*if ($debug) echo $sql_controlerGebruiker;*/

        $resultaat = mysqli_query($conn,$sql_controlerGebruiker);
        if ($row = mysqli_fetch_assoc($resultaat)){
            /*echo $row["idgebruiker"];*/        

            $_SESSION["loginID"] = $row["idsecretariaat"];           

        }
        else{
            header('location: index.php?fout=gebruiker niet gevonden of foutief wachtwoord.');
        }

    }
    else
    {
        echo "niets gevonden";
        //header('location: index.php?fout=Een van de velden is leeg.');
    }

    $sql = "SELECT overzicht.gebruikersnaam, leerlingen.klas, overzicht.muis, overzicht.toetsenbord, overzicht.datum
FROM overzicht
INNER JOIN leerlingen ON leerlingen.gebruikersnaam = overzicht.gebruikersnaam;";
    $result = mysqli_query($conn, $sql);
    if( $result ){
        echo "<table><tr><th>Gebruiker</th><th>Klas</th><th>Muis</th><th>Toetsenbord</th><th>Datum</th></tr>";
    // success! check results
    while( $row1 = mysqli_fetch_assoc( $result ) ){

        echo "<tr><td>"
            . $row1["gebruikersnaam"]. 
            "</td><td>"  
            . $row1["klas"]. 
            "</td><td>" 
            . $row1["muis"]. 
            "</td><td>"  
            . $row1["toetsenbord"]. 
            "</td><td>"  
            . $row1["datum"]. 
            "</td></tr>";


    }
    echo "</table>";
    }
    else{
            echo "fail";
    }

$conn->Close();        
?>        

</body>
</html>