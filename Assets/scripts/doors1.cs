using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doors1 : MonoBehaviour {

    private Animator mAnimator;

    public bool open = false;

    // Use this for initialization
    void Start()
    {
        mAnimator = this.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            GameObject player = GameObject.Find("Player");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100) && hit.collider.name == GetComponent<Collider>().name && Vector3.Distance(player.transform.position, this.transform.position) <= 2.5)
            {
                if (open)
                {
                    open = false;
                }
                else
                {
                    open = true;
                }
                mAnimator.SetBool("open", open);
            }
        }
       

    }

}
