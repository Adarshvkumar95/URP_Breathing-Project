using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;
    public GameObject canvas4;
    public GameObject canvas5;
    public GameObject canvas6;



    public void EnableCanvas1()
    {
        canvas1.SetActive(true);
        canvas6.SetActive(false);
    }

    public void EnableCanvas2()
    {
        canvas6.SetActive(false);
        canvas2.SetActive(true);
        
    }

    public void EnableCanvas3()
    {
        canvas6.SetActive(false);
        canvas3.SetActive(true);
        
    }

    public void EnableCanvas4()
    {
        canvas6.SetActive(false);
        canvas4.SetActive(true);
        
    }

    public void EnableCanvas5()
    {
        canvas6.SetActive(false);
        canvas5.SetActive(true);
        
    }

}
