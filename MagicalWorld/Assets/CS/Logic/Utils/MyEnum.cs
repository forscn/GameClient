using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace CG3D.Utils
{
	public class MyEnum
	{
		//记录类型
		public enum LOG_TYPE
		{
			//途径
			LOG_NEW_PLAYER = 1,//新建玩家
			LOG_LEVEL = 2,//关卡掉落
			LOG_BATTLE_GIFT = 3,//战役礼包
			LOG_ARENACHALLENGE,//竞技场获取
			LOG_TOWER,//爬塔获取
			LOG_ENCOUNTER_PVE,//奇遇战斗
			LOG_ENCOUNTERGIFT,//奇遇战役礼包
			LOG_TREASUREROB,//夺宝战斗
			LOG_CHALLENGE,//擂台战斗
			LOG_WORLDBOSS,//世界BOSS
			LOG_FIGHTVSFRIEND,//好友PK
			LOG_ENCOUNTER,//奇遇
			LOG_TOWER_HELP,//爬塔帮助
			LOG_SHOP,//商场
			LOG_SECRETSTORE,//随机.
			LOG_SECRETSTORE_CD,//随机刷新
			LOG_LOGINGIFT,//登录礼包
			LOG_ARENARANK,//竞技场排行
			LOG_ARENALUCK,//竞技场幸运排行
			LOG_ARENAACHIEVEREWARD,//竞技场成就
			LOG_FRIENDKAIYOU,//好友摸一下
			LOG_MINE,//挖矿
			LOG_GIFT,//系统礼包
			LOG_GIFT_CDK,//兑换码礼包
			LOG_GIFT_GROW,//成长礼包
			LOG_COMPENSATION,//补偿礼包
			LOG_DAY_GIFT,//每日礼包
			LOG_MISSIONPRIZE,//每日任务
			LOG_ACTIONSILVER,//每日购买银两
			LOG_TREASAUCACTION,//拍卖活动
			LOG_TERMPAYREWARD,//限时充值
			LOG_DAYPAYREWARD,//每天充值
			LOG_PULLULATEGIFT,//成长活动
			LOG_USEGOLDGIFT,//消费活动
			LOG_ANSWER,//答题
			LOG_CONTINUOUS,//答题连对
			LOG_CONVOY,//护送
			LOG_ACTIONPAY,//累计充值
			LOG_BUY_PULLULATE,//成长计划
			LOG_HERO_SHOP,//武将抽卡
			LOG_HERO_LV,//武将升级
			LOG_HERO_STRONG,//武将进阶
			LOG_HERO_CHIPCOMPOUND,//武将合成
			LOG_HERO_IMMORTAL,//武将封神
			LOG_HERO_CENTER_GOLD_HEAD_ACTIVATION,//激活中间神格
			LOG_HERO_GOLD_HEAD_UPDATE,//神格升级
			LOG_HERO_BAG,//武将背包
			LOG_EQUIP_LV,//装备升级
			LOG_EQUIP_BAPTIZE,//装备洗练
			LOG_EQUIP_CHIPCOMPOUND,//装备合成
			LOG_EQUIP_BAG,//装备背包
			LOG_TREASURE_LV,//法宝升级
			LOG_TREASURE_STRONG,//法宝强化
			LOG_TREASURE_CHIPCOMPOUND,//法宝合成
			LOG_TREASURE_BAG,//法宝背包
			LOG_PROP_SHIEID,//免战使用
			LOG_PROP_USE,//道具使用
			LOG_PROP_KEY,//开宝箱
			LOG_CDK_USE,//兑换码使用
			LOG_RESTORE_RETURN,	//物品还原返还
			LOG_DECOMPOSE_RETURN,	//物品分解添加
			LOG_RESTORE,	//物品还原
			LOG_DECOMPOSE,	//物品分解
			LOG_HERO_GOLD_HEAD_CHANGE,//神格装备更换
			LOG_GOD_TO_LIVESOUL_CHANGE,	//天神令兑换命魂
			LOG_GOD_PAY_MONTH_CARD,		//购买月卡赠送
			LOG_GOD_PAY_GOLD,			//购买元宝赠送
			LOG_GM_SEND_ADV_HERO,		//GM发送带属性的武将
			LOG_GM_SEND_ADV_EQUIP,		//GM发送带属性的装备
			LOG_GM_SEND_ADV_TREAS,		//GM发送带属性的法宝
			LOG_SELL,//物品卖掉
			LOG_BUY_VIPPACK,//购买VIP礼包
			LOG_GIFT_TOWER,//爬塔扫荡礼包
			LOG_GIFT_ARENA_LUCKY,//竞技场幸运礼包
			LOG_GIFT_ARENA_RANK,//竞技场排行
			LOG_GIFT_BAG_MAX,	//
			LOG_GIFT_CHALLENGE,	//擂台奖励
			LOG_GIFT_ACTION_TREAS_AUC_WIN_ITEM, //宝物拍卖获得的物品
			LOG_GIFT_ACTION_TREAS_AUC_BACK_GOLD,	//宝物拍卖失败返回的元宝
			LOG_GIFT_ACTION_WORLD_BOSS_RANK,		//世界boss排行
			LOG_GIFT_GM_SEND_PACK,	//GM发送的礼包
			LOG_GIFT_SYSTEM_GIFT_PACK,	//全服礼包
			LOG_GIFT_TOWER_RANK,		//爬塔排行 礼包
            LOG_ACTION_MOON,			//月签
            LOG_CHANGE_NAME,			//修改
            LOG_ACTION_LEVEL,//活动关卡掉落
            LOG_ACTION_GET,//活动兑换
            LOG_ARENA_MOBAI,			//竞技场膜拜
            LOG_PAY_REBATE,			//返利
            LOG_ACTION_GOOD_BOSS,			//幸运boss
            LOG_ACTION_GOD_HERO,			//限时神将
			
			LOG_ALLIANCE_CREATE,//联盟创建
            LOG_ALLIANCE_CONTRIBUTION,//联盟贡献
            LOG_ALLIANCE_SHOP_UP,//联盟商店
            LOG_ALLIANCE_SHOP_BUY,//联盟商店购买
            LOG_ALLIANCE_AUCTION_SHOP_BUY,//珍品商店购买
            LOG_ALLIANCE_CITYWAR_SHIELD,//联盟防守奖励
            LOG_ALLIANCE_CITYWAR_ATT,//联盟攻击奖励
		};

		//领取限时充值活动奖励返回
		public enum ACTION_LV_PAY_TYPE
		{
			ACTION_LV_PAY_OK = 0,//成功
			ACTION_LV_PAY_REWARD_ERROR,//奖励ID错误
			ACTION_LV_PAY_REWARD_TYPE_ERROR,//奖励类型错误
			ACTION_LV_PAY_FAILES,//领取失败
			ACTION_LV_PAY_REWARD_NONE,//没有这个奖励
			ACTION_LV_PAY_CONF_ERROR, //配置错误
			ACTION_TLV_PAY_LV_NONE,	//等级不够
		};
		public enum ACTION_BUY_PULLULATE_TYPE
		{
			ACTION_BUY_PULLULATE_OK = 0,//成功
			ACTION_BUY_PULLULATE_NO,//成长礼包已购买
			ACTION_BUY_PULLULATE_ID,//没有这个活动
			ACTION_BUY_PULLULATE_TIME_START,//时间未到
			ACTION_BUY_PULLULATE_TIME_END,//时间结束
			ACTION_BUY_PULLULATE_NULL,//配置错误
			ACTION_BUY_PULLULATE_ACTION_TYPE,//活动类型错误
			ACTION_BUY_PULLULATE_GOLD,//元宝不够
			ACTION_BUY_PULLULATE_VIP,//vip等级不够
			ACTION_BUY_PULLULATE_NO_BUY,//成长活动未购买
		}
		public enum MANAGE_TYPE
        {
            MANAGE_0 = 0,//	普通成员
            MANAGE_1,//	副盟主
            MANAGE_2,//	老大

        };
		public enum CREATE_ORDER_ERROR
		{
			SUCCESS = 0,            // 成功
			FAILD = 1,
			TOKEN_IS_NULL = 2,      // token为空
			USER_ID_IS_NULL_OR_ERROR = 3,    // userID为空
			PLATFORM_ERROR = 4,     // 平台错误
			AMOUNT_IS_NULL_OR_ERROR = 5,       // 金额错误
			TOKEN_VERY_FAILD = 6,   // token验证错误  
			SERVER_ID_IS_NULL_OR_ERROR = 7,    //rverID错误
		}
		/// <summary>
		/// socket服务器端CDKEY兑换返回
		/// </summary>
		public enum PLAYER_CDK_TYPE
		{
			PLAYER_CDK_OK = 0,//成功
			PLAYER_CDK_NO,//cdk无效
			PLAYER_CDK_USE,//cdk已使用
			PLAYER_CDK_NUM,//领取次数超了
			PLAYER_CDK_TIME_BEGIN,//cdk使用时候未到
			PLAYER_CDK_TIME_END,//cdk过期
			PLAYER_CDK_PLATFORM,//cdk限定了平台
			PLAYER_CDK_SREVER,//cdk限定了服务器
		};
		/// <summary>
		/// Web端CDKEY兑换返回
		/// </summary>
		public enum CDK_CHECK
		{
			SUCCESS = 0,            //成功
			USERNAME_IS_NULL = 1,   // 用户名为空
			PASSWORD_IS_NULL = 2,   // 密码为空
			USERNAME_IS_USED = 3,   // 用户名已经存在
			USERNAMEORPASSWORD_WRONG = 4,   // 用户名或密码错误
			MAINTANCESERVER = 5,   // 停服维护中        
			USERDATA_UNMATCH = 6,   // 加密数据验证异常（仅用于用户token登录）
			USERDATA_INVALIDATEIP = 7,   // 加密数据验证异常,ip不正确（仅用于用户token登录）
			USERDATA_TIMEOUT = 8,   // 加密数据验证异常,ip不正确（仅用于用户token登录）
			PLATFORM_UNKONWEXCEPTION = 9,   // 其他平台验证未知异常（用户token超时）
			UNKONW_EXCEPTION = 10,  // 未知异常
			USERTOKEN_IS_NULL = 11,    // token为空
			USERCDK_IS_NULL = 12,    // CDKey为空
			SERVERIP_IS_NULL = 13,    // 服务器IP为空
			SERVERPORT_IS_NULL = 14,    // 服务器端口为空
			SERVERIP_IS_ERROR = 15,    // 服务器IP错误
			SERVERPORT_IS_ERROR = 16,    // 服务器IP错误
			SERVEID_GET_ERROR = 17,    // 服务器ID获取失败
			CDK_USE_FAILED = 18,    // 使用失败
			//存储过程定义错误
			CDKEY_IS_NULL = 101,  //没有这个序列号 
			CDKEY_IS_USED = 102,  //序列号状态已使用 
			CDKEY_NOT_IN_SVR = 103,  //.序列号不能在这个服务器使用
			CDKEY_BEFORE_LIVETIME = 104, //序列号未生效	 
			CDKEY_AFTER_LIVETIME = 105,  //.序列号失效	
			CDKEY_NOT_EVENT_CFG = 106,  //.没有对应的活动物品配置 
			CDKEY_LOCKED = 107,  //.序列号被锁定 0.检测成功,设置cdk冻结,更新状态时间	
			CDKEY_PLATFORM_ERROR = 108,   //平台錯誤

			CDKEY_ITEM_COUNT_ERROR = 201,  //物品配置错误
			CDKEY_ITEM_DETAIL_ERROR = 202, //物品配置错误

			SQLEXCEPTION = 600,      //存储过程异常错误
		}

		public enum APPLE_STORE_RETURN
		{
			SUCCESS = 0,        // 成功
			FAILD,              // 处理失败
			SECEIVE_DATA_ERROR, // 收到的数据异常
			APPLE_VERY_ERROR,  // 苹果凭据状态错误
			UNKONW_EXCEPTION,  // 未知异常 代码错误
			ORDER_VERY_ERROR,   // 订单校验错误
			ORDER_SUCCESS,      // 订单已成功
		}


		public enum RESULT_S2C_KICKOUT
		{
			RESULT_S2C_KICKOUT_OTHERPLACE_LOGIN = 0, // 玩家在其他地方登陆了
			RESULT_S2C_KICKOUT_GM_OPT = 1,  // GM踢下线
			RESULT_S2C_KICKOUT_SERVER_CLOSE = 2,	//服务器关闭
		};
		public enum ACTION_MISSION_VIEW_TYPE
		{
			ACTION_MISSION_VIEW_OK = 0,//成功
			ACTION_MISSION_VIEW_LV,//等级不够
		};
		public enum ACTION_MISSION_PRIZE_TYPE
		{
			ACTION_MISSION_PRIZE_OK = 0,//成功
			ACTION_MISSION_PRIZE_NO,//任务未完成
			ACTION_MISSION_PRIZE_MTYPE,//任务类型错误
			ACTION_MISSION_PRIZE_NULL, //配置错误
			ACTION_MISSION_PRIZE_END,//任务以领取
		};
		//领取限时充值活动奖励返回
		//世界boss
		public enum ACTION_ANSWER_TYPE
		{
			ACTION_ANSWER_OK = 0,//正确
			ACTION_ANSWER_NO,//错误
			ACTION_ANSWER_ERROR, //配置错误
			ACTION_ANSWER_CLOSED, //无此活动
			ACTION_ANSWER_ANSWERID, //题和服务器不匹配
			ACTION_ANSWER_NUM,//超过问题数
		};
		//领取限时充值活动奖励返回
		//世界boss
		public enum ACTION_ANSWER_VIEW_TYPE
		{
			ACTION_ANSWER_VIEW_OK = 0,//成功
			ACTION_ANSWER_VIEW_CLOSED, //无此活动
			ACTION_ANSWER_VIEW_ERROR, //配置错误
		};
		public enum LOCALE_TYPE
		{
			ZH_CN = 0,
			EN_US,
		}
		public enum NEW_HERO_TYPE
		{
			NEW_HERO_OK = 0,//成功
			NEW_HERO_ON,//传的参数有问题
			NEW_HERO_NULL,//配置错误
			NEW_HERO_ADD,//添加武将失败
			NEW_HERO_HELP,//新手引导
		};
		public enum FIGHT_WORLD_BOSS_RET
		{
			FIGHT_WORLD_BOSS_WIN = 0,//成功
			FIGHT_WORLD_BOSS_LOST,	//失败
			FIGHT_WORLD_BOSS_NULL,//配置错误
			FIGHT_WORLD_BOSS_END,//战斗结束
			FIGHT_WORLD_BOSS_GOLD,//钱不够
			FIGHT_WORLD_BOSS_ATTACK_TIME,//攻击时间没到
		};
		//世界boss
		public enum ACTION_WORLD_BOSS_TYPE
		{
			ACTION_WORLD_BOSS_OK = 0,//成功
			ACTION_WORLD_BOSS_NO,//世界boss没开始
			ACTION_WORLD_BOSS_END,//世界boss结束
			ACTION_WORLD_BOSS_NULL,//配置错误
		};
		//充值活动
		public enum ACTION_PAY_TYPE
		{
			ACTION_PAY_OK = 0,//成功
			ACTION_PAY_NO,//钱没达到
			ACTION_PAY_END,//以领奖励
			ACTION_PAY_NULL,//配置错误
		};
		//体力活动
		public enum ACTION_POWER_TYPE
		{
			ACTION_POWER_OK = 0,//成功
			ACTION_POWER_NO,//活动也完成
			ACTION_POWER_ID,//没有这个活动
			ACTION_POWER_TIME_START,//时间未到
			ACTION_POWER_TIME_END,//时间结束
			ACTION_POWER_NULL,//配置错误
			ACTION_POWER_ACTION_TYPE,//活动类型错误
		};

		//每日充值活动
		public enum ACTION_DAY_PAY_TYPE
		{
			ACTION_DAY_PAY_OK = 0,//成功
			ACTION_DAY_PAY_NO,//活动也完成
			ACTION_DAY_PAY_ID,//没有这个活动
			ACTION_DAY_PAY_TIME_START,//时间未到
			ACTION_DAY_PAY_TIME_END,//时间结束
			ACTION_DAY_PAY_NULL,//配置错误
			ACTION_DAY_PAY_ACTION_TYPE,//活动类型错误

		};

		//领取限时充值活动奖励返回
		public enum ACTION_DAY_PAY_GET_TYPE
		{
			ACTION_DAY_PAY_GET_OK = 0,//成功
			ACTION_DAY_PAY_GET_NO,	//奖励已领
			ACTION_DAY_PAY_GET_DAY_ERROR,//天数ID错误
			ACTION_DAY_PAY_GET_FAILES,//领取失败
			ACTION_DAY_PAY_GET_REWARD_NONE,//没有这个奖励
			ACTION_DAY_PAY_GET_CLOSED, //无此活动
			ACTION_DAY_PAY_GET_CONF_ERROR, //配置错误
			ACTION_DAY_PAY_GET_GOLD_NONE,	//累计充值不足
		};
		public enum ENCOUNTER_BATTLE_GIFT_RET
		{
			ENCOUNTER_BATTLE_GIFT_RET_OK = 0,//成功
			ENCOUNTER_BATTLE_GIFT_RET_NO,	//没有这个礼包
			ENCOUNTER_BATTLE_GIFT_RET_NULL,//配置错误
		};
		public enum ENCOUNTER_PVE_RET
		{
			ENCOUNTER_PVE_RET_WIN = 0,//成功
			ENCOUNTER_PVE_RET_LOST,	//失败
			ENCOUNTER_PVE_RET_ERROR,//战役关卡错误
			ENCOUNTER_PVE_RET_NULL,//配置错误
		};
		public enum FRIENDS_DELETE_RET_TYPE
		{
			FRIENDS_DELETE_OK = 0,//成功
			FRIENDS_DELETE_NO,//失败
			FRIENDS_DELETE_NULL,//拒绝
		};
		public enum FRIENDS_RESPONSE_RET_TYPE
		{
			FRIENDS_RESPONSE_OK = 0,//成功
			FRIENDS_RESPONSE_NO,//参数错误
			FRIENDS_RESPONSE_REFUSE,//拒绝
			FRIENDS_RESPONSE_MY_MAX,//自己好友满了
			FRIENDS_RESPONSE_YOU_MAX,//对方好友满了
			FRIENDS_RESPONSE_FRIEND,//对方是好友了
			FRIENDS_RESPONSE_NULL,//对方不在你的应答列表里
		};
		public enum FRIENDS_REQUEST_RET_TYPE
		{
			FRIENDS_REQUEST_OK = 0,//成功
			FRIENDS_REQUEST_NO,//失败
			FRIENDS_REQUEST_MY_MAX,//自己好友满了
			FRIENDS_REQUEST_YOU_MAX,//对方好友满了
			FRIENDS_REQUEST_FRIEND,//对方是好友了
			FRIENDS_REQUEST_TYPE,//类型错误
			FRIENDS_REQUEST_ID,//id错误
			FRIENDS_REQUEST_NAME,//没有这个昵称

		};
		public enum FRIENDS_LIST_RET_TYPE
		{
			FRIENDS_LIST_OK = 0,//成功
			FRIENDS_LIST_NO,//失败
			FRIENDS_LIST_TYPE,//类型错误

		};
		public enum SECRET_RET_TYPE
		{
			SECRET_STORE_OK = 0,//成功
			SECRET_STORE_NO,//失败
			SECRET_STORE_NUM,//次数不够
			SECRET_STORE_NULL,//配置错误
			SECRET_STORE_ITEM,//神秘商店没有这个商品
			SECRET_STORE_TYPE,//类型错误
			SECRET_STORE_MONEY,//货币不够
		};
		public enum SECRET_VIWE_RET_TYPE
		{
			SECRET_VIWE_OK = 0,//成功
			SECRET_VIWE_NO,//失败
			SECRET_VIWE_NULL,//配置错误
			SECRET_VIWE_MONEY,//货币不够
			SECRET_VIWE_ITEM,//道具不够
		};
		/// <summary>
		/// 商店购买返回
		/// </summary>
		public enum SHOP_RET_TYPE
		{
			SHOP_OK = 0,//成功
			SHOP_NO,//失败
			SHOP_NUM,//次数不够
			SHOP_NULL,//配置错误
			SHOP_MONEY,//货币不够
			SHOP_VIP,//vip等级不够
		};
		/// <summary>
		/// 探索返回
		/// </summary>
		public enum ENCOUNTER_RET_TYPE
		{
			ENCOUNTER_OK = 0,//成功
			ENCOUNTER_NO,//失败
			ENCOUNTER_POWER,//体力不够
			ENCOUNTER_NULL,//奇遇表错误
		};
		/// <summary>
		/// 装装备服务器返回类型
		/// </summary>
		public enum EQUIP_UP_TYPE
		{
			EQUIP_OK = 0,//成功
			EQUIP_NO,	//失败
			EQUIP_NULL, //没有这个物品
			EQUIP_POS,//位置错误

		};
		/// <summary>
		/// 装法宝服务器返回类型
		/// </summary>
		public enum TREASURE_UP_TYPE
		{
			TREASURE_OK = 0,//成功
			TREASURE_NO,	//失败
			TREASURE_NULL, //没有这个物品
			TREASURE_POS,//位置错误

		};
		//触发等级改变的类型
		public enum EXP_LV_TYPE
		{
			PVE_EXP = 1,//关卡
			ENCOUNTER_EXP,//奇遇
			PROP_EXP,//道具
			ROB_EXP,//夺宝
			TOWER_EXP,//爬塔
			TOWER_MOPUP_EXP, //扫荡
			MISSION_EXP,//每日任务
			PVE_MOPUP_EXP,//关卡扫荡
			ROB_MOPUP_RXP,//夺宝扫荡
		};
		/// <summary>
		/// 武将上阵返回类型
		/// </summary>
		public enum HERO_UP_TYPE
		{
			HERO_OK = 0,//成功
			HERO_NO,	//失败
			HERO_NULL, //没有这个物品
			HERO_POS,//位置错误
			HERO_SAME,//武将相同

		};
		/// <summary>
		/// 装备精炼结果类型
		/// </summary>
		public enum EQUIP_STRONG_TYPE
		{
			EQUIP_STRONG_OK = 0,
			EQUIP_STRONG_NO,//失败
			EQUIP_STRONG_NULL,//没有这个装备
			EQUIP_STRONG_GOLD,//钱不够
			EQUIP_STRONG_BASE,//配置错误
		};
		/// <summary>
		/// 装备强化结果类型
		/// </summary>
		public enum EQUIP_LV_TYPE
		{
			EQUIP_LV_OK = 0,
			EQUIP_LV_NO,//失败
			EQUIP_LV_NULL,//没有这个装备
			EQUIP_LV_GOLD,//钱不够
			EQUIP_LV_UP_BASE,//配置错误
		};
		public enum FIGHT_TYPE
		{
			FIGHT_NULL = 0,//战报为空
			FIGHT_PVE,//关卡
			FIGHT_PVP,	//争霸
			FIGHT_TOWER,//爬塔
			FIGHT_ENCOUNTER,//奇遇
			FIGHT_ARENA,//竞技场
			FIGHT_ROB,//抢夺
			FIGHT_CHALLENGE,//擂台
			FIGHT_WORLD_BOSS,//世界boss
			FIGHT_VS_FRIEND, //好友切磋
			FIGHT_CONVOY, //护送战斗
			FIGHT_ACTION_PVE,//活动关卡
            FIGHT_CITYWAR,
		}
		/// <summary>
		/// 数据类型
		/// </summary>
		public enum DATA_TYPE
		{
			/// <summary>
			/// 武将
			/// </summary>
			HERO,
			/// <summary>
			/// 装备
			/// </summary>
			EQUIP,
			/// <summary>
			/// 法宝
			/// </summary>
			TREASURE,
		}
		/// <summary>
		/// 刷新出战格子类型
		/// </summary>
		public enum POS_DIRTY_TYPE
		{
			/// <summary>
			/// 所有刷新（换将）
			/// </summary>
			ALL,
			/// <summary>
			/// 只刷新主将（某副将升级强化）
			/// </summary>
			MAIN,
			/// <summary>
			/// 只刷新副将（貌似没只刷全部副将的情况）
			/// </summary>
			DEPUTY,
			/// <summary>
			/// 刷新指定格子（主将升级强化、换装、装备升级精炼），如果格子是副将，则同时刷新所有主将
			/// </summary>
			POS,
		}
		public enum CONST_VALUE
		{
			MAIN_HERO = 0,//主将
			DEPUTY_HERO = 1,//副将
			EQUIP_MAX = 4, //格子最大
			TREASURE_MAX = 2, //格子最大
			MAIN_POSITION_MAX = 6,//主将位置最大
			DEPUTY_POSITION_MAX = 6,//副将位置最大
			DESTINY_MAX = 4, //天命个数
			HERO_TYPE = 10,//武将
			HERO_TYPE_SELF = 11,//自身武将
			EQUIP_TYPE = 20,//装备
			TREASURE_TYPE = 30,//法宝
			TREASURE_TYPE_SELF = 31, //法宝自身
			PROP_TYPE = 40,//道具
			GIFT_TYPE = 50,//礼包
			EXP_TYPE = 60,//经验
			SCORE_TYPE = 62,//声望
			SILVER_TYPE = 61,//银两
			GOLD_TYPE = 63,//元宝
			POWER_TYPE = 64,//体力
			LEVEL_TYPE = 70,//关卡
			HERO_CHIP_TYPE = 80,//武将碎片
			HERO_CHIP_TYPE_SELF = 83,//武将自身碎片
			EQUIP_CHIP_TYPE = 82,//装备碎片
			TREASURE_CHIP_TYPE = 81,//法宝碎片
			LV_GIFT_TYPE = 90,//等级礼包
			MINE_TYPE = 91,//挖矿
			NULL_TYPE = 0,//空类型
			HERO_LEN_MAX = 1000,//武将最大数
			EQUIP_LEN_MAX = 1000,//装备最大数
			TREASURE_LEN_MAX = 1000,//法宝最大数
			ITEM_LEN_MAX = 1000,//道具最大数
			NICK_NAME_MAX = 16, //昵称最大长度
			VIP_LV_MAX = 10,//vip最大等级
			RATIO = 10000,//使用比例
			FIGHT_RATIO = 1000,
			STR_LEN_MAX = 8000,//战报用数据
			SELL_POS = 0x0F,//掩码位置
			SELL_PLACE = 0xF0,
			SELL_L = 0x10,//左边
			SELL_R = 0x20,//右边
			SKILL_ME = 1,//技能目标自己
			SKILL_YOU = 0,//技能目标对方
			SKILL_RAND_SKEW = 4,//技能偏
			TALENT_MAX = 6, //天赋个数
			SKILL_TOWER = 9999999,//召唤小伙伴
			//关卡星级
			STAR_ZERO = 1,
			STAR_ONE = 1,
			STAR_TWO = 2,
			STAR_THREE = 3,

			//战役领奖
			BATTLE_GIFT_NO = 2,//不可领奖
			BATTLE_GIFT_OK = 1,//可领奖
			//关卡
			PVE_TYPE = 10000,
			PVE_EASY = 10,
			PVE_HARD = 11,
			PVE_ENCOUNTER = 12,
			PVE_TOWER = 13,

			//道具类型
			PROP_USETYPE_NO = 1,//不可使用
			PROP_USETYPE_ALL = 2,//全给类型
			PROP_USETYPE_RAND = 3,//随机类型
			PROP_USETYPE_OK = 4,//可使用类型

			//好友
			FRIEND_LIST = 1,//好友列表
			//FRIEND_REQ=2,//请求列表
			FRIEND_RESP = 2,//应答列表
			FRIEND_UPDATE = 0,//好友更新
			FRIEND_ADD = 1,	//好友添加
			FRIEND_DELETE = 2,//好友删除
			FRIEND_NUM_MAX = 50,//好友最大个数
			
			//server
            APP_SERVER_ID = 10000,
            SERVER_ID = 100000000
		};
		/// <summary>
		/// 战斗命令产生的效果,值大于100为buff的配置id
		/// </summary>
		public enum EFFECT_TYPE
		{
			ADD_HP = 1,	//加血
			SUB_HP,		//减血
			ADD_BUFF,
			SUB_BUFF, //
			REVIVE,   //复活
			/// <summary>
			/// 击晕
			/// </summary>
			GIDDY,
			DIE,//死亡
			/// <summary>
			/// 更新怒气
			/// </summary>
			UPDATE_SP,
			/// <summary>
			/// 暴击
			/// </summary>
			CRITICAL,
			/// <summary>
			/// 格挡
			/// </summary>
			PARRY,
			/// <summary>
			/// 吸血
			/// </summary>
			ADSORB,
			/// <summary>
			/// 反伤
			/// </summary>
			DAMAGE_BACK,
			UPDATE_HP,	//更新为当前血量
			NO_ADD_HP,	//不能加血
			VIEW_SP,	//显示怒气变化（客服端显示用）
		};
		public enum PVE_RET
		{
			PVE_WIN = 0,//成功
			PVE_LOSE,	//失败
			PVE_POWER,	//体力不够
			PVE_DROP,	//掉落表错误
			PVE_LEVEL_MAX,//大于最大关卡
			PVE_LEVEL_ERROR,//关卡错误
			PVE_LEVEL_TYPE,//关卡类型错误
			PVE_LV,			//玩家等级不够
			PVE_NUM,			//玩家次数不够
			PVE_MAX,     //最后关卡
		};
		public enum LAYER
		{
			UI = 14,
			MAP,
			EFFECT,
			ACTOR,
			/// <summary>
			/// 特效
			/// </summary>
			FEATURE,
		}

		//返回类型
		public enum LOGIN_GIFT_RET_TYPE
		{
			LOGIN_GIFT_OK = 0,//成功
			LOGIN_GIFT_NO,//已领奖
			LOGIN_GIFT_NULL,//配置数据错误
			LOGIN_GIFT_MAX,//奖以领完
		};

		//返回类型
		public enum PRIZE_GIFT_RET_TYPE
		{
			PRIZE_GIFT_OK = 0,//成功
			PRIZE_GIFT_NO,//失败
			PRIZE_GIFT_NULL,//配置数据错误
		};

		public enum PROP_USE_TYPE
		{
			PROP_USE_OK = 0,//成功
			PROP_USE_NO,//不可以使用
			PROP_USE_SEQ,//物品错误
			PROP_USE_NULL,//道具表错误
			PROP_USE_LV,//等级不够
			PROP_USE_KEY,//道具没有对应的钥匙
			PROP_USE_NUM,//数量不够
		};

		public enum EMAIL_TYPE
		{
			EMAIL_SYS = 1,//系统邮件
			EMAIL_FRIEND,//好友邮件
			EMAIL_FIGHT,//战报
		};

		public enum TOWER_RET
		{
			TOWER_WIN = 0,//成功
			TOWER_LOSE,	//失败
			TOWER_LEVEL_ERROR,//关卡错误
			TOWER_LV,			//玩家等级不够
			TOWER_HELP,//没有帮助玩家
			TOWER_MOPUP,//在扫荡不能爬塔
			TOWER_MAX,  //最大层数，不能挑战
		};

		public enum BATTLE_GIFT_RET
		{
			BATTLE_GIFT_RET_OK = 0,//成功
			BATTLE_GIFT_RET_NO,	//没有这个礼包
			BATTLE_GIFT_RET_NULL,//配置错误
		};

		public enum HERO_STR_TYPE
		{
			HERO_STR_OK = 0,//成功
			HERO_STR_NO, //失败
			HERO_STR_HERO,//没有这个武将
			HERO_STR_CONF,//配置读取错误
			HERO_STR_EXPMAX,//进阶已是最大
			HERO_STR_NOENOUGH_MONEY,//金钱材料不足
			HERO_STR_TYPEERR,//类型错误
			HERO_STR_DELERR,//删除错误
			HERO_STR_NOENOUGH_HERO, //所需武将不足
			HERO_STR_NOENOUGH_EQUIP,//所需装备不足
			HERO_STR_NOENOUGH_TREASURE, //所需法宝不足
			HERO_STR_NOENOUGH_PROP,		//所需道具不足
			HERO_STR_NOENOUGH_CHIP,		//碎片类物品不组
			HERO_STR_APTITUDE_CONF,		//Hero基础属性配置错误
			HERO_STR_HERO_STAR_ERR,		//武将星级错误
			HERO_STR_HERO_STRONG_ERR,	//武将进阶错误
			HERO_STR_PLAYER_LEVEL_ERR,  //玩家等级错误
			HERO_STR_IMMORTAL_DB_ERR,	//神将数据错误
			HERO_STR_IMMORTAL_GOD_HEAD_VALUE_ERR,	//神格初始值错误
			HERO_STR_NOENOUGH_GOLD,  //元宝不足
			HERO_STR_IMMORTAL_APTITUDE_MAX,		//修炼达到最大
			HERO_STR_IMMORTAL_STAGE_MAX,		//神力段位达到最大
			HERO_STR_GOD_HEAD_POS_ERROR,		//升级的神格位置错误
			HERO_STR_GOD_HEAD_ATTRIBUTETYPE_ERROR,	//升级属性错误
			HERO_STR_GOD_HEAD_CONFIG_ERROR,		//神格升级配置错误
			HERO_STR_GOD_HEAD_MAX_LEVEL,		//神格最大等级
			HERO_STR_CENTER_GOD_HEAD_DISABLE,	//中间神格没有激活
			HERO_STR_CENTER_GOD_HEAD_IS_ACTIVATION,	//中间神格已激活
			HERO_STR_CENTER_GOD_HEAD_COSTVALUE_ERR,	//中间神格话费值错误
			HERO_STR_GOD_HEAD_IS_APPEND,	//神格已附件
			HERO_STR_GOD_HEAD_NOT_APPEND,	//神格没有激活
			HERO_STR_GOD_HEAD_APPEND_MAX,	//神格激活已经最大
			HERO_STR_MONEY_ERR,				//传来的消耗数量与服务器不一致
			HERO_STR_GOD_HEAD_CHANGE_UNKNOW,//未知上阵操作
		};

		public enum FIGHT_TREASURE_ROB_RET
		{
			FIGHT_TREASURE_ROB_WIN = 0,//胜利
			FIGHT_TREASURE_ROB_LOST,	//失败
			FIGHT_TREASURE_ROB_ACCOUNTID,//没有这个玩家
			FIGHT_TREASURE_ROB_ITEM,//没有这个物品了
			FIGHT_TREASURE_ROB_ENDURANCE,// 耐力不足
			FIGHT_TREASURE_ROB_UNKNOW_CHIP,//未知碎片
			FIGHT_TREASURE_ROB_HAVE_CHIP,//玩家已有此碎片，不能抢夺
			FIGHT_TREASURE_ROB_NO_ONE_CHIP,//玩家身上没有这个配方中的其他碎片,不能抢夺
			FIGHT_TREASURE_SHIEID,//玩家保护盾
		};

		public enum TREASURE_STR_TYPE
		{
			TREASURE_STR_OK = 0,//成功
			TREASURE_STR_NO, //失败
			TREASURE_STR_HERO,//没有这个武将
			TREASURE_STR_CONF,//配置读取错误
			TREASURE_STR_EXPMAX,//进阶已是最大
			TREASURE_STR_NOENOUGH,//金钱材料不足
			TREASURE_STR_TYPEERR,//类型错误
			TREASURE_STR_DELERR,//删除错误
		};

		public enum EQUIP_BAPTIZE_TYPE
		{
			EQUIP_BAPTIZE_OK = 0,//成功
			EQUIP_BAPTIZE_SEQ,//装备为空
			EQUIP_BAPTIZE_LV,//玩家等级不够
			EQUIP_BAPTIZE_SILVER,//钱不够
			EQUIP_BAPTIZE_GOLD,//钱不够
			EQUIP_BAPTIZE_PROP,//道具不够
			EQUIP_BAPTIZE_NULL,//配置表错误
			EQUIP_BAPTIZE_VALUE,//传的数据错误
			EQUIP_BAPTIZE_EQUIP_LV,//装备等级不够
		};

		public enum EQUIP_BAPTIZE_OK_TYPE
		{
			EQUIP_BAPTIZE_OK_OK = 0,//成功
			EQUIP_BAPTIZE_OK_SEQ,//seq错误
		};

		public enum PROP_SHIEID_TYPE
		{
			PROP_SHIEID_OK = 0,//成功
			PROP_SHIEID_GOLD,//元宝不够
			PROP_SHIEID_ITME,//道具不够
			PROP_SHIEID_NULL,//道具表错误
		};
		public enum TREAS_ERR_TYPE
		{
			TREAS_OK = 0,//成功
			TREAS_STR_NO, //失败
			TREAS_STR_TREAS,//没有这个武将
			TREAS_STR_CONF,//配置读取错误
			TREAS_STR_EXPMAX,//进阶已是最大
			TREAS_STR_NOENOUGH,//金钱材料不足
			TREAS_STR_TYPEERR,//类型错误
			TREAS_STR_DELERR,//删除错误
			TREAS_COM_NOTARGET,//合成目标不存在
			TREAS_COM_CONF,	   //合成配置表错误
			TREAS_COM_CHIPMONY,//所需数量或者钱币配置错误
			TREAS_COM_CHIP,	   //材料碎片不足
			TREAS_COM_MONY,	   //钱不足
			TREAS_COM_CHIP_DEL,//删除碎片错误
			TREAS_COM_MONY_DEL,//删除钱错误
			TREAS_ROB_UNKNOW_CHIP,
			TREAS_ROB_HAVE_CHIP,
			TREAS_ROB_NO_ONE_CHIP,
		};
		public enum CHALLENGE_PVE_RET
		{
			CHALLENGE_PVE_RET_WIN = 0,//胜利
			CHALLENGE_PVE_RET_LOST,	//失败
			CHALLENGE_PVE_RET_CHALLENGE,//你也是擂台主
			CHALLENGE_PVE_RET_NULL,//配置错误
			CHALLENGE_PVE_RET_LV,//挑战等级错误
			CHALLENGE_PVE_RET_LEN,//个数错误
			CHALLENGE_PVE_RET_NUM,//没有挑战次数了
		};

		public enum TOWER_MOPUP_RET
		{
			TOWER_MOPUP_OK = 0,//成功
			TOWER_MOPUP_NO,	//失败
			TOWER_MOPUP_LEVEL_ERROR,//关卡错误
			TOWER_MOPUP_LV,			//玩家等级不够
			TOWER_MOPUP_HELP,
			TOWER_MOPUP_REDO,	//重复扫荡
		};
		public enum TOWER_MOPUP_END_RET
		{
			TOWER_MOPUP_END_OK = 0,//成功
			TOWER_MOPUP_END_NO,	//失败
		};
		public enum PVE_MOPUP_RET
		{
			PVE_MOPUP_OK = 0,//成功
			PVE_MOPUP_POWER,	//体力不够
			PVE_MOPUP_DROP,	//掉落表错误
			PVE_MOPUP_LEVEL_MAX,//大于最大关卡
			PVE_MOPUP_LEVEL_ERROR,//关卡错误
			PVE_MOPUP_LEVEL_TYPE,//关卡类型错误
			PVE_MOPUP_LV,			//玩家等级不够
			PVE_MOPUP_NUM,//次数错误
		};

		public enum PRIZE_GIFT_TYPE
		{
			PRIZE_GIFT_GROW = 1,//成长礼包
			PRIZE_GIFT_COMPENSATION = 2,//补偿礼包
			PRIZE_GIFT_ARENA_LUCKY,		//竞技场幸运礼包
			PRIZE_GIFT_ARENA_RANK,		//竞技场排行礼包
			PRIZE_GIFT_TOWER_MOPUP,		//爬塔扫荡
			PRIZE_GIFT_CHALLENGE,		//擂台礼包
			PRIZE_GIFT_BAG_MAX,		//背包满了过来的
			PRIZE_GIFT_ACTION_TREAS_AUC_WIN_ITEM,//宝物拍卖获得的物品
			PRIZE_GIFT_ACTION_TREAS_AUC_BACK_GOLD,//宝物拍卖失败返回的元宝
			PRIZE_GIFT_ACTION_WORLD_BOSS_RANK, //boss排行
			PRIZE_GIFT_GM_SEND_PACK,	//GM发送的礼包	
			PRIZE_GIFT_SYSTEM_GIFT_PACK,	//全服礼包
			PRIZE_GIFT_TOWER_RANK,		//爬塔排行
			PRIZE_GIFT_CDK,		//兑换码礼包
			PRIZE_GIFT_ARENA_MOBAI,	//竞技场膜拜礼包
            PRIZE_GIFT_ACTION_SILVER,//银两兑换活动
            PRIZE_GIFT_ACTION_PAY_DOUBLE,//双倍奖励
            PRIZE_GIFT_ACTION_PAY_DAY2,//每日充值第二段 拜见主公
			PRIZE_GIFT_GOD_HERO_RANK,//神将排行
			PRIZE_GIFT_LOTTERT_RETURN_GOLD,	//全民夺宝返回元宝
			PRIZE_GIFT_LOTTERT_WINER_GIFT,	//全民夺宝赢家礼包
			PRIZE_GIFT_LOTTERT_COMFORT_GIFT,//全民夺宝安慰礼包
		};
		public enum BAG_TYPE
		{
			BAG_HERO = 1,//武将背包
			BAG_EQUIP,//装备背包
			BAG_TREASURE,//法宝背包
		};

		//背包返回类型
		public enum BAG_RET_TYPE
		{
			BAG_RET_OK = 0,//成功
			BAG_RET_NO,//失败
			BAG_RET_MAX,//达到最大
			BAG_RET_NULL,//配置错误
			BAG_RET_GOLD,//钱不够 
		};

		public enum BAG_MAX_TYPE
		{
			BAG_MAX_HERO = 0,//武将
			BAG_MAX_EQUIP, //装备
			BAG_MAX_TREASURE,//法宝
			BAG_MAX_PROP,//道具
			BAG_MAX_HERO_CHIP,//武将
			BAG_MAX_EQUIP_CHIP, //装备
			BAG_MAX_TREASURE_CHIP,//法宝
			BAG_MAX_HERO_AND_GIFT,//武将
			BAG_MAX_EQUIP_AND_GIFT, //装备
			BAG_MAX_TREASURE_AND_GIFT,//法宝
		};

		public enum HERO_TAVERN_TYPE
		{
			HERO_TAVERN_OK = 0,//成功
			HERO_TAVERN_NULL,//配置错误
			HERO_TAVERN_RAND,//抽卡错误
			HERO_TAVERN_ITEM,//物品不够
			HERO_TAVERN_GOLD,//元宝不够
			HERO_TAVERN_VALUE,//传的值有错
			HERO_TAVERN_TIME,//时间没到
		};

		public enum FIGHT_VS_FRIEND_RET
		{
			FIGHT_VS_FRIEND_WIN = 0,//成功
			FIGHT_VS_FRIEND_LOST,	//失败
			FIGHT_VS_FRIEND_EEEOR, //战斗错误 切磋对象不是好友
			FIGHT_VS_FRIEND_GOLD_ERR, //元宝不是这个好友产生
		};

		public enum FIGHT_ASSIGN_PLAYER
		{
			ASSIGN_PLAYER_OK = 0,//成功
			ASSIGN_PLAYER_NO,	//没有这个玩家
			ASSIGN_PLAYER_DOUBLE,	//第二次指定
			ASSIGN_PLAYER_GOLD,	//元宝不够
			ASSIGN_PLAYER_FRIEND,	//不是好友
		};

		public enum SENCE_TYPE
		{
			SENCE_CITY = 0,					//主城
			SENCE_HERO = 10,
			SENCE_ARENA_1,				//竞技场主显示界面
			SENCE_ARENA_2,				//竞技场前十界面
			SENCE_ARENA_3,				//竞技场幸运玩家界面
			SENCE_CHALLENGE,			//擂台
			SENCE_FRIEND,				//好友列表界面，推送揩油信息
            SENCE_CITYWAR,				//联盟城战
			SENCE_ACTION_TREAS_AUC = 50,	//宝物拍卖
			SENCE_ACTION_ACTION_LOTTERY,	//全民夺宝
			SENCE_WORLD_BOOS = 100001,//世界boss
		};

		public enum KAIYOU_TYPE
		{
			KAIYOU_OK,//成功
			KAIYOU_NOT_FRIEND,//失败
			KAIYOU_NO_SILVER,  //银两为零，不能揩油
			KAIYOU_ERR_ROLE_BASE_DATA, //配置错误
		};

		public enum R_POWER_TYPE
		{
			POWER_OK,//成功
			POWER_NOT_FRIEND,//失败
			NO_POWER,  //体力为0，不能领取
		};

		public enum ACTION_SILVER_TYPE
		{
			ACTION_SILVER_OK = 0,//成功
			ACTION_SILVER_NUM,//次数不够
			ACTION_SILVER_GOLD,//钱不够
		};


		public enum MINEING_TYPE
		{
			MINE_1 = 1,//挖掘
			MINE_2,//爆破
			MINE_3,//敲碎
		};

		public enum PLAYER_MINE_TYPE
		{
			PLAYER_MINE_OK,//成功
			PLAYER_MINE_NO,//没有的类型
			PLAYER_MINE_HP,//矿还没挖完
			PLAYER_MINE_NO_HP,//矿挖完
			PLAYER_MINE_HAMMER,//没锤子了
			PLAYER_MINE_NULL,//配置错误
			PLAYER_MINE_SILVER,//银两不够
			PLAYER_MINE_GOLD,//元宝不够
		};
		public enum ACTION_CONVOY_VIEW_TYPE
		{
			ACTION_CONVOY_VIEW_OK = 0,//成功
			ACTION_CONVOY_VIEW_NO,//没有这个活动
			ACTION_CONVOY_VIEW_NULL,//配置错误
		};
		public enum ACTION_CONVOY_HORSE_TYPE
		{
			ACTION_CONVOY_HORSE_OK = 0,//成功
			ACTION_CONVOY_HORSE_NO,//没有这个活动
			ACTION_CONVOY_HORSE_GOLD,//元宝不够
			ACTION_CONVOY_HORSE_STATE,//状态不对
		};
		public enum ACTION_CONVOY_GO_TYPE
		{
			ACTION_CONVOY_GO_OK = 0,//成功
			ACTION_CONVOY_GO_NO,//没有这个活动
			ACTION_CONVOY_GO_STATE,//状态不对
		};
		public enum ACTION_PLAYER_HORSE_TYPE
		{
			ACTION_PLAYER_HORSE_OK = 0,//成功
			ACTION_PLAYER_HORSE_NO,//没有这个活动
			ACTION_PLAYER_HORSE_STATE,//状态不对
		};
		//护送战斗
		public enum FIGHT_CONVOY_RET
		{
			FIGHT_CONVOY_WIN = 0,//成功
			FIGHT_CONVOY_LOST,	//失败
			FIGHT_CONVOY_CD, //冷却时间
			FIGHT_CONVOY_NO,//活动结束
			FIGHT_CONVOY_END,//对方完成
			FIGHT_CONVOY_SILVER,//对方没钱
			FIGHT_CONVOY_NULL,//配置错误
			FIGHT_CONVOY_STATE,//状态不对

		};
		public enum ACTION_CONVOY_WIN_TYPE
		{
			ACTION_CONVOY_WIN_OK = 0,//成功
			ACTION_CONVOY_WIN_NO,//没有这个活动
			ACTION_CONVOY_WIN_STATE,//状态不对
			ACTION_CONVOY_WIN_NULL,//配置不对
			ACTION_CONVOY_WIN_TIME,//时间没到
		};

		public enum RESULT_S2C_LOGIN
		{
			RESULT_S2C_LOGIN_OK = 0,	// 成功
			RESULT_S2C_LOGIN_WRONG_VERSION = 1,	// 服务器忙，请稍候再试
			RESULT_S2C_LOGIN_SERVER_BUSY = 2,	// 服务器忙，请稍候再试
			RESULT_S2C_LOGIN_FULL = 3,	// 所有的FEP都满了，客户端可以稍后再试
			RESULT_S2C_LOGIN_INVALID_USERDATA = 4,	// 客户端发送的用户数据不对，客户端需要重新登录
			RESULT_S2C_LOGIN_USERDATA_TIMEOUT = 5,	// 客户端发送的用户数据已经过期了，客户端需要重新登录
			RESULT_S2C_LOGIN_IN_BAN_TIME = 6, // 被禁止登录
		} ;

		public enum DECOMPOSE_TYPE
		{
			HERO_DECOMPOSE_OK = 0,//成功
			HERO_DECOMPOSE_LEVEL_ERR,//等级不够			
			HERO_DECOMPOSE_LEN_ERR,	//长度错误			
			HERO_DECOMPOSE_TYPE_UNKNOW,	//未知类型		
			HERO_DECOMPOSE_HERO_SEQID_NULL,	//武将seqID错误		
			HERO_DECOMPOSE_HERO_CONFIG_NULL,//没有武将配置		
			HERO_DECOMPOSE_HERO_CONFIG_EXP_NULL,	//武将经验表配置错误	
			EQUIP_DECOMPOSE_EQUIP_SEQID_NULL,		//装备seqID错误		
			EQUIP_DECOMPOSE_EQUIP_CONFIG_NULL,		//没有装备配置		
			EQUIP_DECOMPOSE_EQUIP_CONFIG_EXP_NULL,	//装备经验表配置错误
			TREAS_DECOMPOSE_TREAS_SEQID_NULL,		//法宝seqID错误		
			TREAS_DECOMPOSE_TREAS_CONFIG_NULL,		//没有法宝配置		
			TREAS_DECOMPOSE_TREAS_CONFIG_EXP_NULL,	//法宝经验表配置错误

			DECOMPOSE_INFO_LEVEL_CONFIG_ERR,			//等级限制错误   
			DECOMPOSE_INFO_HERO_COST_CONFIG_ERR,		//英雄洗练石配置错误		
			DECOMPOSE_INFO_EQUIP_COST_CONFIG_ERR,		//装备洗练石配置错误		
			DECOMPOSE_INFO_TREAS_COST_CONFIG_ERR,		//法宝洗练石配置错误		
			DECOMPOSE_XILIANSHI_NOT_ENOUGH,		//洗练石不够						
			HERO_DECOMPOSE_HERO_HAVE_EXP,				//分解有经验武将
			HERO_DECOMPOSE_HERO_HAVE_LEVEL,				//分解有等级的武将
			HERO_DECOMPOSE_HERO_HAVE_JINJIE,			//分解进阶过的武将
			HERO_DECOMPOSE_HERO_HAVE_FENSHEN,			//分解封过神的武将
			HERO_DECOMPOSE_HERO_INFO_HEROSTAR_LIMIT_ERROR,	//分解武将星级配置错误
			HERO_DECOMPOSE_HERO_HEROSTAR_LIMIT_ERROR,	//分解武将星级不够
			EQUIP_DECOMPOSE_EQUIP_HAVE_EXP,				//分解有经验装备
			EQUIP_DECOMPOSE_EQUIP_HAVE_LEVEL,			//分解有等级装备
			EQUIP_DECOMPOSE_EQUIP_HAVE_XILIAN,			//分解洗练过的装备
			EQUIP_DECOMPOSE_EQUIP_INFO_EQUIPSTAR_LIMIT_ERROR,	//分解装备星级配置错误
			EQUIP_DECOMPOSE_EQUIP_EQUIPSTAR_LIMIT_ERROR,	//分解装备星级不够
			TREAS_DECOMPOSE_TREAS_HAVE_EXP,				//分解有经验法宝	
			TREAS_DECOMPOSE_TREAS_HAVE_LEVEL,			//分解有等级法宝
			TREAS_DECOMPOSE_TREAS_HAVE_JINJIE,			//分解进阶过的法宝
			TREAS_DECOMPOSE_TREAS_INFO_TREASSTAR_LIMIT_ERROR,//分解法宝星级配置错误
			TREAS_DECOMPOSE_TREAS_TREASSTAR_LIMIT_ERROR,//分解法宝星级不够
			DECOMPOSE_USE_XILIANSHI_ERROR,			//使用洗练石错误
			DECOMPOSE_DEL_HERO_ERROR,				//分解删除武将错误
			DECOMPOSE_DEL_EQUIP_ERROR,				//分解删除装备错误
			DECOMPOSE_DEL_TREAS_ERROR,				//分解删除法宝错误
		};

		public enum RESTORE_TYPE
		{
			HERO_RESTORE_OK = 0,//成功
			HERO_RESTORE_LEVEL_ERR,//等级不够
			HERO_RESTORE_LEN_ERR,	//长度错误
			HERO_RESTORE_TYPE_UNKNOW,	//未知类型
			HERO_RESTORE_HERO_SEQID_NULL,	//武将seqID错误
			HERO_RESTORE_HERO_CONFIG_NULL,//没有武将配置
			HERO_RESTORE_HERO_CONFIG_EXP_NULL,	//武将经验表配置错误
			HERO_RESTORE_HERO_CONFIG_EVOLVE_NULL,	//武将进阶配置错误
			EQUIP_RESTORE_EQUIP_SEQID_NULL,		//装备seqID错误
			EQUIP_RESTORE_EQUIP_CONFIG_NULL,		//没有装备配置
			EQUIP_RESTORE_EQUIP_CONFIG_EXP_NULL,	//装备经验表配置错误
			EQUIP_RESTORE_XILIAN_CONFIG_EXP_NULL,	//洗练系数错误
			TREAS_RESTORE_TREAS_SEQID_NULL,		//法宝seqID错误
			TREAS_RESTORE_TREAS_CONFIG_NULL,		//没有法宝配置
			TREAS_RESTORE_TREAS_CONFIG_EXP_NULL,	//法宝经验表配置错误
			TREAS_RESTORE_TREAS_CONFIG_EVOLVE_NULL,//法宝进阶配置错误
			HERO_BAG_NULL_POS,						//武将背包没有空位
			EQUIP_BAG_NULL_POS,						//装备背包没有空位
			TREAS_BAG_NULL_POS,						//法宝背包没有空位
			PROP_BAG_NULL_POS,						//法宝背包没有空位
			RESTORE_UNKNOW_TYPE,					//分解未知类型物品
			RESTORE_HERO_RESTORE_ERR,				//还原武将错误
			RESTORE_EQUIP_RESTORE_ERR,				//还原装备错误
			RESTORE_TREAS_RESTORE_ERR,				//还原武将错误
			RESTORE_INFO_EXP_CONFIG_ERR,			//info经验特殊物品ID错误
			RESTORE_INFO_LEVEL_CONFIG_ERR,			//等级限制错误
			RESTORE_SET_HERO_EXP_ERR,				//设置经验武将经验出错
			RESTORE_SET_EQUIP_EXP_ERR,				//设置经验装备经验出错
			RESTORE_SET_TREAS_EXP_ERR,				//设置经验法宝经验出错
			RESTORE_INFO_HERO_COST_CONFIG_ERR,		//英雄洗练石配置错误
			RESTORE_INFO_EQUIP_COST_CONFIG_ERR,		//装备洗练石配置错误
			RESTORE_INFO_TREAS_COST_CONFIG_ERR,		//法宝洗练石配置错误
			RESTORE_XILIANSHI_NOT_ENOUGH,		//洗练石不够
			RESTORE_XILIANSHI_USE_ERR,			//洗练石使用错误
		};

		public enum TREASURE_ROB_TEN
		{
			TREASURE_ROB_SUCESS = 0,//成功
			TREASURE_ROB_FAILD,	//失败
			TREASURE_ROB_ENDURANCE,// 耐力不足
			TREASURE_ROB_NOT_ROBOT,//强的不是机器人
			TREASURE_ROB_UNKNOW_CHIP,//未知碎片
			TREASURE_ROB_HAVE_CHIP,	//玩家已有这个碎片
			TREASURE_ROB_NO_ONE_CHIP,	//玩家没有配方中的其他碎片，不能抢夺
		};
		public enum GOD_EXCHANGE_TYPE
		{
			GOD_EXCHANGE_OK,
			GOD_COUNT_NOT_ENOUGTH,	//天神令数量不足
			GOD_DELETE_ERROR,	//兑换的不是天神令
		};

		public enum LEVEL_GIFT_TYPE
		{
			LEVEL_GIFT_OK,//成功
			LEVEL_GIFT_NO,//奖励已领取
			LEVEL_GIFT_LV,  //等级不够
			LEVEL_GIFT_NEXT,//不是下一个id
			LEVEL_GIFT_NULL,//配置错误
		};

		public enum ITEM_SELL_TYPE
		{
			ITEM_SELL_OK = 0,//成功
			ITEM_SELL_NO,//奖励已领取
			ITEM_SELL_NULL,//配置错误
			ITEM_SELL_SEQID,//id错误
			ITEM_SEL_TYPE,//类型cw
		};

		public enum BUY_VIPPACK_TYPE
		{
			BUY_VIPPACK_OK = 0,//成功
			BUY_VIPPACK_NOT_VIP,//不是VIP
			BUY_VIPPACK_ID_ERROR,//ID错误
			BUY_VIPPACK_VIP_LEVEL_LOW,	//VIP等级不够
			BUY_VIPPACK_BOUGHT,		//已经购买过
			BUY_VIPPACK_GOLD_NOT_ENOUGH,//元宝不足

		};

		public enum ACTION_MOON_VIEW_TYPE
		{
			ACTION_MOON_VIEW_OK,	//领取成功
			ACTION_MOON_VIEW_CLOSED,	//活动结束
			ACTION_MOON_VIEW_NO,//没有这个活动
			ACTION_MOON_VIEW_START,//时间未到
			ACTION_MOON_VIEW_END,//时间结束
			ACTION_MOON_VIEW_CONFIG_NULL,//配置错误
			ACTION_MOON_VIEW_ACTION_TYPE,//活动类型错误
			ACTION_MOON_VIEW_ACTION_ID_ERROR,	//活动ID错误
		};
		public enum ACTION_MOON_TYPE
		{
			ACTION_MOON_OK,	//领取成功
			ACTION_MOON_CLOSED,	//活动结束
			ACTION_MOON_CONF_ERROR,	//配置错误
			ACTION_MOON_REWARDID_ERROR,	//奖励错误
			ACTION_MOON_TODAY_GET,	//当天已领取
			ACTION_MOON_GET_ID_ERROR,	//领取ID错误
		};

		public enum CHANGE_NAME_TYPE
		{
			CHANGE_NAME_OK = 0,//成功
			CHANGE_NAME_NO,//为昵称存在
			CHANGE_NAME_NORM,//为昵称不规范
			CHANGE_NAME_GOLD,//钱不够
		};

		//活动查看
		public enum ACTION_PVE_TYPE
		{
			ACTION_PVE_OK,	//查看
			ACTION_PVE_CLOSED,	//活动结束
			ACTION_PVE_ID,//没有这个活动
			ACTION_PVE_TIME_START,//时间未到
			ACTION_PVE_TIME_END,//时间结束
			ACTION_PVE_NULL,//配置错误
		};

		/// <summary>
		/// 活动战役
		/// </summary>
		public enum FIGHT_ACTION_PVE_RET
		{
			FIGHT_ACTION_PVE_WIN = 0,//成功
			FIGHT_ACTION_PVE_LOSE,	//失败
			FIGHT_ACTION_PVE_GOLD,	//钱不够
			FIGHT_ACTION_PVE_DROP,	//掉落表错误
			FIGHT_ACTION_PVE_LEVEL_MAX,//大于最大关卡
			FIGHT_ACTION_PVE_LEVEL_ERROR,//关卡错误
			FIGHT_ACTION_PVE_LEVEL_TYPE,//关卡类型错误
			FIGHT_ACTION_PVE_LV,			//玩家等级不够
			FIGHT_ACTION_PVE_NUM,			//玩家次数不够
			FIGHT_ACTION_PVE_MAX,     //最后关卡
			FIGHT_ACTION_PVE_CLOSED,//活动结束
			FIGHT_ACTION_PVE_NULL,//配置表错误
		};

		public enum ACTION_PVE_GET_TYPE
		{
			ACTION_PVE_GET_OK,	//领取成功
			ACTION_PVE_GET_CLOSED,	//活动结束
			ACTION_PVE_GET_ACTION_ID,//没有这个活动
			ACTION_PVE_GET_TIME_START,//时间未到
			ACTION_PVE_GET_TIME_END,//时间结束
			ACTION_PVE_GET_NULL,//配置错误
			ACTION_PVE_GET_NUM,//物品数量不够
			ACTION_PVE_GET_ID,//兑换id不对
			ACTION_PVE_GET_LIMIT,//兑换限制
		};

		public enum MOBAI_TYPE
		{
			MOBAI_OK = 0,	//成功
			MOBAI_FAILD,	//膜拜失败
			MOBAI_ALREADY, //已经膜拜过
		};

		public enum PAY_REBATE_VIEW_TYPE
		{
			PAY_REBATE_VIEW_OK,	//查看
			PAY_REBATE_VIEW_CLOSED,	//活动结束
			PAY_REBATE_VIEW_ID,//没有这个活动
			PAY_REBATE_VIEW_TIME_START,//时间未到
			PAY_REBATE_VIEW_TIME_END,//时间结束
			PAY_REBATE_VIEW_NULL,//配置错误
		};

		public enum PAY_REBATE_GET_TYPE
		{
			PAY_REBATE_GET_OK,	//查看
			PAY_REBATE_GET_CLOSED,	//活动结束
			PAY_REBATE_GET_ID,//没有这个活动
			PAY_REBATE_GET_TIME_START,//时间未到
			PAY_REBATE_GET_TIME_END,//时间结束
			PAY_REBATE_GET_NULL,//配置错误
			PAY_REBATE_GET_PHASE,//阶段不对
			PAY_REBATE_GET_NO_PAY,//没充钱
			PAY_REBATE_GET_ALREADY,//已领奖
		};

		public enum PAY_DOUBLE_VIEW_TYPE
		{
			PAY_DOUBLE_VIEW_OK,	//查看
			PAY_DOUBLE_VIEW_CLOSED,	//活动结束
			PAY_DOUBLE_VIEW_ID,//没有这个活动
			PAY_DOUBLE_VIEW_TIME_START,//时间未到
			PAY_DOUBLE_VIEW_TIME_END,//时间结束
			PAY_DOUBLE_VIEW_NULL,//配置错误
			ACTION_DOUBLE_PAY_ID,//id不对
		};

        public enum KAIYOU_ALL_TYPE
        {
	        KAIYOU_ALL_OK =0,		//成功
	        KAIYOU_ALL_FAILD,	//失败
	        KAIYOU_ALL_NOFRIEND , //没有好友
	        KAIYOU_ALL_ERR_ROLE_BASE_DATA,//配置错误
        };

        public enum ACTION_GOOD_BOSS_VIEW_TYPE
        {
            ACTION_GOOD_BOSS_VIEW_OK,	//查看
            ACTION_GOOD_BOSS_VIEW_CLOSED,	//活动结束
            ACTION_GOOD_BOSS_VIEW_ID,//没有这个活动
            ACTION_GOOD_BOSS_VIEW_TIME_START,//时间未到
            ACTION_GOOD_BOSS_VIEW_TIME_END,//时间结束
            ACTION_GOOD_BOSS_VIEW_NULL,//配置错误
            ACTION_GOOD_BOSS_VIEW_ACTION_ID,//id不对
        };

        public enum ACTION_GOOD_BOSS_GET_TYPE
        {
            ACTION_GOOD_BOSS_GET_OK,	//查看
            ACTION_GOOD_BOSS_GET_CLOSED,	//活动结束
            ACTION_GOOD_BOSS_GET_ID,//没有这个活动
            ACTION_GOOD_BOSS_GET_TIME_START,//时间未到
            ACTION_GOOD_BOSS_GET_TIME_END,//时间结束
            ACTION_GOOD_BOSS_GET_NULL,//配置错误
            ACTION_GOOD_BOSS_GET_ACTION_ID,//id不对
            ACTION_GOOD_BOSS_GET_ACCOUNTID,//不是你击杀的
            ACTION_GOOD_BOSS_GET_ALREADY,//已领取
        };

        public enum ACTION_GOD_HERO_VIEW_TYPE
        {
            ACTION_GOD_HERO_VIEW_OK,	//查看
            ACTION_GOD_HERO_VIEW_CLOSED,	//活动结束
            ACTION_GOD_HERO_VIEW_ID,//没有这个活动
            ACTION_GOD_HERO_VIEW_TIME_START,//时间未到
            ACTION_GOD_HERO_VIEW_TIME_END,//时间结束
            ACTION_GOD_HERO_VIEW_NULL,//配置错误
            ACTION_GOD_HERO_VIEW_ACTION_ID,//id不对
        };

        public enum ACTION_GOD_HERO_GET_TYPE
        {
            ACTION_GOD_HERO_GET_OK,	//查看
            ACTION_GOD_HERO_GET_CLOSED,	//活动结束
            ACTION_GOD_HERO_GET_ID,//没有这个活动
            ACTION_GOD_HERO_GET_TIME_START,//时间未到
            ACTION_GOD_HERO_GET_TIME_END,//时间结束
            ACTION_GOD_HERO_GET_NULL,//配置错误
            ACTION_GOD_HERO_GET_ACTION_ID,//id不对
            ACTION_GOD_HERO_GET_ACCOUNTID,//不是你击杀的
            ACTION_GOD_HERO_GET_ALREADY,//已领取
        };
        public enum ACTION_LOTTERY_BET_TYPE
        {
            ACTION_LOTTERY_BET_OK,	//查看
            ACTION_LOTTERY_BET_NOT_OPEN,	//投注未开
            ACTION_LOTTERY_BET_FULL,		//投注满了
            ACTION_LOTTERY_BET_OVER,	//投注结束
            ACTION_LOTTERY_BET_STATUS_ERROR,	//投注状态异常
            ACTION_LOTTERY_ACTION_NULL,	//没有这个活动
            ACTION_LOTTERY_PERIODS_CONFIG_NULL,	//期数配置错误
            ACTION_LOTTERY_BET_GOLD_ERROR,		//投注金额错误
            ACTION_LOTTERY_BET_GOLD_OVERFLOW,	//投注金额溢出
            ACTION_LOTTERY_BET_GOLD_NOTENOUGH,	//元宝不足
        };
        //活动查看
        public enum ACTION_LOTTERY_RETURN_TYPE
        {
            ACTION_LOTTERY_OK,	//查看
            ACTION_LOTTERY_CLOSED,	//活动结束
            ACTION_LOTTERY_ID,//没有这个活动
            ACTION_LOTTERY_TIME_START,//时间未到
            ACTION_LOTTERY_TIME_END,//时间结束
            ACTION_LOTTERY_NULL,//配置错误
            ACTION_LOTTERY_ACTION_ID,//id不对
        };
	 //创建联盟
        public enum ALLIANCE_CREATE_TYPE
        {
            ALLIANCE_CREATE_OK,
            ALLIANCE_CREATE_ON,
            ALLIANCE_CREATE_GOLD,	
            ALLIANCE_CREATE_LV,
            ALLIANCE_CREATE_ALLIANCE,
        };
       public enum ALLIANCE_LIST_VIEW_TYPE
        {
            ALLIANCE_LIST_VIEW_OK,	
            ALLIANCE_LIST_VIEW_ON,
        };
       //
       public enum ALLIANCE_APPLY_TYPE
       {
           ALLIANCE_APPLY_OK,	
           ALLIANCE_APPLY_ON,
           ALLIANCE_APPLY_NUM,
           ALLIANCE_APPLY_MAX,
           ALLIANCE_APPLY_ID,
           ALLIANCE_APPLY_LV,
           ALLIANCE_APPLY_TIME,
       };
       public enum ALLIANCE_MEMBER_CONSENT_TYPE
       {
           ALLIANCE_MEMBER_CONSENT_OK,
           ALLIANCE_MEMBER_CONSENT_ON,
           ALLIANCE_MEMBER_CONSENT_MAX,
           ALLIANCE_MEMBER_CONSENT_ACCOUNTID,
           ALLIANCE_MEMBER_CONSENT_ALLIANCEID,
           ALLIANCE_MEMBER_CONSENT_PRIVILEGE,
           ALLIANCE_MEMBER_CONSENT_APPLY,
           ALLIANCE_MEMBER_CONSENT_NULL,
       };
      public enum ALLIANCE_MY_VIEW_TYPE
       {
           ALLIANCE_MY_VIEW_OK,	
           ALLIANCE_MY_VIEW_ON,
       };
      public enum ALLIANCE_MY_MEMBER_VIEW_TYPE
      {
          ALLIANCE_MY_MEMBER_VIEW_OK,	
          ALLIANCE_MY_MEMBER_VIEW_ON,
      };
      public enum ALLIANCE_MY_APPLY_VIEW_TYPE
      {
          ALLIANCE_MY_APPLY_VIEW_OK,	
          ALLIANCE_MY_APPLY_VIEW_ON,
      };
      public enum ALLIANCE_MEMBER_KICK_TYPE
      {
          ALLIANCE_MEMBER_KICK_OK,	
          ALLIANCE_MEMBER_KICK_ON,
          ALLIANCE_MEMBER_KICK_ALLIANCEID,
          ALLIANCE_MEMBER_KICK_PRIVILEGE,
          ALLIANCE_MEMBER_KICK_ID,
      };
     public enum ALLIANCE_MEMBER_QUIT_TYPE
      {
          ALLIANCE_MEMBER_QUIT_OK,	
          ALLIANCE_MEMBER_QUIT_ON,
          ALLIANCE_MEMBER_QUIT_ALLIANCEID,
          ALLIANCE_MEMBER_QUIT_PRIVILEGE,
      };
     public enum ALLIANCE_MEMBER_CHANGE_TYPE
     {
         ALLIANCE_MEMBER_CHANGE_OK,	
         ALLIANCE_MEMBER_CHANGE_ON,
         ALLIANCE_MEMBER_CHANGE_ID,
         ALLIANCE_MEMBER_CHANGE_ALLIANCEID,
         ALLIANCE_MEMBER_CHANGE_PRIVILEGE,
         ALLIANCE_MEMBER_CHANGE_NULL,
         ALLIANCE_MEMBER_CHANGE_NUM,

     };
     public enum ALLIANCE_ANNOUNCEMENT_CHANGE_TYPE
     {
         ALLIANCE_ANNOUNCEMENT_CHANGE_OK,	
         ALLIANCE_ANNOUNCEMENT_CHANGE_ON,
         ALLIANCE_ANNOUNCEMENT_CHANGE_ALLIANCEID,
         ALLIANCE_ANNOUNCEMENT_CHANGE_PRIVILEGE,
     };
     public enum ALLIANCE_CONTRIBUTION_TYPE
     {
         ALLIANCE_CONTRIBUTION_OK,	
         ALLIANCE_CONTRIBUTION_ON,
         ALLIANCE_CONTRIBUTION_ALLIANCEID,
         ALLIANCE_CONTRIBUTION_GOLD,
         ALLIANCE_CONTRIBUTION_ITME,
         ALLIANCE_CONTRIBUTION_NULL,
         ALLIANCE_CONTRIBUTION_GOLD_NUM,
         ALLIANCE_CONTRIBUTION_ITEM_NUM,
     };
     public enum ALLIANCE_SHOP_VIEW_TYPE
     {
         ALLIANCE_SHOP_VIEW_OK,	
         ALLIANCE_SHOP_VIEW_ON,
         ALLIANCE_SHOP_VIEW_GOLD,
     };
     public enum ALLIANCE_SHOP_BUY_TYPE
     {
         ALLIANCE_SHOP_BUY_OK,	
         ALLIANCE_SHOP_BUY_ON,
         ALLIANCE_SHOP_BUY_ALLIANCEID,
         ALLIANCE_SHOP_BUY_CONTRIBUTION,
         ALLIANCE_SHOP_BUY_LV,
         ALLIANCE_SHOP_BUY_NULL,
         ALLIANCE_SHOP_BUY_NUM,
         ALLIANCE_SHOP_BUY_ID,
     };
     public enum ALLIANCE_CITYWAR_TYPE
     {
         ALLIANCE_CITYWAR_WIN = 1,
         ALLIANCE_CITYWAR_LOST = 3,
         ALLIANCE_CITYWAR_SHIELD = 3,
     };
     public enum FIGHT_ALLIANCE_CITYWAR_YPE
     {
         FIGHT_ALLIANCE_CITYWAR_WIN,	
         FIGHT_ALLIANCE_CITYWAR_LOST,
         FIGHT_ALLIANCE_CITYWAR_ALLIANCEID,
         FIGHT_ALLIANCE_CITYWAR_ID,
         FIGHT_ALLIANCE_CITYWAR_POS,
         FIGHT_ALLIANCE_CITYWAR_NUM,
         FIGHT_ALLIANCE_CITYWAR_MY_NUM,
         FIGHT_ALLIANCE_CITYWAR_MY_ALLIANCE,//自己联盟
         FIGHT_ALLIANCE_CITYWAR_MY_FIGHTPOWER,//战斗力太低不能打
         FIGHT_ALLIANCE_CITYWAR_TIME,//休整时期
     };
     public enum ALLIANCE_CITYWAR_VIEW_YPE
     {
         ALLIANCE_CITYWAR_VIEW_OK,	
         ALLIANCE_CITYWAR_VIEW_ON,
         ALLIANCE_CITYWAR_VIEW_ALLIANCEID,
     };
     public enum ALLIANCE_CITYWAR_FIGHT_SHIELD_YPE
     {
         ALLIANCE_CITYWAR_FIGHT_SHIELD_OK,
         ALLIANCE_CITYWAR_FIGHT_SHIELD_ON,
         ALLIANCE_CITYWAR_FIGHT_SHIELD_ALLIANCEID,
         ALLIANCE_CITYWAR_FIGHT_SHIELD_NUM,
         ALLIANCE_CITYWAR_FIGHT_SHIELD_CITYWARID,
         ALLIANCE_CITYWAR_FIGHT_SHIELD_ID,
         ALLIANCE_CITYWAR_FIGHT_SHIELD_MY_NUM,
         ALLIANCE_CITYWAR_FIGHT_SHIELD_REPEAT,//重复防守
         ALLIANCE_CITYWAR_FIGHT_SHIELD_NULL,//配置错误
     };
     public enum ALLIANCE_AUCTION_SHOP_VIEW_TYPE
     {
         ALLIANCE_AUCTION_SHOP_VIEW_OK,
         ALLIANCE_AUCTION_SHOP_VIEW_ON,
         ALLIANCE_AUCTION_SHOP_VIEW_ALLIANCEID,
         ALLIANCE_AUCTION_SHOP_VIEW_ITEM,
         ALLIANCE_AUCTION_SHOP_VIEW_VALUE,
         ALLIANCE_AUCTION_SHOP_VIEW_CONTRIBUTION,
     };
     public enum ALLIANCE_AUCTION_SHOP_BUY_TYPE
     {
         ALLIANCE_AUCTION_SHOP_BUY_OK,	
         ALLIANCE_AUCTION_SHOP_BUY_ON,
         ALLIANCE_AUCTION_SHOP_BUY_ALLIANCEID,
         ALLIANCE_AUCTION_SHOP_BUY_VALUE,//加价太少
         ALLIANCE_AUCTION_SHOP_BUY_CONTRIBUTION,//贡献不够
     };
     public enum ALLIANCE_CITYWAR_POS_VIEW_TYPE
     {
         ALLIANCE_CITYWAR_POS_VIEW_OK,	
         ALLIANCE_CITYWAR_POS_VIEW_ON,
         ALLIANCE_CITYWAR_POS_VIEW_ALLIANCEID,
         ALLIANCE_CITYWAR_POS_VIEW_ID,
     };
     public enum ALLIANCE_CITYWAR_FIND_TYPE
     {
         ALLIANCE_CITYWAR_FIND_OK,	
         ALLIANCE_CITYWAR_FIND_ON,
         ALLIANCE_CITYWAR_FIND_ALLIANCEID,
         ALLIANCE_CITYWAR_FIND_ID,
     };
     //解散联盟
    public enum ALLIANCE_DISSOLVE_TYPE
     {
         ALLIANCE_DISSOLVE_OK,	//成功
         ALLIANCE_DISSOLVE_ON,//失败
         ALLIANCE_DISSOLVE_ALLIANCEID,//联盟错误
         ALLIANCE_DISSOLVE_PRIVILEGE,//权限不对
     };
        /// <summary>
        /// 场景编号
        /// </summary>
        public enum SCENE
        {
            GameLogin = 0,//登陆场景
            GameHall,//主城场景
            GameFight,//战斗场景
        }

    }
}