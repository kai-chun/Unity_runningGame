using UnityEngine;
using System.Collections;

public class Deadline : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider Target)
    {
        //摧毀Block
		Destroy(Target.gameObject);
    }
}
