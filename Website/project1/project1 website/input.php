<!DOCTYPE html>
<html>
<head>
	<title>Project 1</title>
	<link rel="stylesheet" href="style.css">
</head>
<body>	

<header> <i> Toets Flexboxen </i> </header>

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
?>

<?php
$sql_combobox = "SELECT IDverichting from verichting";
$result1 = mysqli_query($conn, $sql_combobox);

$options = "";

while($row2 = mysqli_fetch_array($result1))
{
    $options = $options."<option>$row2[0]</option>";
}
?>

    	<form method='post' action='input.php'>
    	<select name='sorteer'>
            <option> <-Select-> </option>
            <?php echo $options;?>
        </select>  	    	    	
    	<input type='submit' value='verzenden'>
    	</form>

    	<?php
        // query met de nodige informatie
        $sql = "SELECT IDverichting, inputoutput, code, omschrijving, datum, bedrag FROM (verichting 
        INNER JOIN typeio ON verichting.IDtypeIO = typeio.IDtypeIO)";
       
         $resultaat = mysqli_query($conn,$sql);
        while ($row = mysqli_fetch_assoc($resultaat)){
            
            if (isset($_POST["sorteer"])){
                                   
            echo "<p class='titel'>Verichting" . $row["IDverichting"].": " ."</p>";
            echo "<p>Inkomsten of Uitgave: ". $row["inputoutput"]."</p>";
            echo "<p>Code + omschrijving: ". $row["code"]. " " . $row["omschrijving"] . "</p>";         	  
            echo "<p>Datum: ". $row["datum"]."</p>";
         	echo "<p>Bedrag: ". $row["bedrag"]."</p>";                 
            
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

