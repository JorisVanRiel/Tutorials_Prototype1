using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject Player;

    [SerializeField] private Vector3 offset = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void LateUpdate()
    {
        this.transform.position = Player.transform.position + offset;
    }
}
