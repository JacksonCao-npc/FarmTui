using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Inventory inventory;
    

    private void Awake()
    {
        inventory = new Inventory(21);
    }

    public void DropItem(Collectable item)
    {
        Vector3 spawnLocation = transform.position;



        Vector3 spawnOffset = new Vector3(0, -2, 0);

        Collectable droppedItem = Instantiate(item, spawnLocation + spawnOffset, Quaternion.identity);

        

        Debug.Log(droppedItem.type);
    }
  
}
