using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public Text levelCompleted;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //SceneManager.LoadScene(1);
            levelCompleted.enabled = true;
            Debug.Log("Level Won");
        }
    }
}
