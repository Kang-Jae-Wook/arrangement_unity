using System.Collections;
using UnityEngine;

class CoinManager : MonoBehaviour
{
    public GameObject Coin;
    public float Radius = 10f;

    private void Start()
    {
        StartCoroutine(SpawnCoin(1f));
    }
    
    private IEnumerator SpawnCoin(float waitTime)
    {
        yield break;
    }

    private Vector3 GetRandomCoinPosition()
    {
        return new Vector3(
            Random.Range(-Radius, Radius),
            Random.Range(-Radius, Radius),
            transform.position.y);
    }
}