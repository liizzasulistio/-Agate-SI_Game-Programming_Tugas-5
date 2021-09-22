using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public SlingShooter slingShooter;
    public List<Bird> birds;

    

    private void Start()
    {
        for(int i = 0; i < birds.Count; i++)
        {
            birds[i].OnBirdDestroyed += ChangeBird;
        }
        slingShooter.InitiateBird(birds[0]);
    }

    public void ChangeBird()
    {
        birds.RemoveAt(0);

        if (birds.Count > 0) slingShooter.InitiateBird(birds[0]);
    }

}
