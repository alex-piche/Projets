var myVar=setInterval(function(){myTimer()},1000);
var sec = 1;
var min = 0;
var hour = 0;

function myTimer()
{
	if(sec < 10)
	{
		if(min < 10)
		{
			if(hour < 10)
			{
				document.getElementById("timer").innerHTML = "0" + hour + ":0" + min + ":0" + sec;
			}
			else
			{
				document.getElementById("timer").innerHTML = hour + ":0" + min + ":0" + sec;
			}
		}
		else
		{
			if(hour < 10)
			{
				document.getElementById("timer").innerHTML = "0" + hour + ":" + min + ":0" + sec;
			}
			else
			{
				document.getElementById("timer").innerHTML = hour + ":" + min + ":0" + sec;
			}
		}
	}
	else
	{
		if(min < 10)
		{
			if(hour < 10)
			{
				document.getElementById("timer").innerHTML = "0" + hour + ":0" + min + ":" + sec;
			}
			else
			{
				document.getElementById("timer").innerHTML = hour + ":0" + min + ":" + sec;
			}
		}
		else
		{
			if(hour < 10)
			{
				document.getElementById("timer").innerHTML = "0" + hour + ":" + min + ":" + sec;
			}
			else
			{
				document.getElementById("timer").innerHTML = hour + ":" + min + ":" + sec;
			}
		}
	}

	if(sec == 59)
	{
		if(min == 59)
		{
			hour++;
			min = 0;
			sec = 0;
		}
		else
		{
			min++;
			sec = 0;
		}
	}
	else
	{
		sec++;
	}

	if(hour == 1 && min == 0 && sec == 0)
	{
		document.getElementById("panel").innerHTML += '<div class=\"large-12 columns panel callout radius text-center\"><h2>That\'s an hour worth of points... I\'m proud of you...</h2></div>';
	}

	document.getElementById("panel").innerHTML += '<div class=\"large-12 columns panel callout radius text-center\"><h2>.</h2></div>';
}
