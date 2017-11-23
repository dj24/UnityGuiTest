using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAnim : MonoBehaviour {

    Animator anim, zoom;
    public Transform cam;

    
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        zoom = cam.GetComponent<Animator>();
    }

    public void Open()
    {
        if (this.anim.GetCurrentAnimatorStateInfo(0).IsName("Close") || this.anim.GetCurrentAnimatorStateInfo(0).IsName("idle"))
        {
            zoom.SetTrigger("zoomIn");
            anim.SetTrigger("Open");
        }
   
    }
    public void Close()
    {
        if (this.anim.GetCurrentAnimatorStateInfo(0).IsName("Open"))
        {
            zoom.SetTrigger("zoomOut");
            anim.SetTrigger("Close");
        }
        
    }

    // Update is called once per frame
    void Update () {
		
	}
}
