using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    GameObject player;
    [SerializeField]
    float chaseSpeed = 10f;
    [SerializeField]
    float chaseTriggerDistance = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //if the player gets too close
        Vector3 playerPosition = player.transform.position;
        Vector3 chaseDir = playerPosition - transform.position;
        if(chaseDir.magnitude < chaseTriggerDistance)
        {
            //chase the player
            //chase direction = players position - my current position
            //move in the direction of the player
            chaseDir.Normalize();
            GetComponent<Rigidbody2D>().velocity = chaseDir * chaseSpeed;
        }
        else
        {
            //if the player is NOT close, stop moving
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
    }
}
