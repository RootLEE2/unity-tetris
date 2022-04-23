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
        StageController.instance.SetupBackground(stageWidth, stageHeight);
        BorderController.instance.SetupBackground(stageWidth, stageHeight);
    }   
}

public interface IBackgroundSetting
{
    void SetupBackground(int a_stageWidth, int a_stageHeight);
}