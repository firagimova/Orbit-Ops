using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Astroids : MonoBehaviour
{
    public GameObject[] drops;

    public int hp = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //when the astroid trigger collides with "Player", destroy the astroid

    private void OnTriggerEnter(Collider other)
    {
        hp -= 1;

        if (other.gameObject.tag == "Player")
        {
            //ifthe object name is Player1, take damage from Player1
            if (other.gameObject.name == "Player1")
            {
                other.gameObject.GetComponent<Player>().TakeDamage(1);
            }
                
            //if the object name is Player2, take damage from Player2
            else if (other.gameObject.name == "Player2")
            {
                  other.gameObject.GetComponent<Player2>().TakeDamage(1);
            }
               

            if(hp <= 0)
            {
                

                Destroy(gameObject);
            }
            
        }

        if(other.gameObject.tag == "Laser")
        {
            //instantiate a random drop with the same position as the astroid with 30/100 chance
            int chance = Random.Range(0, 100);

            if (chance <= 30)
            {
                int drop = Random.Range(0, 3);
                GameObject dropInstance = Instantiate(drops[drop], transform.position, Quaternion.identity);
                //make the object Map its parent
                dropInstance.transform.parent = GameObject.Find("Map").transform;
            }

            Destroy(other.gameObject);
            if (hp <= 0)
            {


                Destroy(gameObject);
            }
        }
        if (other.gameObject.tag == "Shield")
        {
            if (hp <= 0)
            {


                Destroy(gameObject);
            }
        }
    }

    

}
