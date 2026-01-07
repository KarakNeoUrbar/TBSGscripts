using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScripting : MonoBehaviour
{
    [SerializeField] private List<GameObject> hider1List;
    [SerializeField] private List<GameObject> hider2List;
    [SerializeField] private List<GameObject> hider3List;
    [SerializeField] private List<GameObject> enemy1List;
    [SerializeField] private List<GameObject> enemy2List;
    [SerializeField] private Door door1;
    [SerializeField] private Door door2;
    [SerializeField] private List<GameObject> otherList;

    private bool hasShownHider = false;

    private void Start()
    {
        LevelGrid.Instance.OnAnyUnitMovedGridPosition += LevelGrid_OnAnyUnitMovedGridPosition;

        door1.OnDoorOpened += (object sender, EventArgs e) =>
        {
            SetActiveGameObjectList(hider1List, false);
            SetActiveGameObjectList(enemy1List, true);
        };

        door2.OnDoorOpened += (object sender, EventArgs e) =>
        {
            SetActiveGameObjectList(hider3List, false);
            SetActiveGameObjectList(otherList, true);
        };

    }

    private void LevelGrid_OnAnyUnitMovedGridPosition(object sender, LevelGrid.OnAnyUnitMovedGridPositionEventArgs e)
    {



            if (e.toGridPosition.z >= 11 && e.toGridPosition.x == 6 && !hasShownHider)
        {
            Debug.Log("passing lavel");
            hasShownHider = true;
            SetActiveGameObjectList(hider2List, false);
            SetActiveGameObjectList(enemy2List, true);
        }
    }

    private void SetActiveGameObjectList(List<GameObject> gameObjectList, bool isActive) 
    {
        foreach (GameObject gameObject in gameObjectList)
        { 
            gameObject.SetActive(isActive);
        }
    }
}
