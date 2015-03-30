window.addEventListener("load", init, false);

var nbPhoto = 63;
var accumulateur = 0;
var position = 0;

function init()
{
	generer();
	document.getElementById("Precedente").addEventListener("click", descendre, false);
	document.getElementById("Suivante").addEventListener("click", monter, false);
}

function generer()
{
	var tableau = document.getElementById("Galerie");
	var nouvelleRange;
	var nouvelleCellule;

	for(var i = 0; i < nbPhoto / 3; i++)
	{
		nouvelleRange = document.createElement("tr");
		
		for(var j = 0; j < 3; j++)
		{
			if(accumulateur < nbPhoto)
			{
				nouvelleCellule = document.createElement("td");
				nouvelleCellule.innerHTML = "<img src=\"photo/img" + accumulateur + ".jpg\" id=\"" + accumulateur + "\" alt=\"Photo\" class=\"imgGalerie\"/>";
				nouvelleRange.appendChild(nouvelleCellule);
				accumulateur++;
			}
		}

		tableau.appendChild(nouvelleRange);
	}

	for(var i = 0; i < nbPhoto; i++)
	{
		document.getElementById(i).addEventListener("click", changerPhoto, false);
	}
}

function changerPhoto(e)
{
	document.getElementById("GrandeImg").src = e.currentTarget.src;
	document.getElementById("Lien").href = e.currentTarget.src;
	position = e.currentTarget.id;
	e.currentTarget.style.border = "2px solid white";
}

function monter()
{
	position++;
	
	if(position < nbPhoto)
	{
		document.getElementById("GrandeImg").src = "photo/img" + position + ".jpg";
		document.getElementById("Lien").href = "photo/img" + position + ".jpg";
	}
	else
	{
		position = 0;
		document.getElementById("GrandeImg").src = "photo/img" + position + ".jpg";
		document.getElementById("Lien").href = "photo/img" + position + ".jpg";
	}
}

function descendre()
{
	position--;

	if(position >= 0)
	{
		document.getElementById("GrandeImg").src = "photo/img" + position + ".jpg";
		document.getElementById("Lien").href = "photo/img" + position + ".jpg";
	}
	else
	{
		position = nbPhoto - 1;
		document.getElementById("GrandeImg").src = "photo/img" + position + ".jpg";
		document.getElementById("Lien").href = "photo/img" + position + ".jpg";
	}
}
