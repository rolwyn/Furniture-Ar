using UnityEngine;
using System.Collections;

public class list1_selection : MonoBehaviour
{
	public int menuid;
	public GameObject menuPanel11,menuPanel22, menuPanel33,menuPanel44, menuPanel55, officetable,glasstable, showtable, minitable, wooddrawer, bookdrawer,rockingchair, woodenchair, sofachair, woodswing, compdesk ;

	// Use this for initialization
	void Start () 
	{
		menuPanel11.active=true;
		menuPanel22.active=false;
		menuPanel33.active=false;
		menuPanel44.active=false;
        menuPanel55.active=false;
        officetable.active=false;
        glasstable.active=false;
        showtable.active=false;
        minitable.active=false;
        wooddrawer.active=false;
        bookdrawer.active=false;
        rockingchair.active=false;
        woodenchair.active=false;
        sofachair.active=false;
        woodswing.active=false;
        compdesk.active=false;
        
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	  if (Input.GetKey(KeyCode.Escape))
            {
                Application.LoadLevel("list");
 
                return;
            }
	}

	public void switchToTables()
	{
        menuPanel11.active=false;
        menuPanel22.active=true;
        menuPanel33.active=false;
        menuPanel44.active=false;
		menuPanel55.active=false; 
	}

	public void switchToDrawers()
	{ 
        menuPanel11.gameObject.SetActive(false);
        menuPanel22.gameObject.SetActive(false);
        menuPanel33.gameObject.SetActive(true);
		menuPanel44.gameObject.SetActive(false);
		menuPanel55.gameObject.SetActive(false);    
	}

	public void switchToChairs()
	{
		menuPanel11.gameObject.SetActive(false);
        menuPanel22.gameObject.SetActive(false);
        menuPanel33.gameObject.SetActive(false);
        menuPanel44.gameObject.SetActive(true);
		menuPanel55.gameObject.SetActive(false);       
	}

	public void switchToMisc()
	{
        menuPanel11.gameObject.SetActive(false);
        menuPanel22.gameObject.SetActive(false);
        menuPanel33.gameObject.SetActive(false);
        menuPanel44.gameObject.SetActive(false);
		menuPanel55.gameObject.SetActive(true);
	}
	

