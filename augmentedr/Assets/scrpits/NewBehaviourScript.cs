using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    public GameObject[] menuPanels;
     public int menuID=0;
    private GameObject menuPanel1, menuPanel2, menuPanel3, menuPanel4,Next;
    // Use this for initialization
    void Start () {
        menuPanels = GameObject.FindGameObjectsWithTag("Main_panel");
        menuPanel1 = GameObject.FindGameObjectWithTag("step_1");
        menuPanel2 = GameObject.FindGameObjectWithTag("step_2");
        menuPanel3 = GameObject.FindGameObjectWithTag("step_3");
        menuPanel4 = GameObject.FindGameObjectWithTag("step_4");
        Next=GameObject.FindGameObjectWithTag("Next");
        menuPanel2.gameObject.SetActive(false);
        menuPanel3.gameObject.SetActive(false);
        menuPanel4.gameObject.SetActive(false);
        
    }
	
	// Update is called once per frame
	void Update () {
         if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
 
                return;
            }
	
	}
public void switchToMenu(int menuID) {
        
        if (menuPanel2.active==true)
        {
            menuID=1;
        }
         if (menuPanel3.active==true)
        {
            menuID=2;
        }
        if (menuPanel4.active==true)
        {
            menuID=3;
        }

         switch (menuID) {
             case 0:
             Debug.Log (menuID);
             menuPanel1.gameObject.SetActive(false);
             menuPanel2.gameObject.SetActive(true);
             menuPanel3.gameObject.SetActive(false);
             menuPanel4.gameObject.SetActive(false);

                 break;
             case 1:
             Debug.Log (menuID);
             menuPanel1.gameObject.SetActive(false);
             menuPanel2.gameObject.SetActive(false);
             menuPanel3.gameObject.SetActive(true);
             menuPanel4.gameObject.SetActive(false);
            
                 break;
            case 2:
             Debug.Log (menuID);
             menuPanel1.gameObject.SetActive(false);
             menuPanel2.gameObject.SetActive(false);
             menuPanel3.gameObject.SetActive(false);
             menuPanel4.gameObject.SetActive(true);
            
                 break;
            case 3 : 
            Application.LoadLevel("markerlist");
            break;
         }
     }

   
}

