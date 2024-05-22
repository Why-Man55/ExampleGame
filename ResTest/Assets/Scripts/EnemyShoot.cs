using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Animator ani;
    public Behaviour rat;

    public int hp = 10;
    private float timeWait;
    private int dieType;

    void Start()
    {
        ani = GetComponent<Animator>();
        dieType = Random.Range(1, 2);
    }

    void Update()
    {
        setDeath();
    }

    IEnumerator setDeath()
    {
        if(hp == 0)
        {
            switch (dieType)
            {
                case 1:
                    ani.SetTrigger("dieA");
                    yield return new WaitForSeconds(1.2f);
                    rat.enabled = false;
                    break;
                case 2:
                    ani.SetTrigger("dieB");
                    yield return new WaitForSeconds(0.25f);
                    rat.enabled = false;
                    break;
            }
            gameObject.GetComponent<EnemyAngry>().enabled = false;
        }
    }
}
