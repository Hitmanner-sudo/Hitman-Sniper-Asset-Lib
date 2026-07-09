using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000270")]
public class RewardActionConfig : BaseConfig<RewardActionConfig>
{
	[Serializable]
	[Token(Token = "0x2000271")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592E8C", Offset = "0x592E8C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000D96")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000D97")]
		[FieldOffset(Offset = "0x8")]
		public static Func<RewardActionBase, int> _003C_003E9__9_4;

		[Token(Token = "0x4000D98")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<RewardActionBase> _003C_003E9__11_0;

		[Token(Token = "0x4000D99")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<RewardKillType> _003C_003E9__11_1;

		[Token(Token = "0x4000D9A")]
		[FieldOffset(Offset = "0x20")]
		public static Predicate<RewardScoreChangedAction> _003C_003E9__11_2;

		[Token(Token = "0x4000D9B")]
		[FieldOffset(Offset = "0x28")]
		public static Predicate<RewardMessageReceivedAction> _003C_003E9__11_3;

		[Token(Token = "0x4000D9C")]
		[FieldOffset(Offset = "0x30")]
		public static Predicate<RewardCustomScore> _003C_003E9__11_4;

		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0x8B4720", Offset = "0x8B4720", VA = "0x8B4720")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000EC7")]
		[Address(RVA = "0x8B4728", Offset = "0x8B4728", VA = "0x8B4728")]
		internal int _003COnEnable_003Eb__9_4(RewardActionBase o)
		{
			return default(int);
		}

		[Token(Token = "0x6000EC8")]
		[Address(RVA = "0x8B4740", Offset = "0x8B4740", VA = "0x8B4740")]
		internal bool _003CRemoveInvalidAction_003Eb__11_0(RewardActionBase o)
		{
			return default(bool);
		}

		[Token(Token = "0x6000EC9")]
		[Address(RVA = "0x8B47BC", Offset = "0x8B47BC", VA = "0x8B47BC")]
		internal bool _003CRemoveInvalidAction_003Eb__11_1(RewardKillType o)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ECA")]
		[Address(RVA = "0x8B4838", Offset = "0x8B4838", VA = "0x8B4838")]
		internal bool _003CRemoveInvalidAction_003Eb__11_2(RewardScoreChangedAction o)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ECB")]
		[Address(RVA = "0x8B48B4", Offset = "0x8B48B4", VA = "0x8B48B4")]
		internal bool _003CRemoveInvalidAction_003Eb__11_3(RewardMessageReceivedAction o)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ECC")]
		[Address(RVA = "0x8B4930", Offset = "0x8B4930", VA = "0x8B4930")]
		internal bool _003CRemoveInvalidAction_003Eb__11_4(RewardCustomScore o)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000D91")]
	[FieldOffset(Offset = "0x30")]
	public List<RewardKillType> KillTypeActions;

	[Token(Token = "0x4000D92")]
	[FieldOffset(Offset = "0x38")]
	public List<RewardScoreChangedAction> ScoreChangedActions;

	[Token(Token = "0x4000D93")]
	[FieldOffset(Offset = "0x40")]
	public List<RewardMessageReceivedAction> MessageReceivedActions;

	[Token(Token = "0x4000D94")]
	[FieldOffset(Offset = "0x48")]
	public List<RewardCustomScore> CustomScoreActions;

	[Token(Token = "0x4000D95")]
	[FieldOffset(Offset = "0x50")]
	private List<RewardActionBase> _actions;

	[Token(Token = "0x17000255")]
	public List<RewardActionBase> RewardActionList
	{
		[Token(Token = "0x6000EB8")]
		[Address(RVA = "0x969BD0", Offset = "0x969BD0", VA = "0x969BD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000256")]
	public int ActionsCount
	{
		[Token(Token = "0x6000EBE")]
		[Address(RVA = "0x96A28C", Offset = "0x96A28C", VA = "0x96A28C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000257")]
	public string DebugInfo
	{
		[Token(Token = "0x6000EBF")]
		[Address(RVA = "0x96A764", Offset = "0x96A764", VA = "0x96A764")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000EB9")]
	[Address(RVA = "0x969BD8", Offset = "0x969BD8", VA = "0x969BD8")]
	public void OnGameStarted()
	{
	}

	[Token(Token = "0x6000EBA")]
	[Address(RVA = "0x969C94", Offset = "0x969C94", VA = "0x969C94")]
	public void OnGameEnded()
	{
	}

	[Token(Token = "0x6000EBB")]
	[Address(RVA = "0x969D40", Offset = "0x969D40", VA = "0x969D40")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000EBC")]
	[Address(RVA = "0x96A1FC", Offset = "0x96A1FC", VA = "0x96A1FC")]
	public RewardActionBase GetActionByDisplayID(int id)
	{
		return null;
	}

	[Token(Token = "0x6000EBD")]
	[Address(RVA = "0x96A2D8", Offset = "0x96A2D8", VA = "0x96A2D8")]
	public void RemoveInvalidAction()
	{
	}

	[Token(Token = "0x6000EC0")]
	[Address(RVA = "0x96A860", Offset = "0x96A860", VA = "0x96A860")]
	public RewardActionConfig()
	{
	}

	[Token(Token = "0x6000EC1")]
	[Address(RVA = "0x96A8D8", Offset = "0x96A8D8", VA = "0x96A8D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6151E4", Offset = "0x6151E4")]
	private void _003COnEnable_003Eb__9_0(RewardKillType o)
	{
	}

	[Token(Token = "0x6000EC2")]
	[Address(RVA = "0x96A93C", Offset = "0x96A93C", VA = "0x96A93C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6151F4", Offset = "0x6151F4")]
	private void _003COnEnable_003Eb__9_1(RewardScoreChangedAction o)
	{
	}

	[Token(Token = "0x6000EC3")]
	[Address(RVA = "0x96A9A0", Offset = "0x96A9A0", VA = "0x96A9A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615204", Offset = "0x615204")]
	private void _003COnEnable_003Eb__9_2(RewardMessageReceivedAction o)
	{
	}

	[Token(Token = "0x6000EC4")]
	[Address(RVA = "0x96AA04", Offset = "0x96AA04", VA = "0x96AA04")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615214", Offset = "0x615214")]
	private void _003COnEnable_003Eb__9_3(RewardCustomScore o)
	{
	}
}
