using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAngry : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private Animator anim;

    Rigidbody rb;
    private float speed = 6.0f;
    private float dist;

    void Start()
    {
        anim = GetComponent<Animator>();
        setPlrState(0);
    }
    
    void Update()
    {
        dist = (gameObject.transform.position - player.transform.position).magnitude;
        if (dist > 15.0f)
        {
            setPlrState(0);
        }
        else if(dist < 15.0f && dist > 3.0f)
        {
            setPlrState(1);
        }
    }

    private void setRndAttack()
    {
        anim.SetInt("attackState", Random.Range(1, 3));
    }

    private void setPlrState(int state)
    {
        anim.SetInt("seePlayerState", state);
    }
}
