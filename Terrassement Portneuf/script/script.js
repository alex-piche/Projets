window.addEventListener("load", init, false);

var i = 1;
var nbPhoto = 14;

function init()
{
	window.setInterval(visionneuse, 5000);
}

function visionneuse()
{
	document.getElementById("Lien").href = "photo/img" + i + ".jpg";
	document.getElementById("Photo").setAttribute("src", "photo/img" + i + ".jpg");
	i++;
	
	if(i == nbPhoto)
	{
		i = 0;
	}
}
