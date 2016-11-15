using UnityEngine;
using System.Collections;

public class RoleContoller : MonoBehaviour {

    public AudioSource bgm;
    Animator anim;
    bool initPlay = true;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
    public void OnMoveRole() {
        bgm.Play();
        anim.SetTrigger("Dance");
        //设置旋转播放
        if (initPlay)
        {
            anim.SetLayerWeight(1, 1f);
            initPlay = false;
        }else {
            anim.SetTrigger("DanceRotation");
        }
    }

    public void OnStopRole()
    {
        bgm.Stop();
        anim.SetTrigger("IdelRotation");
        anim.SetTrigger("Idel");
    }

    void CallUnity(object obj)
    {
        string val = string.Format("{0}", obj);
        Debug.Log("val=" + val);
    }
}
