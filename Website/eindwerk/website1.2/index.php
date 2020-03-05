<!DOCTYPE html>
<html>
<head>
  <title>Inloggen</title>
  <link rel="stylesheet" type="text/css" href="css/style.css">
</head>
  <body>    
    
    <form action="verwerking.php" method="POST">
      <div class="container">
        <label for="uname"><b>Username</b></label>
        <input id="user" type="text" placeholder="Enter Username" name="gebruikersnaam" required>

        <label for="psw"><b>Password</b></label>
        <input id="psw" type="password" placeholder="Enter Password" name="wachtwoord" required>
  
        <script>
        var text = document.getElementById("text");
        text.style.display = "none"
        </script>

        <button type="submit">Login</button>
        <p id="text">WARNING! Caps lock is ON.</p>

        <?php
    if (isSet($_GET["fout"])){
        echo $_GET["fout"];
        }?>

      </div>
    </form>


<script>
var input = document.getElementById("user");
var text = document.getElementById("text");
input.addEventListener("keyup", function(event) {

if (event.getModifierState("CapsLock")) {
    text.style.display = "block";
  } else {
    text.style.display = "none"
  }
});

var input = document.getElementById("psw");
var text = document.getElementById("text");
input.addEventListener("keyup", function(event) {

if (event.getModifierState("CapsLock")) {
    text.style.display = "block";
  } else {
    text.style.display = "none"
  }
});
</script>


  </body>
</html>