using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMechanics : MonoBehaviour
{
    public float speed = 3f;
    public Vector3 direction = Vector3.right;
    public float range = 5f;
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Mathf.PingPong(Time.time * speed, range);
        Vector3 newPosition = initialPosition + direction * distance;
        transform.position = newPosition;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
    }
}
