
using UnityEngine;
using UnityEngine.UI;
public class cash_update_button : MonoBehaviour
{
    //planning
    //based on the amount in the input field the cash will update
    //after the button is pressed it will set input field to zero and minus cash
    //i will now add a fnction where it will spawn balls

    public TMPro.TMP_InputField input_field;
    public Cash_manager cash_script;
    public TMPro.TMP_Text Button_Text;
    public Button button;

    public Ball_spawn ball_script;

    public float bet_amount = 0;

    void Start()
    {
        button.onClick.AddListener(Cash_clicked);
        
    }
    // Update is called once per frame
    void Update()
    {
        if(input_field.text !=null)
        {
           Button_Text.text = input_field.text;
        }
        else
        {
            input_field.text = "Enter Amount for ball:";
            Button_Text.text = "~~~~";           
        }
    }
    void Cash_clicked()
    {
        if(input_field.text != null && input_field.text != "0")
        {
            if(cash_script.cash >= float.Parse(Button_Text.text))
            {
                 ball_script.start_ball = true;
                 cash_script.cash -= float.Parse(Button_Text.text);
                 bet_amount = float.Parse(Button_Text.text);
                 
            }
            else
            {
              Debug.Log("bum");
            }
       
      
        }
    }
}
