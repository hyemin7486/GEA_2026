using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725;
    public int gold = 1234;
    public int members = 4;
    public int kills = 7;
    public int expPerKill = 35;
    public int totalDamage = 250;
    public int hits = 20;
    public float expRate = 1.5f;

    [ContextMenu("정산")]
    
    void Test1()
    {
        int hours = playSeconds / 3600;
        int min = playSeconds % 60;
        int sec = playSeconds % 60;


        Debug.Log(hours + "시간" + min + "분" + sec + "초");
    }
}
