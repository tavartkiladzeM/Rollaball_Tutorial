using UnityEngine;
using UnityEngine.UI;


public class CoinCounter : MonoBehaviour


{
    public int score = 0;
    public Text scoreText; //უნითიში ჩაშენებული ობიექტია

    //შემიძლია თაგების ნაცვლად გამოვიყენო ახალი ცვლადები:
    // public string coinTagString; 
    //public string badCoinTagString;

   
 
    void OnCollisionEnter(Collision collision) // ფუნქცია, რომელიც გამოიძახება შეჯახების შემდეგ.


    {
        Debug.Log("Collision" + collision.gameObject.name);
    }   
    
	
    void OnTriggerEnter (Collider other) // other არის სხვა ობიექტი რომელსაც ვეჯახები

    {

        if (other.tag == "Coin")

        {

            score = score + 1;

        }


        else if (other.tag== "BadCoin")
        {
            if (score >0)
            {

                score = score - 1;
            }
            
        }
        

        Debug.Log("Triggered" +score + other.gameObject.name);

        scoreText.text = "Score: " + score;
        Destroy(other.gameObject); //ობიექტის განადგურება

    }


}
