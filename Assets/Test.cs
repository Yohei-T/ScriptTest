using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
    private int mp = 53;
    public void Magic() {
        if(mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは"+ mp +"。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        int[] array = { 0, 1, 2, 3, 4 };
        for(int i = 0; i < 5; i++) {
            Debug.Log(array[i]);
        }

        for(int i = 0; i < 5; i++) {
            Debug.Log(array[4 - i]);
        }

        Boss boss = new Boss();

        for(int i = 0; i < 11; i++)
        {
            boss.Magic();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
