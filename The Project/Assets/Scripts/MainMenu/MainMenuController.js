#pragma strict

function StartSimulation () 
{
	SceneManagement.SceneManager.LoadScene("Scenes/Tacking", SceneManagement.LoadSceneMode.Single);
}

function QuitSimulation () 
{
	 Application.Quit();
}
