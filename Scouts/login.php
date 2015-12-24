<?php

	session_start();
	
	if(isset($_POST["passwd"]) and $_POST["passwd"] == "Portneuf74")
	{		
			$_SESSION["auth"] = true;
			header('Location: photos.php');	
	}

?>

<!doctype html>
<html class="no-js" lang="en">
  <head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Scouts de Portneuf</title>
    <link rel="stylesheet" href="css/foundation.css" />
    <link href="favicon.ico" rel="icon" type="image/x-icon">
    <script src="js/modernizr.js"></script>
  </head>
  <body>
    
    <div class="row">
		<a href = "index.html"><img src="img/entete.jpg"/></a>
    </div>
    
    <div id="page" class="row panel">
		<div class="large-3 medium-4 columns">
			<div class="row">
				<div class="large-12 medium-12 columns text-center">
					<ul class="side-nav">
						<li><a href="index.html" class="button radius round">Accueil</a></li>
						<li><a href="branches.html" class="button radius round">Branches</a></li>
						<li><a id="current" href="photos.php" class="button radius round">Photos</a></li>
						<li><a href="calendrier.html" class="button radius round">Calendrier</a></li>
						<li><a href="commanditaires.html" class="button radius round">Commanditaires</a></li>
						<li><a href="contacter.html" class="button radius round">Nous Contacter</a></li>
					</ul>
				</div>
			</div>
		</div>
		<div id="panel" class="large-9 medium-8 columns">
			<div class="row">
				<div class="large-12 columns text-center">
					<div class="callout panel ombre">
					<h1>Photos</h1>
						<form action="login.php" method="post">
							<label for="passwd">Mots de Passe</label>
							<input type="password" name="passwd" id="passwd">
							<input type="submit" value="Connexion">
						</form>
					</div>
				</div>
			</div>	
		</div>
    </div>
	
    <script src="js/jquery.js"></script>
    <script src="js/foundation.min.js"></script>
    <script>
      $(document).foundation();
    </script>
  </body>
</html>
