using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public Slider vidaE;

  

    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.CompareTag("Bala"))
        {
            vidaE.value -= 10f;
        }
        if (vidaE.value == 0)
        {
            gameObject.SetActive(false);
        }

	}
}
