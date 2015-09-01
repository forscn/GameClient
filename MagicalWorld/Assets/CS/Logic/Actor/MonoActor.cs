using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 游戏角色行为
/// </summary>
public class MonoActor : MonoBehaviour
{
    public Slider HP;
    public Transform launcher;
    public Text actorName;
    // 初始化调用
    public virtual void Awake()
    {
        
    }
    void Update()
    {

    }

    public virtual void DestroySelf()
    {
        GameObject.Destroy(gameObject);
    }
}

