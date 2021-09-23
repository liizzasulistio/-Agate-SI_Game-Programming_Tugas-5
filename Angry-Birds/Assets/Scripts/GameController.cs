using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public SlingShooter slingShooter;
    public List<Bird> birds;
    public List<Enemy> enemies;

    private bool _isGameEnded = false;
    

    private void Start()
    {
        for(int i = 0; i < birds.Count; i++)
        {
            birds[i].OnBirdDestroyed += ChangeBird;
        }

        for(int i = 0; i < enemies.Count; i++)
        {
            enemies[i].OnEnemyDestroyed += CheckGameEnd;
        }
        slingShooter.InitiateBird(birds[0]);
    }

    public void ChangeBird()
    {
        if(_isGameEnded)
        {
            return;
        }
        birds.RemoveAt(0);

        if (birds.Count > 0) slingShooter.InitiateBird(birds[0]);
    }

    public void CheckGameEnd(GameObject destroyedEnemy)
    {
        for(int i = 0; i < enemies.Count; i++)
        {
            if(enemies[i].gameObject == destroyedEnemy)
            {
                enemies.RemoveAt(i);
                break;
            }
        }
        if(enemies.Count == 0)
        {
            _isGameEnded = true;
        }
    }

}
