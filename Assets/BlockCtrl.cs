using UnityEngine;
using System.Collections;

public class BlockCtrl : MonoBehaviour
{
    float Speed;
    void Start()
    {
        Speed = 10f;
        this.GetComponent<Renderer>().material.color = Color.red;
    }
    void Update()
    {
		this.transform.Translate (Vector3.back * Time.deltaTime * Speed); // 往-Z軸的方向移動
    }
}
