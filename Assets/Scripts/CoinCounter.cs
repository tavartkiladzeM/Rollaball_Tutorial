using UnityEngine;
using UnityEngine.UI;


public class CoinCounter : MonoBehaviour


{
    public int score = 0;
    public Text scoreText; //უნითიში ჩაშენებული ობიექტია
    public string coinTagString;
    public string badCoinTagString;

    public Text resultText;
    public string winString;
    public string loseString;

    public GameObject menu;
    public PlayerMover myMover;
    public Rigidbody myBody;

    int TargetScore;

    //შემიძლია თაგების ნაცვლად გამოვიყენო ახალი ცვლადები:
    // public string coinTagString; 
    //public string badCoinTagString;

void Start ()
    {

       GameObject [] myObjects = GameObject.FindGameObjectsWithTag(coinTagString); 
        TargetScore= myObjects.Length;

        //მეორენაირად: TargetScore = GameObject.FindGameObjectsWithTag(coinTagString).Length;
        // ფუნქციის გამოძაახება შეიძლება ან ობიექტიდან ან კლასიდან. ის ფუნქციები რომლებიც გამოიძახებიან კლასიდან არიან სტატიკურები.
        menu.SetActive(false);

    }

    void OnCollisionEnter(Collision collision) // ფუნქცია, რომელიც გამოიძახება შეჯახების შემდეგ.


    {
        Debug.Log("Collision" + collision.gameObject.name);
    }   
    
	
    void OnTriggerEnter (Collider other) // other არის სხვა ობიექტი რომელსაც ვეჯახები Ctrl +k Ctrl+c (comment)

    {

        if (other.tag == coinTagString)

        {

            score = score + 1;

        }


        else if (other.tag == badCoinTagString)
        {
            GameOver(false);

            //score = score - 1;

            ////if (score >0)
            //{

            //    score = score - 1;
            //}

        }


        Debug.Log("Triggered " + score + " " + other.gameObject.name);

        scoreText.text = "Score: " + score;
        Destroy(other.gameObject); //ობიექტის განადგურება


        if (TargetScore==score)

        {
            GameOver(true);           
                
                

        }
    }


    void GameOver(bool didWin)

    {
        menu.SetActive(true); //მაშინ გამოიტანოს მენიუ
        myMover.enabled = false;
        myBody.isKinematic = true;

        if (didWin)
        {

            resultText.text = winString;

        }

        else
        {

            resultText.text = loseString;
        }
    }
}
