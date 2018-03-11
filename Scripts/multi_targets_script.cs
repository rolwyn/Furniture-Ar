using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class multi_targets_script : MonoBehaviour {

	public GameObject model1,model2,model3,model4,model5,model6,model7,model8,model9,model10,model11;
	public Toggle toggle_1;
	public GameObject[] all_toggles,touch_input_list;
	public GameObject[] textures_1,textures_2,textures_3,textures_4;
	public Texture2D texture_1a,texture_1b,texture_2a,texture_2b,texture_3a,texture_3b,texture_3c,texture_4a,texture_4b,texture_4c;
	public GameObject options_panel,body_panel,item_error;
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

		disable_textures();

		initialize_textures();
		
		item_error=GameObject.Find("item_error");
		item_error.active=false;
		body_panel=GameObject.FindGameObjectWithTag("body_panel");
		options_panel=GameObject.Find("options_panel");
		options_panel.active=false;

		foreach (GameObject item in touch_input_list)
		{
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

	public void initialize_textures()
	{
		texture_1a = (Texture2D) Resources.Load ("texture_1a");
		texture_1b = (Texture2D) Resources.Load ("texture_1b");
		texture_2a = (Texture2D) Resources.Load ("texture_2a");
		texture_2b = (Texture2D) Resources.Load ("texture_2b");
		texture_3a = (Texture2D) Resources.Load ("texture_3a");
		texture_3b = (Texture2D) Resources.Load ("texture_3b");
		texture_3c = (Texture2D) Resources.Load ("texture_3c");
		texture_4a = (Texture2D) Resources.Load ("texture_4a");
		texture_4b = (Texture2D) Resources.Load ("texture_4b");
		texture_4c = (Texture2D) Resources.Load ("texture_4c");
	}
	
	public void disable_textures()
	{
		foreach (GameObject item in textures_1)
			{
				item.active=false;
			}
		foreach (GameObject item in textures_2)
			{
				item.active=false;
			}
		foreach (GameObject item in textures_3)
			{
				item.active=false;
			}
		foreach (GameObject item in textures_4)
			{
				item.active=false;
			}	
	}

	public void on_options_click()
	{		
		options_panel.active=true;	
	}

	public void texture_select(string num)
	{
		GameObject[] boxes_1,boxes_2;
		boxes_1=GameObject.FindGameObjectsWithTag("box_1");
		boxes_2=GameObject.FindGameObjectsWithTag("box_2");
		GameObject upper_cover,lower_cover;
		upper_cover=GameObject.Find("Shape007");
		lower_cover=GameObject.Find("Shape008");
		GameObject four_cover;
		four_cover=GameObject.Find("Cube_010");
		switch (num)
		{
			case "1a" : 
			
			foreach (GameObject item in boxes_1)
			{
				item.GetComponent<Renderer>().material.mainTexture = texture_1a;
			}
			break;
			
			case "1b" : 
			foreach (GameObject item in boxes_1)
			{
				item.GetComponent<Renderer>().material.mainTexture = texture_1b;
			}	
			break;

			case "2a" : 
			foreach (GameObject item in boxes_2)
			{
				item.GetComponent<Renderer>().material.mainTexture = texture_2a;
			}
			break;
			
			case "2b" : 
			foreach (GameObject item in boxes_2)
			{
				item.GetComponent<Renderer>().material.mainTexture = texture_2b;
			}
			break;
			
			case "3a" : 
			upper_cover.GetComponent<Renderer>().material.mainTexture = texture_3a;
			lower_cover.GetComponent<Renderer>().material.mainTexture = texture_3a;
			break;

			case "3b" : 
			upper_cover.GetComponent<Renderer>().material.mainTexture = texture_3b;
			lower_cover.GetComponent<Renderer>().material.mainTexture = texture_3b;
			break;

			case "3c" : 
			upper_cover.GetComponent<Renderer>().material.mainTexture = texture_3c;
			lower_cover.GetComponent<Renderer>().material.mainTexture = texture_3c;
			break;

			case "4a" : 
			four_cover.GetComponent<Renderer>().material.mainTexture = texture_4a;
			break;

			case "4b" : 
			four_cover.GetComponent<Renderer>().material.mainTexture = texture_4b;
			break;

			case "4c" : 
			four_cover.GetComponent<Renderer>().material.mainTexture = texture_4c;
			break;
	
		default : break;
		}
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
			{	
				tick_array[current_item_count]=0;
			}
			current_item_count++;
			//item.transform.GetChild(0).gameObject.active=false;
		}
		
		if(on_count>3)
		{
			item_error.active=true;
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
			options_panel.active=false;
		}
	}

	 IEnumerator LateCall()
     {
		 float sec = 3f;
         yield return new WaitForSeconds(sec);
		 item_error.active=false;
     }

	 public void Deselect_all()
	 {
		 var ls=new Lean.Touch.LeanSelectable();
		 GameObject[] list=GameObject.FindGameObjectsWithTag("models");
		 foreach(GameObject model in list)
		 model.GetComponent<Lean.Touch.LeanSelectable>().Deselect();
	 }
	
	 public void enable_texture(int num)
	 {
		 disable_textures();
		 if(num==0)
		 {
		 	foreach (GameObject item in textures_1)
			{
				item.active=true;
			}
		 }
		 if(num==1)
		 {
			foreach (GameObject item in textures_2)
			{
				item.active=true;
			}
		 }
		 if(num==2)
		 {
			foreach (GameObject item in textures_3)
			{
				item.active=true;
			}
		 }
		 if(num==3)
		 {
			foreach (GameObject item in textures_4)
			{
				item.active=true;
			}
		 }
	   }

	public void item_1()
	{
		disable_textures();
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
	public void item_2()
	{
		disable_textures();
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
	public void item_3()
	{
		disable_textures();
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
	public void item_4()
	{
		disable_textures();
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
	public void item_5()
	{
		disable_textures();
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
	public void item_6()
	{
		disable_textures();
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
	public void item_7()
	{
		disable_textures();
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
	public void item_8()
	{
		disable_textures();
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
	public void item_9()
	{
		disable_textures();
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
	public void item_10()
	{
		disable_textures();
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
	public void item_11()
	{
		disable_textures();
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
