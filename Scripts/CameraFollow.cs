using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    public GameObject player;
	
    
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(player.transform.position.y > 0)
        {
            if(player.transform.position.y > transform.position.y)
            {
                this.transform.position = new Vector3(5, player.transform.position.y, -10);
            }
        }

    }
}
