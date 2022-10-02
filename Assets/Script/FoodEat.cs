 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FoodEat : MonoBehaviour
{
	private int Score = 25;
  	public float SizeIncrease1;
	public float SizeIncrease2;
	public Text Letters;
    public AudioSource EatSound;
    public AudioSource DamageSound;

    void OnTriggerEnter(Collider other)
	{
        
        switch (other.gameObject.tag)
        {
            case "Asteroid":
                transform.localScale += new Vector3(SizeIncrease1, SizeIncrease1, SizeIncrease1);
                Score += 1;
                Destroy(other.gameObject);
                EatSound.Play();
                break;

            case "Moon":
                if (transform.localScale.x > 2)
                {
                    transform.localScale += new Vector3(SizeIncrease2, SizeIncrease2, SizeIncrease2);
                    Destroy(other.gameObject);
                    Score += 5;
                    EatSound.Play();
                }
                else
                {
                    transform.localScale -= new Vector3(SizeIncrease2, SizeIncrease2, SizeIncrease2);
                    Score -= 5;
                    DamageSound.Play();
                }
                break;
            case "Earth":
                if (transform.localScale.x > 4)
                {
                    Destroy(other.gameObject);
                    Score += 20;
                    SceneManager.LoadScene("Won");

                }
                else
                {
                    transform.localScale -= new Vector3(SizeIncrease2, SizeIncrease2, SizeIncrease2);
                    Score -= 5;
                    DamageSound.Play();
                }
                break;
        }
    } 

    void Update()
    {
		Letters.text = "Score: " + Score;
        if (Score < 1)
        {
            SceneManager.LoadScene("Lost");
        }
    }
}
