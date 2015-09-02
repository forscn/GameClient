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
    public ActorData actorData;
    /// <summary>
    /// 出生点
    /// </summary>
    public Vector3 BP = new Vector3(-485f, -507f, 0f);
    // 初始化调用
    public virtual void Awake()
    {
        
    }
    public void Start()
    {
        //开场进入战场
        MoveTo(new Vector3(0, 0, 0), 1f);
    }
    void Update()
    {

    }
    /// <summary>
    /// 刷新数据
    /// </summary>
    public virtual void RefData()
    {
        HP.value = (float)actorData.HP / (float)actorData.maxHP;
        actorName.text = actorData.name;
    }
    public virtual void DestroySelf()
    {
        GameObject.Destroy(gameObject);
    }
    public virtual void MoveTo(Vector3 target,float duration)
    {
        TweenPosition.Begin(gameObject, duration, target);
    }
}

