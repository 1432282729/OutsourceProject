using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TestController : MonoBehaviour {


    public Text text;

    private int count = 0;

    public void OnTest() {

        count++;
        text.text = count + "";
    }

    public void CallUnity(Object obj) {
        text.text = obj.ToString();
    }

}
