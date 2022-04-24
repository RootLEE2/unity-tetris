using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TetrominoAttribute;

public class TetrominoController : BlockSpawner
{
    public static TetrominoController instance;

    private static readonly List<List<Vector3>> tetrominoPosition = TetrominoPosition.TETROMINO_POSITION;
    private static readonly List<Color> tetrominoColor = TetrominoColor.TETROMINO_COLOR;
    
    private void Awake()
    {
        base.Awake();
        
        instance = this;
    }

    public void CreateTetromino()
    {
        int shapeIdx = Random.Range(0, tetrominoPosition.Count);
        int colorIdx = Random.Range(0, tetrominoColor.Count);

        List<Vector3> fourBlockPos = tetrominoPosition[shapeIdx];
        Color blockColor = tetrominoColor[colorIdx];

        foreach (Vector3 blockPos in fourBlockPos)
        {
            CreateBlock(transform, blockPos, blockColor, 1);
        }
    }
}
