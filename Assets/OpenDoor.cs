using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject thePlayer = GameObject.Find("WanderAvoidUnit");
        Movement Movement = thePlayer.GetComponent<Movement>();
        Movement.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 0)
        {
            Destroy(GetComponent<BoxCollider>());
        }
    }
}
