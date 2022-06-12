using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour
{
    [SerializeField] Backpack backpack = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            backpack.UpdateKeys(1);
            Destroy(collision.gameObject);
            
        }
        CheckIfITem(collision);
    }

    private void CheckIfITem(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            GrabItemByType(collision.GetComponent<Itemizer>());
        }
    }

    private void GrabItemByType(Itemizer item)
    {
        if (item.GetIsAKey)
        {
            GrabKey();
        }
        else
        {
           /* GrabGenericItem();*/
        }

        Destroy(item.gameObject);
    }

    private void GrabKey()
    {
        backpack.UpdateKeys(1);
    }

    /*private void GrabGenericItem(Itemizer item)
    {
        backpack.AddItem(item.GetButton);
    }*/

}
