using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisController : MonoBehaviour
{
    [Header("Objects & Prefabs")]
    [SerializeField] private GameObject blockPrefab;

    [Header("Game Settings")]
    [SerializeField, Range(4, 40)] private int stageWidth = 10;
    [SerializeField, Range(5, 20)] private int stageHeight = 20;
    [SerializeField] private float fallCycle = 1.0f;

    private void Start()
    {
        if (!blockPrefab) { Debug.LogError("Error: Prefab for block is missing"); }

        StageController.instance.SetupBackground(blockPrefab, stageWidth, stageHeight);
        BorderController.instance.SetupBackground(blockPrefab, stageWidth, stageHeight);
    }   
}

public interface IBackgroundSetting
{
    void SetupBackground(GameObject a_blockPrefab, int a_stageWidth, int a_stageHeight);
}