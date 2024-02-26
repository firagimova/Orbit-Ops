using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Laser : MonoBehaviour
{
    float speed = 15.0f;

    private float initialXPosition;
    private float initialZPosition;
    private float initialYPosition;

    // Start is called before the first frame update
    void Start()
    {
        initialXPosition = transform.position.x;
        initialZPosition = transform.position.z;
        initialYPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //move laser up
        //transform.Translate(Vector3.up * speed * Time.deltaTime);

        transform.position = new Vector3(initialXPosition, transform.position.y + speed * Time.deltaTime, initialZPosition);

        // Check if the laser has left the screen
        if (!IsInView(Camera.main, transform.position))
        {
            Destroy(gameObject); // Destroy the laser object
        }
    }

    bool IsInView(Camera camera, Vector3 position)
    {
        Vector3 viewportPosition = camera.WorldToViewportPoint(position);
        return viewportPosition.x >= 0 && viewportPosition.x <= 1
            && viewportPosition.y >= 0 && viewportPosition.y <= 1
            && viewportPosition.z > 0; // Check if the object is in front of the camera
    }

    //when it collides with an astroid, make parent object's points go up by 1
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Astroid")
        {
            

            //get parent object's points
            if (gameObject.transform.parent.gameObject.name == "Player1")
            {
                
                gameObject.transform.parent.gameObject.GetComponent<Player>().points++;
                PlayerPrefs.SetInt("p1", gameObject.transform.parent.gameObject.GetComponent<Player>().points);
            }
            else if (gameObject.transform.parent.gameObject.name == "Player2")
            {
                gameObject.transform.parent.gameObject.GetComponent<Player2>().points++;
                PlayerPrefs.SetInt("p2", gameObject.transform.parent.gameObject.GetComponent<Player2>().points);
            }
            
            //don't follow parent object's x and y without making parent null   



            
        }
    }
    


}
