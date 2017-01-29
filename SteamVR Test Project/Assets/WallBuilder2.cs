using UnityEngine;
using System.Collections;

public class WallBuilder2 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        for (int y = 0; y < 3; y++)
        {
            for (int x = 0; x < 11; x++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.AddComponent<Rigidbody>();
                cube.transform.position = new Vector3(x, y, 0);
            }
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
