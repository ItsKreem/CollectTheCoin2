using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int CoinsAmount = 10;
    public AudioSource CoinCollectedAudio;
    public GameObject Effects;

    public float tempCoinsFloat;
    private Collider2D _Collider2D;

    private Spawner _spawner; //counter

    private ScoreManager _scoreManager;

    // Start is called before the first frame update
    private void Start()
    {
        _Collider2D = GetComponent<Collider2D>();
        //_AudioSource = GetComponent<AudioSource>();

        _spawner = FindObjectOfType<Spawner>();

        _scoreManager = GameObject.FindObjectOfType<ScoreManager>();
    }
    private void OnMouseOver()
    {
        if (_scoreManager != null)
        {
            _scoreManager.CoinsCollected(CoinsAmount);
        }

        if (CoinCollectedAudio != null)
        {
            GameObject.Instantiate(CoinCollectedAudio, transform.position, Quaternion.identity);
        }

        if (Effects != null)
        {
            GameObject.Instantiate(Effects, transform.position, Quaternion.identity);
        }

        if (_spawner != null)
        {
            //spawner will add points to CoinsCollected;
            _spawner.AddCoins(CoinsAmount);
        }
        Debug.Log("Coins collected " + CoinsAmount);
        Destroy(this.gameObject);
    }
}

