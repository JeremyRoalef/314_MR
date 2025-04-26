using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleZombieKill : MonoBehaviour
{
    [SerializeField]
    GameObject zambie;

    public void OnButtonKillZombie()
    {
        Destroy(zambie);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Zambie"))
        {
            Destroy(collision.gameObject);
        }
    }
}
