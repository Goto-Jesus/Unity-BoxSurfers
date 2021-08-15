using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picker : MonoBehaviour
{
    GameObject player;
    int height;

    void Start()
    {
        player = GameObject.Find("Surfers Character");
    }

    void Update()
    {
        player.transform.position = new Vector3(transform.position.x, height + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -height, 0);
    }

    public void DecreaseInHeight()
    {
        height--;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "LiftUp"&& other.gameObject.GetComponent<CollectibleTrophy>().GetToplandiMi()==false)
        {
            height++;
            other.gameObject.GetComponent<CollectibleTrophy>().ToplandiYap();
            other.gameObject.GetComponent<CollectibleTrophy>().IndexAyarla(height);
            other.gameObject.transform.parent = player.transform;

        }
    }
}
