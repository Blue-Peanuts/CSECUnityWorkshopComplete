using System.Collections;
using UnityEngine;

public class GameFeedback : MonoBehaviour
{
    public static GameFeedback instance;
    Vector3 cameraPosition;
    void Start()
    {
        instance = this;
        cameraPosition = Camera.main.transform.position;
    }

    private IEnumerator ScreenShake(float intensity)
    {
        for (int i = 0; i < 10; i++)
        {
            Camera.main.transform.position = cameraPosition + Random.insideUnitSphere * intensity;
            yield return new WaitForSeconds(0.02f);
        }
    }

    public void EnemyHit()
    {
        StartCoroutine(ScreenShake(0.06f));
    }

    public void EnemyKilled()
    {
        StartCoroutine(ScreenShake(0.2f));
    }
}
