///*********************************************
// Game Controler for buttons in AR for Vuforia
//  Author Hector Bello, date 14/06/2020
// **********************************************///

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
	public Animator animator;
	public Transform my3DModel;
	public Transform MyPauseButton;

	// Start is called before the first frame update
	void Start()
    {
		animator = my3DModel.GetComponent<Animator>();
	}

	// Update is called once per frame
 
	public void playAnim()
    {
		animator.Play("GirlshorT",-1,0f); // en parentesis el nombre de la animacion
	}

	public void pauseAnim()
    {
		animator.speed=0;
		MyPauseButton.GetComponentInChildren<Text> ().text="RESUME";
		Button btn=MyPauseButton.GetComponent<Button> ();
		btn.onClick.AddListener(resumeAnim);
	}
	void resumeAnim)=
    {
		MyPauseButton.GetComponentInChildren<Text> ().text="PAUSE";
		animator.speed=1;
		Button btn=MyPauseButton.GetComponent<Button> ();
		btn.onClick.AddListener(pauseAnim);
	}

}
