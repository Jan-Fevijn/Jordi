<!DOCTYPE html>
<html>
<head>
  <title>Inloggen</title>
  <link rel="stylesheet" type="text/css" href="css/style.css">
</head>
  <body>    
    
    <form action="input.php" method="POST">
      <div class="container">
        <label for="uname"><b>Username</b></label>
        <input id="user" type="text" placeholder="Enter Username" name="gebruikersnaam" required>      

        <label for="psw"><b>Password</b></label>
        <input id="psw" type="password" placeholder="Enter Password" name="wachtwoord" required>
        
        <input type="submit" name="verzenden">

        <?php
    if (isSet($_GET["fout"])){
        echo $_GET["fout"];
        }?>

      </div>
    </form>

  </body>
</html>