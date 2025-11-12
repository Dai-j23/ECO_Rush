using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class result : MonoBehaviour
{
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;
    AudioSource audioSource;

    public Text scoreText;
    float score;
    public Text maxconboText;
    int maxconbo;
    float seikai;
    public Text seikaiText;
    int all;
    public Text allText;
    int D=0;

    public Text highScoreText;
    private float highScore;
    private string key = "HIGH SCORE";


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        score = Main.getscore();
        maxconbo = Main.getmaxconbo();
        seikai = Main.getseikai();
        all = Main.getall();
        maxconboText.text = "最大" + maxconbo + "コンボ";
        seikaiText.text = "正答率"+seikai+"%";
        allText.text = "問題数 "+all + "問";
        if(maxconbo>9){
            score=score * maxconbo / 10 + seikai * 3 + all * seikai;
        }

        scoreText.text = "score:" + score;
        if(D==0){
            if(score>=5000){
                if(score>=8000){
                    if(score>=10000){
                        audioSource.PlayOneShot(sound1);
                    }
                    else{
                        audioSource.PlayOneShot(sound2);
                    }
                }
                else{
                    audioSource.PlayOneShot(sound3);
                }
            }
            else
            {
                audioSource.PlayOneShot(sound4);
            }
            D=1;
        }

        highScore = PlayerPrefs.GetFloat(key, 0);
        //保存しておいたハイスコアをキーで呼び出し取得し保存されていなければ0になる
        highScoreText.text = "HighScore: " + highScore.ToString();
        //ハイスコアを表示
        if (score > highScore) {
            highScore = score;//ハイスコア更新
            PlayerPrefs.SetFloat(key, highScore);//ハイスコアを保存
            highScoreText.text = "HighScore: " + highScore.ToString();//ハイスコアを表示
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnClickTitleButton(){
        SceneManager.LoadScene("Title");
    }
}
