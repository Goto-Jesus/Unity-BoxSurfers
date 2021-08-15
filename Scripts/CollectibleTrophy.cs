using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleTrophy : MonoBehaviour
{
    bool check;
    int index;
    public Picker picker;

    private void Start()
    {
        check = false;
    }

    private void Update()
    {
        if (check == true)
        {
            if (transform.parent != null)
                transform.localPosition = new Vector3(0, -index, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            picker.DecreaseInHeight();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    public bool GetToplandiMi()
    {
        return check;
    }

    public void ToplandiYap()
    {
        check = true;
    }
    public void IndexAyarla(int index)
    {
        this.index = index;
    }
}
