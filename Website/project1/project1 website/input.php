<!DOCTYPE html>
<html>
<head>
	<title>Project 1</title>
	<link rel="stylesheet" href="style.css">
</head>
<style>
    body {
  font-family: Arial;
  margin: 0;
}

header {
  padding: 60px;
  text-align: center;
  background: #1abc9c;
  color: white;
  font-size: 30px;
  height: 25px;
}

.footer{
	background-color: lightgrey;
	position: fixed;
   	left: 0;
   	bottom: 0;
   	width: 100%;
   	text-align: center;
}

.titel{
  text-decoration: underline;
  font-weight: bold;
  font-family: Arial; 
}

#verrichting {
  font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

#verrichting td, #verrichting th {
  border: 1px solid #ddd;
  padding: 8px;
}

#verrichting tr:nth-child(even){background-color: #f2f2f2;}

#verrichting tr:hover {background-color: #ddd;}

#verrichting th {
  padding-top: 12px;
  padding-bottom: 12px;
  text-align: left;
  background-color: rgb(0, 0, 0);
  color: white;
}
</style>
<body>	

<header> <i> Project 1 </i> </header>

<?php
        $servername = "127.0.0.1";
        $username = "root";
        $password = "usbw";
        $dbname = "project1";

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
            $sql_controlerGebruiker = "SELECT idpersoon FROM persoon WHERE  email = '" . $gbr . "' and wachtwoord = '" . $psw ."'";        
            
            /*if ($debug) echo $sql_controlerGebruiker;*/
    
            $resultaatControleGebruiker = mysqli_query($conn,$sql_controlerGebruiker);
            if ($row = mysqli_fetch_assoc($resultaatControleGebruiker)){     
    
                $_SESSION["loginID"] = $row["idpersoon"];           
    
            }
            else{
                header('location: index.php?fout=gebruiker niet gevonden of foutief wachtwoord.');
            }
    
        }
?>

<?php
$sql_combobox = "SELECT idpersoon, voornaam, naam from persoon";
$result1 = mysqli_query($conn, $sql_combobox);

$options = "";

while($row2 = mysqli_fetch_array($result1))
{
    $options = $options."<option>$row2[1]  $row2[2]</option>";
}
?>

    	<form method='POST' action='input.php'>
    	<select name='sorteer'>
            <option> <-Select-> </option>
            <?php echo $options;?>
        </select>  	    	    	
    	<input type='submit' value='verzenden'>
    	</form>

    	<?php
        // query met de nodige informatie
        if ($_SERVER["REQUEST_METHOD"] == "POST"){
        $gbr = $_POST["gebruikersnaam"];
        $sql = "SELECT IDverrichting, naam, voornaam, bedrag, datum, omschrijving, email FROM ((verrichting 
        JOIN typeverrichting ON verrichting.idtypeverrichting = typeverrichting.idtypeverrichting)
        JOIN persoon on verrichting.idpersoon = persoon.idpersoon) where email = '" . $gbr . "'";
       
        $resultaat = mysqli_query($conn,$sql);       
        while ($row1 = mysqli_fetch_assoc($resultaat)){
            if (isset($_POST["sorteer"])){
            
            echo "<table id='verrichting'><tr><th>#</th><th>Gebruiker</th><th>Bedrag</th><th>Datum</th><th>Omschrijving</th></tr>";            
                
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
      }

        $conn->Close();
?>

<div class="footer">
	<h3><u>School</u></h3>
	<p>Daverlostraat 132, 8310 Assebroek, Belgium, Class A1.36, 2nd Floor</p>
	<p>050 36 68 80</p>
	<p>info@atheneumjanfevijn.be</p>
</div>

</body>
</html>

