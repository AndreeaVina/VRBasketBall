using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coliziune : MonoBehaviour
{
    GameObject win;
    void Start()
    {
        win = GameObject.Find("Win");
        win.SetActive(false);
    }

    IEnumerator OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Ball1" || collision.collider.name == "Ball2")
        {
            win.SetActive(true);
            yield return new WaitForSeconds(5);
            win.SetActive(false);
        }
    }
}