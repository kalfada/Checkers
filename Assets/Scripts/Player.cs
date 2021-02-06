using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Player(PieceType color, List<Piece> list)
    {
        this.color = color;
        this.list = list;
    }
    public PieceType color
    {
        get; set;
    }
    private List<Piece> list;
}
