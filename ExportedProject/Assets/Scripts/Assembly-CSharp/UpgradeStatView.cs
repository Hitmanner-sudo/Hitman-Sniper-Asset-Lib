using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000772")]
public class UpgradeStatView : View
{
	[Token(Token = "0x2000773")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596058", Offset = "0x596058")]
	private sealed class _003CSetBarLevel_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002A26")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002A27")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002A28")]
		[FieldOffset(Offset = "0x20")]
		public UpgradeStatView _003C_003E4__this;

		[Token(Token = "0x4002A29")]
		[FieldOffset(Offset = "0x28")]
		public int maxLevel;

		[Token(Token = "0x4002A2A")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget barBackground;

		[Token(Token = "0x4002A2B")]
		[FieldOffset(Offset = "0x38")]
		public UISprite barItemPrefab;

		[Token(Token = "0x4002A2C")]
		[FieldOffset(Offset = "0x40")]
		public Transform barHolder;

		[Token(Token = "0x4002A2D")]
		[FieldOffset(Offset = "0x48")]
		public int level;

		[Token(Token = "0x17000655")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600318B")]
			[Address(RVA = "0xA402A8", Offset = "0xA402A8", VA = "0xA402A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000656")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600318D")]
			[Address(RVA = "0xA402F0", Offset = "0xA402F0", VA = "0xA402F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003188")]
		[Address(RVA = "0xA3FEFC", Offset = "0xA3FEFC", VA = "0xA3FEFC")]
		[DebuggerHidden]
		public _003CSetBarLevel_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003189")]
		[Address(RVA = "0xA3FF28", Offset = "0xA3FF28", VA = "0xA3FF28", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600318A")]
		[Address(RVA = "0xA3FF2C", Offset = "0xA3FF2C", VA = "0xA3FF2C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600318C")]
		[Address(RVA = "0xA402B0", Offset = "0xA402B0", VA = "0xA402B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4002A1A")]
	[FieldOffset(Offset = "0x60")]
	public UILabel BarTitle;

	[Token(Token = "0x4002A1B")]
	[FieldOffset(Offset = "0x68")]
	public UILabel CurrentCost;

	[Token(Token = "0x4002A1C")]
	[FieldOffset(Offset = "0x70")]
	public UIWidget BarBackground;

	[Token(Token = "0x4002A1D")]
	[FieldOffset(Offset = "0x78")]
	public UISprite PlusButtonBackground;

	[Token(Token = "0x4002A1E")]
	[FieldOffset(Offset = "0x80")]
	public BlinkButtonHandler PlusButtonHandler;

	[Token(Token = "0x4002A1F")]
	[FieldOffset(Offset = "0x88")]
	public UISprite RankBarItemPrefab;

	[Token(Token = "0x4002A20")]
	[FieldOffset(Offset = "0x90")]
	public Transform BarHolder;

	[NonSerialized]
	[Token(Token = "0x4002A21")]
	[FieldOffset(Offset = "0x98")]
	public int DataGrade;

	[Token(Token = "0x4002A22")]
	[FieldOffset(Offset = "0xA0")]
	private ChallengeData _challengeData;

	[Token(Token = "0x4002A23")]
	[FieldOffset(Offset = "0xA8")]
	private List<UISprite> _barItemSprites;

	[Token(Token = "0x4002A24")]
	private const float SPACE_PER_BAR = 15f;

	[Token(Token = "0x4002A25")]
	private const float BAR_Y_POS = -5f;

	[Token(Token = "0x600317D")]
	[Address(RVA = "0xB9F31C", Offset = "0xB9F31C", VA = "0xB9F31C", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600317E")]
	[Address(RVA = "0xB9F4F4", Offset = "0xB9F4F4", VA = "0xB9F4F4")]
	public void SetStatView(UpgradeStatModel statModel, string title, GameObject statsBackground)
	{
	}

	[Token(Token = "0x600317F")]
	[Address(RVA = "0xB9F5B4", Offset = "0xB9F5B4", VA = "0xB9F5B4", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6003180")]
	[Address(RVA = "0xB9F740", Offset = "0xB9F740", VA = "0xB9F740")]
	private void OnCurrentCostChanged(int cost)
	{
	}

	[Token(Token = "0x6003181")]
	[Address(RVA = "0xB9F890", Offset = "0xB9F890", VA = "0xB9F890", Slot = "15")]
	public virtual void OnCurrentLevelChanged(int currentLevel)
	{
	}

	[Token(Token = "0x6003182")]
	[Address(RVA = "0xB9F448", Offset = "0xB9F448", VA = "0xB9F448")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6003183")]
	[Address(RVA = "0xB9F9F0", Offset = "0xB9F9F0", VA = "0xB9F9F0", Slot = "16")]
	public virtual void UpdateButtons()
	{
	}

	[Token(Token = "0x6003184")]
	[Address(RVA = "0xB9FB9C", Offset = "0xB9FB9C", VA = "0xB9FB9C")]
	public void SetPlusButtonActive(int currentLevel, int checkLevel)
	{
	}

	[Token(Token = "0x6003185")]
	[Address(RVA = "0xB9FEC4", Offset = "0xB9FEC4", VA = "0xB9FEC4")]
	public void SetDataGradeVar(ref int GradeVar)
	{
	}

	[Token(Token = "0x6003186")]
	[Address(RVA = "0xB9F948", Offset = "0xB9F948", VA = "0xB9F948")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x622170", Offset = "0x622170")]
	private IEnumerator SetBarLevel(int level, int maxLevel, UIWidget barBackground, Transform barHolder, UISprite barItemPrefab)
	{
		return null;
	}

	[Token(Token = "0x6003187")]
	[Address(RVA = "0xB9FED0", Offset = "0xB9FED0", VA = "0xB9FED0")]
	public UpgradeStatView()
	{
	}
}
