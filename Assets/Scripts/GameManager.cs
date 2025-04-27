using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float Level(int score)
    {
        float defalutSpeed = 5f;
        float speedUp = (score) / 100;

        return defalutSpeed + speedUp;      
    }
}
