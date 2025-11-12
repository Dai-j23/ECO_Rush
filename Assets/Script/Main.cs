using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;
    public AudioClip sound5;
    public AudioClip sound6;
    AudioSource audioSource;

    public int o =0;

    public Text timeTexts;
    public Text CountText;
    public Text scoreText;

    public float totalTime = 30;

    public int retime;

    public static float score = 0;
    public int conbo = 0;
    public static int maxconbo = 0;
    public static int all=0;
    public int maru=0;
    public static float seikai=0;

    public float countdown = 3f;

    public int count;

    public int obup = 0;
    public int St = 0;

    public int gomiBt = 0;

    public int[] gomi = new int[] {1, 2, 3, 4, 5};

    public GameObject moeruPrefab;
    public GameObject moenaiPrefab;
    public GameObject binPrefab;
    public GameObject canPrefab;
    public GameObject petPrefab;

    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject E;

    public Button Backbt;
    public Button Retrenbt;
    public Button gomibt1;
    public Button gomibt2;
    public Button gomibt3;
    public Button gomibt4;
    public Button gomibt5;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        score=0;
        conbo=0;
        maxconbo=0;
        all=0;
        maru=0;
        seikai=0;
        St=0;
        o=0;
        scoreText.text = "score:" + score;

        audioSource.PlayOneShot(sound4);
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown >= 1)
        {
            countdown -= Time.deltaTime;
            count = (int)countdown;
            CountText.text = count.ToString();
            if(countdown < 2){
                if(o==0){
                    audioSource.PlayOneShot(sound5);
                    o=1;
                }
            }
        }

        if (countdown<=1)
        {
            if(St == 0){
            obup = 1;
            St = 1;
            audioSource.PlayOneShot(sound3);
            audioSource.PlayOneShot(sound6);
            Backbt.interactable = true;
            Retrenbt.interactable = true;
            gomibt1.interactable = true;
            gomibt2.interactable = true;
            gomibt3.interactable = true;
            gomibt4.interactable = true;
            gomibt5.interactable = true;
            }

            CountText.text = "";
            totalTime -= Time.deltaTime;
            retime = (int)totalTime;
            timeTexts.text = retime.ToString();

            if(retime == 0)
            {
                SceneManager.LoadScene("result");
            }
        }

        if(obup == 1){

            int index = Random.Range(0, gomi.Length);
            int pips = gomi[index];

            if(pips == 1){
                A=Instantiate(moeruPrefab, new Vector3(0, 0, 0), Quaternion.identity);
                gomiBt = 1;
            }

            if(pips == 2){
                B=Instantiate(moenaiPrefab, new Vector3(0, 0, 0), Quaternion.identity);
                gomiBt = 2;
            }

            if(pips == 3){
                C=Instantiate(binPrefab, new Vector3(0, 0, 0), Quaternion.identity);
                gomiBt = 3;
            }

            if(pips == 4){
                D=Instantiate(canPrefab, new Vector3(0, 0, 0), Quaternion.identity);
                gomiBt = 4;
            }

            if(pips == 5){
                E=Instantiate(petPrefab, new Vector3(0, 0, 0), Quaternion.identity);
                gomiBt = 5;
            }

            obup = 0;
        }

        if(obup == 2){
            if(gomiBt==1){
                Destroy(A);
            }
            if(gomiBt==2){
                Destroy(B);
            }
            if(gomiBt==3){
                Destroy(C);
            }
            if(gomiBt==4){
                Destroy(D);
            }
            if(gomiBt==5){
                Destroy(E);
            }
            all = all + 1;
            seikai=maru*100/all;
            obup=1;
        }
            
    }

    public static float getscore()
    {
        return score;
    }

    public static int getmaxconbo()
    {
        return maxconbo;
    }

    public static float getseikai()
    {
        return seikai;
    }

    public static int getall()
    {
        return all;
    }

    public void OnClickmoeruButton()
    {
		if(gomiBt==1){
            audioSource.PlayOneShot(sound1);
            score =score + 100;
            scoreText.text = "score:" + score;
            conbo = conbo+1;
            if(maxconbo<conbo){
                maxconbo=conbo;
            }
            maru=maru+1;
        }

        else{
            audioSource.PlayOneShot(sound2);
            score =score - 50;
            scoreText.text = "score:" + score;
            conbo = 0;
        }
        obup = 2;
    }

    public void OnClickmoenaiButton()
    {
		if(gomiBt==2){
            audioSource.PlayOneShot(sound1);
            score =score + 100;
            scoreText.text = "score:" + score;
            conbo = conbo+1;
            if(maxconbo<conbo){
                maxconbo=conbo;
            }
            maru=maru+1;
        }

        else{
            audioSource.PlayOneShot(sound2);
            score =score - 50;
            scoreText.text = "score:" + score;
            conbo = 0;
        }
        obup = 2;
    }

    public void OnClickbinButton()
    {
		if(gomiBt==3){
            audioSource.PlayOneShot(sound1);
            score =score + 100;
            scoreText.text = "score:" + score;
            conbo = conbo+1;
            if(maxconbo<conbo){
                maxconbo=conbo;
            }
            maru=maru+1;
        }

        else{
            audioSource.PlayOneShot(sound2);
            score =score - 50;
            scoreText.text = "score:" + score;
            conbo = 0;
        }
        obup = 2;
    }

    public void OnClickcanButton()
    {
		if(gomiBt==4){
            audioSource.PlayOneShot(sound1);
            score =score + 100;
            scoreText.text = "score:" + score;
            conbo = conbo+1;
            if(maxconbo<conbo){
                maxconbo=conbo;
            }
            maru=maru+1;
        }

        else{
            audioSource.PlayOneShot(sound2);
            score =score - 50;
            scoreText.text = "score:" + score;
            conbo = 0;
        }
        obup = 2;
    }

    public void OnClickpetButton()
    {
		if(gomiBt==5){
            audioSource.PlayOneShot(sound1);
            score =score + 100;
            scoreText.text = "score:" + score;
            conbo = conbo+1;
            if(maxconbo<conbo){
                maxconbo=conbo;
            }
            maru=maru+1;
        }

        else{
            audioSource.PlayOneShot(sound2);
            score =score - 50;
            scoreText.text = "score:" + score;
            conbo = 0;
        }
        obup = 2;
    }  

    public void OnClickTitleButton(){
        SceneManager.LoadScene("Title");
    }

    public void OnClickRetrenButton(){
        SceneManager.LoadScene("Main");
    }
}