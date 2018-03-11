using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class multi_targets_script1 : MonoBehaviour {


	public GameObject model1,model2,model3,model4,model5,model6,model7,model8,model9,model10,model11;
	public Toggle toggle_1;
	public GameObject[] all_toggles,touch_input_list;
	
	
	public GameObject options,bodypanel,item_error;
	// Use this for initialization
	void Start () {

		model1.active=false;
		model2.active=false;
		model3.active=false;
		model4.active=false;
		model5.active=false;
		model6.active=false;
		model7.active=false;
		model8.active=false;
		model9.active=false;
		model10.active=false;
		model11.active=false;


//		item_error=GameObject.Find("item_error");
//		item_error.active=false;
		options.active=false;
                

		foreach (GameObject item in touch_input_list)
		{
			Debug.Log("input received");
			item.active=false;
		}

			
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Escape))
            {
				Application.LoadLevel("markerlist");
                return;
            }
	
	}


	public void on_options_click()
	{
		
		options.active=true;
		
	}

	public void ok_click()
	{

		int on_count=0,current_item_count=0;
		string current_item_str;
		int[] tick_array=new int[12];
		all_toggles=GameObject.FindGameObjectsWithTag("toggle");
		Deselect_all();
		foreach (GameObject item in all_toggles)
		{

			Toggle temp=item.GetComponent<UnityEngine.UI.Toggle>();
			if(temp.isOn)
			{
				on_count++;
				tick_array[current_item_count]=1;
				
			}
			else
			{	tick_array[current_item_count]=0;
				
			}
			current_item_count++;
			//item.transform.GetChild(0).gameObject.active=false;
		}
		
		if(on_count>12)
		{
//			item_error.active=true;
			StartCoroutine(LateCall());
			
		}
		else
		{
			int check=0;
			
			GameObject select_mark;
			foreach (GameObject item in touch_input_list)
			{
				if(tick_array[check]==1)
				{
				item.active=true;
				select_mark=item.transform.GetChild(0).gameObject;
				select_mark.active=false;
				}
				else{
					item.active=false;
				}
				
				check++;
			}
//			touch_image_enabler(tick_array);
			options.active=false;
		}
	}
	 IEnumerator LateCall()
     {
		 float sec = 3f;
         yield return new WaitForSeconds(sec);
 // 		 item_error.active=false;
     }

	 public void Deselect_all()
	 {
		 var ls=new Lean.Touch.LeanSelectable();
		 GameObject[] list=GameObject.FindGameObjectsWithTag("models");
		 foreach(GameObject model in list)
		 model.GetComponent<Lean.Touch.LeanSelectable>().Deselect();
	 }


	 public void select_model(string name)
	 {
		GameObject current_model;
		current_model=GameObject.Find(name);
		Debug.Log(name);
		model1.GetComponent<Lean.Touch.LeanSelectable>().Select();
	 }
	
	

public void item_0()
	{
		toggle_1=GameObject.Find("Toggle_1").GetComponent<UnityEngine.UI.Toggle>();
		if (toggle_1.isOn) 
		{
			model1.active=true;

		}
		else
		{
			model1.active=false;
		}

	}
	public void item_1()
	{
		toggle_1=GameObject.Find("Toggle_2").GetComponent<UnityEngine.UI.Toggle>();
		if (toggle_1.isOn)
		{
			model2.active=true;
		}
		else
		{
			model2.active=false;
		}
	}
	public void item_2()
	{
		toggle_1=GameObject.Find("Toggle_3").GetComponent<UnityEngine.UI.Toggle>();
		if (toggle_1.isOn)
		{
			model3.active=true;
		}
		else
		{
			model3.active=false;
		}
	}
	public void item_3()
	{
		toggle_1=GameObject.Find("Toggle_4").GetComponent<UnityEngine.UI.Toggle>();
		if (toggle_1.isOn)
		{
			model4.active=true;
		}
		else
		{
			model4.active=false;
		}
	}
	public void item_4()
	{
				toggle_1=GameObject.Find("Toggle_5").GetComponent<UnityEngine.UI.Toggle>();

		if (toggle_1.isOn)
		{
			model5.active=true;
		}
		else
		{
			model5.active=false;
		}
	}
	public void item_5()
	{
				toggle_1=GameObject.Find("Toggle_6").GetComponent<UnityEngine.UI.Toggle>();

		if (toggle_1.isOn)
		{
			model6.active=true;
		}
		else
		{
			model6.active=false;
		}
	}
	public void item_6()
	{
				toggle_1=GameObject.Find("Toggle_7").GetComponent<UnityEngine.UI.Toggle>();

		if (toggle_1.isOn)
		{
			model7.active=true;
		}
		else
		{
			model7.active=false;
		}
	}
	public void item_7()
	{
				toggle_1=GameObject.Find("Toggle_8").GetComponent<UnityEngine.UI.Toggle>();

		if (toggle_1.isOn)
		{
			model8.active=true;
		}
		else
		{
			model8.active=false;
		}
	}
	public void item_8()
	{
				toggle_1=GameObject.Find("Toggle_9").GetComponent<UnityEngine.UI.Toggle>();

		if (toggle_1.isOn)
		{
			model9.active=true;
		}
		else
		{
			model9.active=false;
		}
	}
	public void item_9()
	{
				toggle_1=GameObject.Find("Toggle_10").GetComponent<UnityEngine.UI.Toggle>();

		if (toggle_1.isOn)
		{
			model10.active=true;
		}
		else
		{
			model10.active=false;
		}
	}
	public void item_10()
	{
				toggle_1=GameObject.Find("Toggle_11").GetComponent<UnityEngine.UI.Toggle>();

		if (toggle_1.isOn)
		{
			model11.active=true;
		}
		else
		{
			model11.active=false;
		}
	}
	
}
