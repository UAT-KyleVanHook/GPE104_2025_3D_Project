using UnityEngine;

public class LevelData : MonoBehaviour
{
    [Header("Game Bounds")]
    public int XBounds;
    public int YBounds;
    public int ZBounds;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        GameManager.instance.maxX = XBounds;
        GameManager.instance.maxY = YBounds;
        GameManager.instance.maxZ = ZBounds;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
