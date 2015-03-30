<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" lang="fr" xml:lang="fr">

<head>
	<meta charset="utf-8" />
	<meta name="description" content="Les réalisations de Terrassement Portneuf."/>
	<meta name="keywords" content="terrassement, portneuf, québec, aménagement, paysager"/>
	<title>Réalisations - Terrassement Portneuf</title>
	<link rel="stylesheet" href="css/style.css"/>
	<link href="favicon.ico" rel="icon" type="image/x-icon" />
</head>
<body>
	<div id="Page">
		<div id="Bordure">
			<header>
				<a href="index.html"><img src="images/entete.jpg" alt="Bannière de Terrassement Portneuf" /></a>
			</header>

			<div id="MenuEtContenu">
		
			<nav>
				<ul>
					<li><a href="index.html">Accueil</a></li>
					<li><a href="equipement.html">Équipement</a></li>
					<li><a href="services.html">Services</a></li>
					<li><a id="current" href="realisations.php">Réalisations</a></li>
					<li><a href="contacter.html">Contacter</a></li>
				</ul>
			</nav>
			
				<div id="Contenu">
					<h1>Réalisations</h1>
					<div id="Visionneuse">
					
					<table id="Galerie">
					
						<?php
							$k = 0;				
							
							function glob_recursive($pattern, $flags = 0)
							{
								$files = glob($pattern, $flags);
								foreach (glob(dirname($pattern).'/*', GLOB_ONLYDIR|GLOB_NOSORT) as $dir)
								{
									$files = array_merge($files, glob_recursive($dir.'/'.basename($pattern), $flags));
								}
								return $files;
							}	
							
							$files = glob_recursive("photo/*.jpg");
							
							$nbPhoto = count($files);
							
							for($i = 0; $i < $nbPhoto/3; $i++)
							{
								echo "<tr>";

								for($j = 0; $j < 3; $j++)
								{
									if($k < $nbPhoto)
									{
										echo "<td>";

										echo "<a href=\"", utf8_encode($files[$k]), "\"><img src=\"", utf8_encode($files[$k]), "\" class=\"imgGalerie\"/></a>";

										echo "</td>";
										
										$k++;
									}								
								}
								
								echo "</tr>";
							}
							
							
						?>
						
					</table>
						
					</div>
				</div>
			</div>
		</div>

		<footer>
			<a href="https://www.facebook.com/TerrassementPortneuf"><img id="facebook" src="images/facebook.png" alt="Lien vers notre page facebook"/></a>
		</footer>
	</div>
</body>
</html>
