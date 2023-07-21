using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DependentMove : MonoBehaviour
{
    
    private float scale;
    private Vector3 a;

    [SerializeField] private GameObject map;
    [SerializeField] private GameObject room;
    [SerializeField] private GameObject obj;
    [SerializeField] private Animator objAnimator;
    [SerializeField] private Material greenMaterial;
    [SerializeField] private EndGame endGame;

    private bool isFirstPushed =false;

    // Start is called before the first frame update
    void Start()
    {
        //gets size of room and size of map to get scale in which models move
        scale= (map.GetComponent<Renderer>().bounds.size.x)/(room.GetComponent<Renderer>().bounds.size.x);
        
    }

    // Update is called once per frame
    void Update()
    {
        a = new Vector3(obj.transform.position.x * scale, transform.position.y, obj.transform.position.z * scale);
        transform.position = a;

        if (objAnimator.GetBool("triggerHebel") && !isFirstPushed)
        {
            GetComponent<Renderer>().material = greenMaterial;
            endGame.CountLeversPushed();
            isFirstPushed = true;
        }
    }

}
