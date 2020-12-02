using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGeneration : MonoBehaviour
{

    public GameObject[] itemList;
    GameObject item;
    // Start is called before the first frame update
    void Start()
    {
        int randItem = Random.Range(0, itemList.Length);
        item = itemList[randItem];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public GameObject GetItem()
    {
        return item;
    }
}
