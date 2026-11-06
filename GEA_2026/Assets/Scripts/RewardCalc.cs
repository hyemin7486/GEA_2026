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
        int min = (playSeconds % 3600) / 60;
        int sec = playSeconds % 60;


        Debug.Log("플레이 시간" + hours + "시간" + min + "분" + sec + "초");

        int indanggold = gold / members;
        int bonus = gold % members;

        Debug.Log("1인당 " + indanggold + "G, 리더 보너스 " + bonus + "G");

        int baseExp = kills * expPerKill;
        int totalExp = (int)(baseExp * expRate);

        Debug.Log("경험치 " + totalExp + "(기본" + baseExp + ")");

        int level = totalExp / 100 + 1;
        int nextExp = 100 - (totalExp % 100);

        Debug.Log("Lv " + level + ", 다음 레벨까지 " + nextExp);

        float averageDamage = (float)totalDamage / hits;
       
        Debug.Log("평균 데미지 " + averageDamage);
    }
}
