using UnityEngine;

public class Lesson10 : MonoBehaviour
{

    [ContextMenu("예측 1")]
    void Predict1()
    {
        int hp = 0;
        bool hasShield = true;
        bool isDead = hp <= 0;
        Debug.Log(isDead);
        Debug.Log(isDead && !hasShield);
        Debug.Log(isDead || hasShield);
        Debug.Log(!(hp > 0) == isDead);
    }

    [ContextMenu("판단")]
    void Judge()
    {
        int hp = 20;
        int maxHp = 100;
        bool isStunned = false;
        bool hasPoison = false;

        bool canAttack = hp > 0 && !isStunned;
        bool isDanger = hp <= maxHp / 4 || hasPoison;
        Debug.Log(canAttack);
        Debug.Log(isDanger);
    }

    [ContextMenu("격자")]
    void Grid()
    {
        string text = "";
        for (int row = 1; row <= 2; row++)
        {
            for (int col = 1; col <= 3; col++)
            {
                text += row + "-" + col + " ";
            }
            text += "\n";
        }
        Debug.Log(text);
    }



    [ContextMenu("계단")]
    void Stairs()
    {
        int height = 3;
        string result = "";
        for (int row = 1; row <= height; row++)
        {
            for (int col = 0; col < row; col++)
            {
                result += "*";
            }
            result += "\n";
        }
        Debug.Log(result);
    }

    [ContextMenu("뒤집힌 계단")]
    void ReverseStairs()
    {
        int height = 4;
        string result = "";
        for (int row = height; row > 0; row--)
        {
            for (int i = 0; i < row; i++)
            {
                result += "*";
            }
            result += "\n";
        }
        Debug.Log(result);
    }

    [ContextMenu("오른쪽 계단")]
    void RightStairs()
    {
        int height = 4;
        string result = "";
        for (int row = 1; row <= height; row++)
        {
            int spaceCount = height - row;
            int starCount = row;
            for (int i = 0; i < spaceCount; i++)
            {
                result += " ";
            }
            for (int i = 0; i < starCount; i++)
            {
                result += "*";
            }
            result += "\n";
        }
        Debug.Log(result);
    }

    [ContextMenu("트리")]
    void Tree()
    {
        int height = 4;
        string result = "";
        for (int row = 1; row <= height; row++)
        {
            int spaceCount = height - row;
            int starCount = 2 * row - 1;
            for (int i = 0; i < spaceCount; i++)
            {
                result += " ";
            }
            for (int i = 0; i < starCount; i++)
            {
                result += "*";
            }
            result += "\n";
        }
        Debug.Log(result);
    }

}
