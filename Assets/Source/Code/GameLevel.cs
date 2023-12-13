using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLevel : MonoBehaviour
{
    public List<GameObject> gameObjectsPoint;
    public List<GameObject> listSlot;
    [SerializeField] private Transform parentListObjPoint;
    [SerializeField] private Transform parentListObjSlot;
    private bool canCheck = true;
    public void Start()
    {
        canCheck = true;
        foreach (Transform tr in parentListObjPoint)
        {
            if(tr.gameObject.activeSelf)
                gameObjectsPoint.Add(tr.gameObject);
        }
        foreach (Transform tr in parentListObjSlot)
        {
            listSlot.Add(tr.gameObject);
        }
    }

    public void RemoveObject(GameObject obj)
    {
        listSlot.Remove(obj);
        if (listSlot.Count == 0)
        {
            GameManager.Instance.CheckLevelUp();
            canCheck = false;
        }
    }
}
