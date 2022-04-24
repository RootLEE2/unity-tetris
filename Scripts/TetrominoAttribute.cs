using System.Collections.Generic;
using UnityEngine;

using BlockColor;

namespace TetrominoAttribute
{
    [System.Serializable]
    public struct TetrominoColor
    {
        public static readonly List<Color> TETROMINO_COLOR = new List<Color>
        {
            ColorSet.RED,
            ColorSet.ORANGE,
            ColorSet.YELLOW,
            ColorSet.GREEN,
            ColorSet.BLUE,
            ColorSet.INDIGO,
            ColorSet.PURPLE
        };
    }

    [System.Serializable]
    public struct TetrominoPosition
    {
        public static readonly List<List<Vector3>> TETROMINO_POSITION = new List<List<Vector3>>
        {
            // I
            new List<Vector3>
            {
                new Vector3(-2f, 0f, 0f),
                new Vector3(-1f, 0f, 0f),
                new Vector3( 0f, 0f, 0f),
                new Vector3( 1f, 0f, 0f)
            },
            // L
            new List<Vector3>
            {
                new Vector3(-1f, 0f, 0f),
                new Vector3( 0f, 0f, 0f),
                new Vector3( 1f, 0f, 0f),
                new Vector3( 1f, 1f, 0f)
            },
            // J
            new List<Vector3>
            {
                new Vector3(-1f, 0f, 0f),
                new Vector3( 0f, 0f, 0f),
                new Vector3( 1f, 0f, 0f),
                new Vector3(-1f, 1f, 0f)
            },
            // O
            new List<Vector3>
            {
                new Vector3( 0f, 0f, 0f),
                new Vector3( 1f, 0f, 0f),
                new Vector3( 0f, 1f, 0f),
                new Vector3( 1f, 1f, 0f)
            },
            // S
            new List<Vector3>
            {
                new Vector3(-1f, 0f, 0f),
                new Vector3( 0f, 0f, 0f),
                new Vector3( 0f, 1f, 0f),
                new Vector3( 1f, 1f, 0f)
            },
            // T
            new List<Vector3>
            {
                new Vector3(-1f, 0f, 0f),
                new Vector3( 0f, 0f, 0f),
                new Vector3( 1f, 0f, 0f),
                new Vector3( 0f, 1f, 0f)
            },
            // Z
            new List<Vector3>
            {
                new Vector3(-1f, 1f, 0f),
                new Vector3( 0f, 1f, 0f),
                new Vector3( 0f, 0f, 0f),
                new Vector3( 1f, 0f, 0f)
            }
        };
    }
}