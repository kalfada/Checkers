using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece
{
    public Piece(PieceType color, int row, int col)
    {
        this.color = color;
        this.row = row;
        this.col = col;
    }
    public PieceType color
    {
        get;set;
    }
    public int row
    {
        get; set;
    }
    public int col
    {
        get; set;
    }
}
