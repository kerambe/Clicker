using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //[SerializeField] Camera camera;
    [SerializeField] private GameObject circlePrefab;
    private void Start()
    {
        Spawn();
    }
    public void Spawn()
    {
        var rnd = Random.Range(0, 2);
        Debug.Log(rnd);
        var circle = Instantiate(circlePrefab, new Vector3(Random.Range(-8, 9), Random.Range(-4, 5)), Quaternion.identity);
        circle.transform.localScale = new Vector3(rnd,rnd);
        circle.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(Random.Range(0,361),Random.Range(0,101),Random.Range(0,101));
    }
}
