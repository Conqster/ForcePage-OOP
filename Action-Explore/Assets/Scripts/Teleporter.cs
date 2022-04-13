using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : Collidable
{

    public string[] sceneNames;
    protected override void OnCollide(Collider2D col)
    {
        if (col.name == "Player")
        {
            string sceneName = sceneNames[Random.Range(0, sceneNames.Length)];
            SceneManager.LoadScene(sceneName);
        }
    }
}