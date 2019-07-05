using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour {

    //シーン中のカメラのオブジェクト
    private GameObject cam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
        //シーン中のメインカメラを取得
        this.cam = GameObject.Find("Main Camera");

        //アイテムのZ座標がカメラのZ座標以下になった時にアイテムを破棄する。
        if (this.cam.transform.position.z > this.transform.position.z)
        {
            Destroy(this.gameObject);
        }

    }
    
}
