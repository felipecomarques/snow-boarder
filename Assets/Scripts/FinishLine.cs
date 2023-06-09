using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float Delay = 2f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Invoke("ReloadScene",Delay);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
