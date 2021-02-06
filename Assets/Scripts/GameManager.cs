using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PieceType[,] board;
    public GameObject whitePiece;
    public GameObject blackPiece;
    public Player[] players;

    void Start()
    {
        //CreateNewGame();
    }

    private void CreateNewGame()
    {
        InitPeices();
    }
    public void CreateNewPlayers(List<Piece> whiteList, List<Piece> blackList)
    {
        players = new Player[2];
        players[0] = new Player(PieceType.White, whiteList);
        players[1] = new Player(PieceType.Black, blackList);
    }
    private void InitPeices()
    {
        List<Piece> blackList = new List<Piece>();
        List<Piece> whiteList = new List<Piece>();

        for (int row = 0; row < 7; row += 2)
        {
            for (int col = 0; col < 3; col++)
            {
                if (col % 2 == 1)
                {
                    Instantiate(whitePiece, new Vector3(row + 1, 0.15f, col), Quaternion.Euler(90, 0, 0));
                    Instantiate(blackPiece, new Vector3(row, 0.15f, col + 5), Quaternion.Euler(90, 0, 0));
                    whiteList.Add(new Piece(PieceType.White,row + 1,col));
                    blackList.Add(new Piece(PieceType.Black, row, col + 5));
                }
                else
                {
                    Instantiate(whitePiece, new Vector3(row, 0.15f, col), Quaternion.Euler(90, 0, 0));
                    Instantiate(blackPiece, new Vector3(row + 1, 0.15f, col + 5), Quaternion.Euler(90, 0, 0));
                    whiteList.Add(new Piece(PieceType.White, row, col));
                    blackList.Add(new Piece(PieceType.Black, row + 1, col + 5));
                }
            }
        }
        CreateNewPlayers(whiteList, blackList);
    }
}

public enum PieceType
{
    Black,
    White,
    None
}
