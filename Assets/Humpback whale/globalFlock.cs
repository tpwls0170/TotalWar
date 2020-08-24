using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalFlock : MonoBehaviour
{
    public GameObject fishPrefab;
    public GameObject goalPrefab;
    public static int tankSize = 25;

    static int numFish = 20;
    public static GameObject[] allFish = new GameObject[numFish];

    public static Vector3 goalPos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numFish; ++i)
        {
            Vector3 pos = new Vector3(Random.Range(goalPrefab.transform.position.x - 5, goalPrefab.transform.position.x + 5),
                0f,
                Random.Range(goalPrefab.transform.position.z - 5, goalPrefab.transform.position.z + 5));
            allFish[i] = (GameObject)Instantiate(fishPrefab, pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        goalPos = goalPrefab.transform.position;
    }
}
