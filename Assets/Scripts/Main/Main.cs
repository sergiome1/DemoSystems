using UnityEngine;

public class Main : MonoBehaviour
{
    private const string urlTrailer = "https://www.youtube.com/watch?v=YJ85K-zxAcE";

    public void OpenTrailer()
    {
        Application.OpenURL(urlTrailer);
    }
}
