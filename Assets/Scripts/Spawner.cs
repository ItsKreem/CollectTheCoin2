using TMPro;
using System.Globalization;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject RareCoinPrefab;
    public GameObject CoinPrefab;
    public float DurationLeft = 60f;
    public float SpawnInterval = 1f;
    public float MinX = -1f;
    public float MaxX = 1f;
    public float rMinX = -1f;
    public float rMaxX = 1f;
    private float randomX;
    private float spawnTimer;
    public float CoinsCollected;
    public TMP_Text Text;
    public bool isTimesUp = false;
    public bool isSpawning = false;

    void Start()
    {
        spawnTimer = SpawnInterval;
    }

    void Update()
    {
        if (isTimesUp)
        {
            return;
        }

        if (spawnTimer > 0)
        {
            spawnTimer -= Time.deltaTime;
        }
        else
        {
            float rand = Random.Range(MinX, MaxX);

            float rarerand = Random.Range(rMinX, rMaxX);

            float RareCoinPercentage = Random.Range(0, 100);

            Vector3 randomPos = new Vector3(rand, transform.position.y, transform.position.x);

            Vector3 rarerandomPos = new Vector3(rarerand, transform.position.y, transform.position.x);

            if (CoinPrefab != null)
            {
                GameObject.Instantiate(CoinPrefab, randomPos, transform.rotation);
            }

            if (RareCoinPercentage > 90)
            {
                if (RareCoinPrefab != null)
                {
                    GameObject.Instantiate(RareCoinPrefab, rarerandomPos, transform.rotation);
                }
            }

            spawnTimer = SpawnInterval;
        }
    }
    public void AddCoins(float amount)
    {
        CoinsCollected += amount;
        Debug.Log("Collected coins " + CoinsCollected);

        if (Text != null)
        {
            Text.text = CoinsCollected.ToString();
        }
    }
}
