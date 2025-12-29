using UnityEngine;
using UnityEngine.InputSystem;
using System;
using System.Collections;
using System.Collections.Generic;

public class Testing : MonoBehaviour
{

    [SerializeField] private Unit unit;
    private void Start()
    {
       
    }

    private void Update()
    {
        /**網格座標位置顯現測試
         * if (Keyboard.current.tKey.wasReleasedThisFrame)
        {
            GridSystemVisual.Instance.HideAllGridPosition();
            GridSystemVisual.Instance.ShowGridPositionList(
            unit.GetMoveAction().GetValidActionGridPositionList());
        }**/

        if (Keyboard.current.tKey.wasReleasedThisFrame)
        {
            /* 路徑測試線
            GridPosition mouseGridPosition = LevelGrid.Instance.GetGridPosition(MouseWorld.GetPosition());
            GridPosition startGridPosition = new GridPosition(0, 0);

            List<GridPosition> gridPositionList = Pathfinding.Instance.FindPath(startGridPosition, mouseGridPosition);

            for (int i = 0; i < gridPositionList.Count - 1; i++)
            { 
                Debug.DrawLine(
                    LevelGrid.Instance.GetWorldPosition(gridPositionList[i]),
                    LevelGrid.Instance.GetWorldPosition(gridPositionList[i + 1 ]),
                    Color.white,
                    10f
                    );
            }
            */
            /* 振動測試
               ScreenShake.Instance.Shake(5f); 
             */


        }
    }
}
