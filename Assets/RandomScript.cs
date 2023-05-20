using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomScript : MonoBehaviour
{
    public ViewManager viewManager;

    private void Awake()
    {
        viewManager = FindObjectOfType<ViewManager>().GetComponent<ViewManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        viewManager.LoadScene(GameScenes.cityView);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
