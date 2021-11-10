using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;

    private Text text;

    private void Start(){
        text = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        text.text = player.position.z.ToString("0");
    }
}
