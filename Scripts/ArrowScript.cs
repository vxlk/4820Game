using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour {

    public int damage;
    //public ScoreKeeper skeep;
    public string playerTag;

    void Start()
    {
       // skeep = GameObject.Find("_GM").GetComponent<ScoreKeeper>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == playerTag)
        {
           // skeep.selectedGO = col.gameObject;
            //skeep.selected = true;
            PlayerStats stats = col.gameObject.GetComponent<PlayerStats>();
            stats.Hit(damage);
        }
    }
}
