using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAngry : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private Animator anim;

    Vector3 startPosition;
    public float duration;
    float timeElapsed = 0f;
    private float dist;

    void Start()
    {
        startPosition = transform.position;
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
            transform.position = Vector3.Lerp(startPosition, player.transform.position, timeElapsed / duration);
            timeElapsed += Time.deltaTime;
            anim.SetInteger("attackState", 0);
            transform.LookAt(player.transform.position);
        }
        else
        {
            setRndAttack();
        }
    }

    private void setRndAttack()
    {
        anim.SetInteger("attackState", Random.Range(1, 3));
    }

    private void setPlrState(int state)
    {
        anim.SetInteger("seePlayerState", state);
    }
}
