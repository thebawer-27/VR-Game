using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class Obstacle : MonoBehaviour {


    void OnTriggerEnter(Collider col)
    {
        //if the player hits one obstacle, it's game over
        if(col.gameObject.tag == Constants.PlayerTag)
        {
            GameManager.Instance.Die();
        }
    }
}
