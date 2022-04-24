using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BlockColor;

public class TetrominoController : BlockSpawner
{
    public static TetrominoController instance;

    private Color[] tetrominoColor = new Color[]
    {
        ColorSet.RED,
        ColorSet.ORANGE,
        ColorSet.YELLOW,
        ColorSet.GREEN,
        ColorSet.BLUE,
        ColorSet.INDIGO,
        ColorSet.PURPLE
    };
    
    private void Awake()
    {
        base.Awake();
        
        instance = this;
    }

    public void CreateTetromino()
    {
        int shapeIdx = Random.Range(0, 7);
        int colorIdx = Random.Range(0, 7);

        Color blockColor = tetrominoColor[colorIdx];

        Vector3[] fourBlockPos = new Vector3[4];

        switch (shapeIdx)
        {
            case 0: {
                fourBlockPos[0] = new Vector3(-2f, 0f, 0f);
                fourBlockPos[1] = new Vector3(-1f, 0f, 0f);
                fourBlockPos[2] = new Vector3( 0f, 0f, 0f);
                fourBlockPos[3] = new Vector3( 1f, 0f, 0f);
                break;
            }
            case 1: {
                fourBlockPos[0] = new Vector3(-1f, 0f, 0f);
                fourBlockPos[1] = new Vector3( 0f, 0f, 0f);
                fourBlockPos[2] = new Vector3( 1f, 0f, 0f);
                fourBlockPos[3] = new Vector3( 1f, 1f, 0f);
                break;
            }
            case 2: {
                fourBlockPos[0] = new Vector3(-1f, 0f, 0f);
                fourBlockPos[1] = new Vector3( 0f, 0f, 0f);
                fourBlockPos[2] = new Vector3( 1f, 0f, 0f);
                fourBlockPos[3] = new Vector3(-1f, 1f, 0f);
                break;
            }
            case 3: {
                fourBlockPos[0] = new Vector3( 0f, 0f, 0f);
                fourBlockPos[1] = new Vector3( 1f, 0f, 0f);
                fourBlockPos[2] = new Vector3( 0f, 1f, 0f);
                fourBlockPos[3] = new Vector3( 1f, 1f, 0f);
                break;
            }
            case 4: {
                fourBlockPos[0] = new Vector3(-1f,-1f, 0f);
                fourBlockPos[1] = new Vector3( 0f,-1f, 0f);
                fourBlockPos[2] = new Vector3( 0f, 0f, 0f);
                fourBlockPos[3] = new Vector3( 1f, 0f, 0f);
                break;
            }
            case 5: {
                fourBlockPos[0] = new Vector3(-1f, 0f, 0f);
                fourBlockPos[1] = new Vector3( 0f, 0f, 0f);
                fourBlockPos[2] = new Vector3( 1f, 0f, 0f);
                fourBlockPos[3] = new Vector3( 0f, 1f, 0f);
                break;
            }
            case 6: {
                fourBlockPos[0] = new Vector3(-1f, 1f, 0f);
                fourBlockPos[1] = new Vector3( 0f, 1f, 0f);
                fourBlockPos[2] = new Vector3( 0f, 0f, 0f);
                fourBlockPos[3] = new Vector3( 1f, 0f, 0f);
                break;
            }
            default: {
                Debug.LogError("Error: Random value out of range");
                return;
            }
        }

        foreach (Vector3 blockPos in fourBlockPos)
        {
            CreateBlock(transform, blockPos, blockColor, 1);
        }
    }
}
