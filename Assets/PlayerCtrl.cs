using UnityEngine;
using System.Collections;

public class PlayerCtrl : MonoBehaviour
{

    float Offset;
    float Speed;
    float ForcePower;
    public int HP;
	public Texture heart;

    void Start()
    {
        Speed = 500f;       //滾動速度
        Offset = 1f;        //位移單位
        ForcePower = 200f;  //跳躍力量
        HP = 3;             //血量
    }

    // 請完成以下功能
    void Update()
    {
		// 以X軸原地滾動
		this.transform.Rotate (Speed * Time.deltaTime,0,0);

		// 按下D鍵往右移動一個Offset
		if(Input.GetKeyDown(KeyCode.D)){			
			this.transform.Translate (Vector3.right * Offset);
		}

        // 按下A鍵往左移動一個Offset
		if(Input.GetKeyDown(KeyCode.A)){			
			this.transform.Translate (Vector3.left * Offset);
		}

        // 按下空白鍵(Space)圓地跳躍。注意，在跳躍的狀態不可再次跳躍。
		if (this.transform.position.y <= 0.501f) {
			if(Input.GetKeyDown(KeyCode.Space)){
				this.transform.Translate (Vector3.up * Offset, Space.World);
			}
		}
    }

    void OnCollisionEnter(Collision target)
    {
        // 碰撞到Block時，血量少1
		if (target.collider.name == "Block(Clone)") {
			HP--;
		}
        // 請注意，這個function是利用Collision，而非平時的Trigger


    }

    // 在畫面右上角以垂直方式顯示目前血量
    void OnGUI()
    {
		for(int i = 0; i < HP; i++) {
			GUI.DrawTexture (new Rect (0, i*30, 30, 30), heart, ScaleMode.ScaleToFit);
		}
    }

}