    public void switchToModels(int menuID) 
		{
			switch (menuID)
				{
					case 0:
					Debug.Log (menuID);
					menuPanel11.gameObject.SetActive(false);
					menuPanel22.gameObject.SetActive(false);
					menuPanel33.gameObject.SetActive(false);
					menuPanel44.gameObject.SetActive(false);
					menuPanel55.gameObject.SetActive(false);
					officetable.gameObject.SetActive(true);
					glasstable.gameObject.SetActive(false);
					showtable.gameObject.SetActive(false);
					minitable.gameObject.SetActive(false);
					wooddrawer.gameObject.SetActive(false);
					bookdrawer.gameObject.SetActive(false);
					rockingchair.gameObject.SetActive(false);
					woodenchair.gameObject.SetActive(false);
					sofachair.gameObject.SetActive(false);
					woodswing.gameObject.SetActive(false);
					compdesk.gameObject.SetActive(false);
					break;
					
					case 1:
					Debug.Log (menuID);
					menuPanel11.gameObject.SetActive(false);
					menuPanel22.gameObject.SetActive(false);
					menuPanel33.gameObject.SetActive(false);
					menuPanel44.gameObject.SetActive(false);
					menuPanel55.gameObject.SetActive(false);
					officetable.gameObject.SetActive(false);
					glasstable.gameObject.SetActive(true);
					showtable.gameObject.SetActive(false);
					minitable.gameObject.SetActive(false);
					wooddrawer.gameObject.SetActive(false);
					bookdrawer.gameObject.SetActive(false);
					rockingchair.gameObject.SetActive(false);
					woodenchair.gameObject.SetActive(false);
					sofachair.gameObject.SetActive(false);
					woodswing.gameObject.SetActive(false);
					compdesk.gameObject.SetActive(false);
					break;
            
					case 2:
					Debug.Log (menuID);
					menuPanel11.gameObject.SetActive(false);
					menuPanel22.gameObject.SetActive(false);
					menuPanel33.gameObject.SetActive(false);
					menuPanel44.gameObject.SetActive(false);
					menuPanel55.gameObject.SetActive(false);
					officetable.gameObject.SetActive(false);
					glasstable.gameObject.SetActive(false);
					showtable.gameObject.SetActive(true);
					minitable.gameObject.SetActive(false);
					wooddrawer.gameObject.SetActive(false);
					bookdrawer.gameObject.SetActive(false);
					rockingchair.gameObject.SetActive(false);
					woodenchair.gameObject.SetActive(false);
					sofachair.gameObject.SetActive(false);
					woodswing.gameObject.SetActive(false);
					compdesk.gameObject.SetActive(false);
					break;
					
					case 3:
					Debug.Log (menuID);
					menuPanel11.gameObject.SetActive(false);
					menuPanel22.gameObject.SetActive(false);
					menuPanel33.gameObject.SetActive(false);
					menuPanel44.gameObject.SetActive(false);
					menuPanel55.gameObject.SetActive(false);
					officetable.gameObject.SetActive(false);
					glasstable.gameObject.SetActive(false);
					showtable.gameObject.SetActive(false);
					minitable.gameObject.SetActive(true);
					wooddrawer.gameObject.SetActive(false);
					bookdrawer.gameObject.SetActive(false);
					rockingchair.gameObject.SetActive(false);
					woodenchair.gameObject.SetActive(false);
					sofachair.gameObject.SetActive(false);
					woodswing.gameObject.SetActive(false);
					compdesk.gameObject.SetActive(false);
					break;
					
					case 4:
					Debug.Log (menuID);
					menuPanel11.gameObject.SetActive(false);
					menuPanel22.gameObject.SetActive(false);
					menuPanel33.gameObject.SetActive(false);
					menuPanel44.gameObject.SetActive(false);
					menuPanel55.gameObject.SetActive(false);
					officetable.gameObject.SetActive(false);
					glasstable.gameObject.SetActive(false);
					showtable.gameObject.SetActive(false);
					minitable.gameObject.SetActive(false);
					wooddrawer.gameObject.SetActive(true);
					bookdrawer.gameObject.SetActive(false);
					rockingchair.gameObject.SetActive(false);
					woodenchair.gameObject.SetActive(false);
					sofachair.gameObject.SetActive(false);
					woodswing.gameObject.SetActive(false);
					compdesk.gameObject.SetActive(false);
					break;

					case 5:
					Debug.Log (menuID);
					menuPanel11.gameObject.SetActive(false);
					menuPanel22.gameObject.SetActive(false);
					menuPanel33.gameObject.SetActive(false);
					menuPanel44.gameObject.SetActive(false);
					menuPanel55.gameObject.SetActive(false);
					officetable.gameObject.SetActive(false);
					glasstable.gameObject.SetActive(false);
					showtable.gameObject.SetActive(false);
					minitable.gameObject.SetActive(false);
					wooddrawer.gameObject.SetActive(false);
					bookdrawer.gameObject.SetActive(true);
					rockingchair.gameObject.SetActive(false);
					woodenchair.gameObject.SetActive(false);
					sofachair.gameObject.SetActive(false);
					woodswing.gameObject.SetActive(false);
					compdesk.gameObject.SetActive(false);
					break;
					
					case 6:
					Debug.Log (menuID);
					menuPanel11.gameObject.SetActive(false);
					menuPanel22.gameObject.SetActive(false);
					menuPanel33.gameObject.SetActive(false);
					menuPanel44.gameObject.SetActive(false);
					menuPanel55.gameObject.SetActive(false);
					officetable.gameObject.SetActive(false);
					glasstable.gameObject.SetActive(false);
					showtable.gameObject.SetActive(false);
					minitable.gameObject.SetActive(false);
					wooddrawer.gameObject.SetActive(false);
					bookdrawer.gameObject.SetActive(false);
					rockingchair.gameObject.SetActive(true);
					woodenchair.gameObject.SetActive(false);
					sofachair.gameObject.SetActive(false);
					woodswing.gameObject.SetActive(false);
					compdesk.gameObject.SetActive(false);
					break;

					case 7:
					Debug.Log (menuID);
					menuPanel11.gameObject.SetActive(false);
					menuPanel22.gameObject.SetActive(false);
					menuPanel33.gameObject.SetActive(false);
					menuPanel44.gameObject.SetActive(false);
					menuPanel55.gameObject.SetActive(false);
					officetable.gameObject.SetActive(false);
					glasstable.gameObject.SetActive(false);
					showtable.gameObject.SetActive(false);
					minitable.gameObject.SetActive(false);
					wooddrawer.gameObject.SetActive(false);
					bookdrawer.gameObject.SetActive(false);
					rockingchair.gameObject.SetActive(false);
					woodenchair.gameObject.SetActive(true);
					sofachair.gameObject.SetActive(false);
					woodswing.gameObject.SetActive(false);
					compdesk.gameObject.SetActive(false);
					break;

					case 8:
					Debug.Log (menuID);
					menuPanel11.gameObject.SetActive(false);
					menuPanel22.gameObject.SetActive(false);
					menuPanel33.gameObject.SetActive(false);
					menuPanel44.gameObject.SetActive(false);
					menuPanel55.gameObject.SetActive(false);
					officetable.gameObject.SetActive(false);
					glasstable.gameObject.SetActive(false);
					showtable.gameObject.SetActive(false);
					minitable.gameObject.SetActive(false);
					wooddrawer.gameObject.SetActive(false);
					bookdrawer.gameObject.SetActive(false);
					rockingchair.gameObject.SetActive(false);
					woodenchair.gameObject.SetActive(false);
					sofachair.gameObject.SetActive(true);
					woodswing.gameObject.SetActive(false);
					compdesk.gameObject.SetActive(false);
					break;
					
					case 9:
					Debug.Log (menuID);
					menuPanel11.gameObject.SetActive(false);
					menuPanel22.gameObject.SetActive(false);
					menuPanel33.gameObject.SetActive(false);
					menuPanel44.gameObject.SetActive(false);
					menuPanel55.gameObject.SetActive(false);
					officetable.gameObject.SetActive(false);
					glasstable.gameObject.SetActive(false);
					showtable.gameObject.SetActive(false);
					minitable.gameObject.SetActive(false);
					wooddrawer.gameObject.SetActive(false);
					bookdrawer.gameObject.SetActive(false);
					rockingchair.gameObject.SetActive(false);
					woodenchair.gameObject.SetActive(false);
					sofachair.gameObject.SetActive(false);
					woodswing.gameObject.SetActive(true);
					compdesk.gameObject.SetActive(false);
					break;
					
					case 10:
					Debug.Log (menuID);
					menuPanel11.gameObject.SetActive(false);
					menuPanel22.gameObject.SetActive(false);
					menuPanel33.gameObject.SetActive(false);
					menuPanel44.gameObject.SetActive(false);
					menuPanel55.gameObject.SetActive(false);
					officetable.gameObject.SetActive(false);
					glasstable.gameObject.SetActive(false);
					showtable.gameObject.SetActive(false);
					minitable.gameObject.SetActive(false);
					wooddrawer.gameObject.SetActive(false);
					bookdrawer.gameObject.SetActive(false);
					rockingchair.gameObject.SetActive(false);
					woodenchair.gameObject.SetActive(false);
					sofachair.gameObject.SetActive(false);
					woodswing.gameObject.SetActive(false);
					compdesk.gameObject.SetActive(true);
					break;
				}
		}
}
