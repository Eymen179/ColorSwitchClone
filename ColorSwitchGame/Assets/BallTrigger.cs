using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallTrigger : MonoBehaviour
{
    public Color colorBlue, colorYellow, colorPink, colorPurple;
    public SpriteRenderer spriteRenderer;
    public string currentColor;
    public Transform colorChanger, control1, control2, colorCircle1, colorCircle2;
    public TextMeshProUGUI scoreText;
    public GameObject deathPanel;
    public AudioSource soundGetColorChanger;
    private int score = 0;
    void Start()
    {
        RandomColor();
    }
    private void Update()
    {
        scoreText.text = "Score : " + score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag != currentColor && collision.tag != "ColorChanger" && collision.tag != "Control1" && collision.tag != "Control2")
        {
            Time.timeScale = 0.0f;
            deathPanel.SetActive(true);
        }
        if (collision.tag == "ColorChanger")
        {
            colorChanger.position = new Vector3(colorChanger.position.x, colorChanger.position.y + 7f, colorChanger.position.z);
            RandomColor();
            score++;
            soundGetColorChanger.Play();
        }
        if(collision.tag == "Control1")
        {
            control1.position = new Vector3(control1.position.x, control1.position.y + 14f, control1.position.z);
            colorCircle1.position = new Vector3(colorCircle1.position.x, colorCircle1.position.y + 14f, colorCircle1.position.z);
        }
        if (collision.tag == "Control2")
        {
            control2.position = new Vector3(control2.position.x, control2.position.y + 14f, control2.position.z);
            colorCircle2.position = new Vector3(colorCircle2.position.x, colorCircle2.position.y + 14f, colorCircle2.position.z);
        }
    }
    void RandomColor()
    {
        int random = Random.Range(1,5);

        switch(random)
        {
            case 1:
                currentColor = "PartBlue";
                spriteRenderer.color = colorBlue;
                break;

            case 2:
                currentColor = "PartYellow";
                spriteRenderer.color = colorYellow;
                break;
            case 3:
                currentColor = "PartPink";
                spriteRenderer.color = colorPink;
                break;
            case 4:
                currentColor = "PartPurple";
                spriteRenderer.color = colorPurple;
                break;
        }
    }
}
