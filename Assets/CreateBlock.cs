using UnityEngine;
using System.Collections;

public class CreateBlock : MonoBehaviour
{
    float Cooldown;
	public GameObject Block;

    void Start()
    {
        Cooldown = 1f;
    }
    
    void Update()
    {
		//當Cooldown <= 0，產生一個block
        //block的位置在Vector3(Random.Range(-1, 2), 0, 25)
		Cooldown -= Time.deltaTime;
		if (Cooldown <= 0) {
			GameObject copObj = GameObject.Instantiate (Block,new Vector3 (Random.Range (-1, 2), 0, 25), Block.transform.rotation);
			Cooldown = 1f;
		}
    }
}
