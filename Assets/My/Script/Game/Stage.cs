using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    [SerializeField] List<Transform> item_tracsform_list_ = new List<Transform>();
    [SerializeField] List<GameObject> item_list_ = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        ItemSet();
    }

    void ItemSet()
    {
        System.Random r = new System.Random();
        for (var i = 0; i < item_list_.Count; i++)
        {
            int max = item_tracsform_list_.Count;
            int rnd = r.Next(max);
            Transform transform = item_tracsform_list_[rnd];
            item_tracsform_list_.RemoveAt(rnd);

            GameObject item = item_list_[i];
            item.transform.position = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
