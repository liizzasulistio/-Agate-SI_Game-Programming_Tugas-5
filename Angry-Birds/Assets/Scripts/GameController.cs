using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public SlingShooter slingShooter;
    public List<Bird> birds;

    private void Start()
    {
        slingShooter.InitiateBird(birds[0]);
    }

}
