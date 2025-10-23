using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private void Start()
    {
        float x = Random.Range(-23, 23);
        float z = Random.Range(-23, 23);
        transform.position = new Vector3(x, 0.5f, z);
    }

    public void MyRandom()
    {
        float x = Random.Range(-23, 23);
        float z = Random.Range(-23, 23);
        transform.position = new Vector3(x, 0.5f, z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //SceneManager.LoadScene(0);
            MyRandom();
        }
    }
}
