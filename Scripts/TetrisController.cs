using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisController : MonoBehaviour
{
    [Header("Game Settings")]
    [SerializeField, Range(4, 40)] private int stageWidth = 10;
    [SerializeField, Range(5, 20)] private int stageHeight = 20;
    [SerializeField] private float fallCycle = 1.0f;

    private void Start()
    {
        TetrominoController.instance.gameObject.transform.position = new Vector3(0f, stageHeight/2+1, 0f);

        StageController.instance.SetupBackground(stageWidth, stageHeight);
        BorderController.instance.SetupBackground(stageWidth, stageHeight);
        TetrominoController.instance.CreateTetromino();
    }
}

public interface IBackgroundSetting
{
    void SetupBackground(int a_stageWidth, int a_stageHeight);
}