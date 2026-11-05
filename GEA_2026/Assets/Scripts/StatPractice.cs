using UnityEngine;

public class StatPractice : MonoBehaviour
{
    public string playerName;
    public int level;
    public float attack;
    public bool isBoss;

    [ContextMenu("스탯")]
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void ShowStat()
    {
        Debug.Log("플레이어 이름 : " + playerName);
        Debug.Log("레벨 : " + level);
        Debug.Log("공격력 : " + attack);
        Debug.Log("보스 여부 : " + isBoss);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
