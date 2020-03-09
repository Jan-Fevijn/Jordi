<!DOCTYPE html>
<html>
<head>
	<title>Project 2</title>
	<link rel="stylesheet" href="style.css">
</head>
<header> <i> Project 1 </i> </header>

<?php
        $servername = "127.0.0.1";
        $username = "root";
        $password = "usbw";
        $dbname = "project2";

        // Create connection
        $conn = new mysqli($servername, $username, $password, $dbname);

        // Check connection
        if ($conn->connect_error) {
            die("Connection failed: " . $conn->connect_error);
        } 
        else
        {
            //echo "alles ok<br>";

        }

        if (isset($_POST["gebruikersnaam"]) && isset($_POST["wachtwoord"]) && !empty($_POST["gebruikersnaam"]) && !empty($_POST["wachtwoord"])){
        
            // controle gbr en ww
            $gbr = $_POST["gebruikersnaam"];
            $psw = $_POST["wachtwoord"];
            $sql_controlerGebruiker = "SELECT idpersoon FROM persoon WHERE gebruikersnaam = '" . $gbr . "' and wachtwoord = '" . $psw ."'";        
            
            /*if ($debug) echo $sql_controlerGebruiker;*/
    
            $resultaatControleGebruiker = mysqli_query($conn,$sql_controlerGebruiker);
            if ($row = mysqli_fetch_assoc($resultaatControleGebruiker)){     
    
                $_SESSION["loginID"] = $row["idpersoon"];           
    
            }
            else{
                header('location: index.php?fout=gebruiker niet gevonden of foutief wachtwoord.');
            }
    
        }

        $sql = "SELECT * FROM ((evenmentgerecht 
        JOIN evenement ON evenmentgerecht.idevenement = evenement.idevenement)
        JOIN persoon on evenmentgerecht.idgerecht = gerecht.idgerecht)";
       
        $resultaat = mysqli_query($conn,$sql);       
        while ($row1 = mysqli_fetch_assoc($resultaat)){
            if (isset($_POST["sorteer"])){
            
            echo "<table><tr><th>#</th><th>Gebruiker</th><th>Bedrag</th><th>Datum</th><th>Omschrijving</th></tr>";            
                
            echo "<tr><td>"
            . $row1["IDverrichting"]. 
            "</td><td>"  
            . $row1["naam"] . " " .  $row1["voornaam"] .
            "</td><td>" 
            . $row1["bedrag"]. 
            "</td><td>"  
            . $row1["datum"]. 
            "</td><td>"  
            . $row1["omschrijving"]. 
            "</td></tr>";                           
            
            }
            echo "</table>";
        }

        $conn->close();
?>


<div class="footer">
	<h3><u>School</u></h3>
	<p>Daverlostraat 132, 8310 Assebroek, Belgium, Class A1.36, 2nd Floor</p>
	<p>050 36 68 80</p>
	<p>info@atheneumjanfevijn.be</p>
</div>

</body>
</html>