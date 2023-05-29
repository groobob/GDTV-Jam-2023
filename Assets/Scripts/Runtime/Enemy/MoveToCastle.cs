using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToCastle : MonoBehaviour
{
    public static event OnCastleReachedEvent OnCastleReached;
    public delegate void OnCastleReachedEvent(int damage);

    public int damage;
    public Transform castle;
    public Transform MyTransform;

    private void Awake()
    {
        MyTransform = gameObject.GetComponent<Transform>();
        castle = GameObject.Find("Castle").GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(MyTransform.position, castle.position) > 1f)
        {
            transform.position = Vector2.MoveTowards(MyTransform.position, castle.position, .05f * Time.deltaTime);
        }
        else
        {
            OnCastleReached?.Invoke(damage);
            Destroy(gameObject);
        }
    }
}
