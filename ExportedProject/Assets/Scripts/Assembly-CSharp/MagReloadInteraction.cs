using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000307")]
public class MagReloadInteraction : ReloadInteraction
{
	[Token(Token = "0x2000308")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593324", Offset = "0x593324")]
	private sealed class _003CLocalInit_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40010C9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40010CA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40010CB")]
		[FieldOffset(Offset = "0x20")]
		public MagReloadInteraction _003C_003E4__this;

		[Token(Token = "0x170002B1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001293")]
			[Address(RVA = "0x8C58A4", Offset = "0x8C58A4", VA = "0x8C58A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002B2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001295")]
			[Address(RVA = "0x8C58EC", Offset = "0x8C58EC", VA = "0x8C58EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001290")]
		[Address(RVA = "0x8C55CC", Offset = "0x8C55CC", VA = "0x8C55CC")]
		[DebuggerHidden]
		public _003CLocalInit_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001291")]
		[Address(RVA = "0x8C55F8", Offset = "0x8C55F8", VA = "0x8C55F8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001292")]
		[Address(RVA = "0x8C55FC", Offset = "0x8C55FC", VA = "0x8C55FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001294")]
		[Address(RVA = "0x8C58AC", Offset = "0x8C58AC", VA = "0x8C58AC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000309")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593334", Offset = "0x593334")]
	private sealed class _003CExecute_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40010CC")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40010CD")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40010CE")]
		[FieldOffset(Offset = "0x20")]
		public MagReloadInteraction _003C_003E4__this;

		[Token(Token = "0x40010CF")]
		[FieldOffset(Offset = "0x28")]
		private bool _003CcorrectInput1_003E5__2;

		[Token(Token = "0x40010D0")]
		[FieldOffset(Offset = "0x29")]
		private bool _003CcorrectInput2_003E5__3;

		[Token(Token = "0x40010D1")]
		[FieldOffset(Offset = "0x2A")]
		private bool _003Ccompleted_003E5__4;

		[Token(Token = "0x40010D2")]
		[FieldOffset(Offset = "0x2C")]
		private int _003Ci_003E5__5;

		[Token(Token = "0x40010D3")]
		[FieldOffset(Offset = "0x30")]
		private ReloadArrowData _003CcurrentArrow_003E5__6;

		[Token(Token = "0x40010D4")]
		[FieldOffset(Offset = "0x38")]
		private float _003CrevealTime_003E5__7;

		[Token(Token = "0x40010D5")]
		[FieldOffset(Offset = "0x3C")]
		private float _003CfadeUpTime_003E5__8;

		[Token(Token = "0x40010D6")]
		[FieldOffset(Offset = "0x40")]
		private float _003CslowMoStartTime_003E5__9;

		[Token(Token = "0x40010D7")]
		[FieldOffset(Offset = "0x44")]
		private float _003CslowMoEndTime_003E5__10;

		[Token(Token = "0x40010D8")]
		[FieldOffset(Offset = "0x48")]
		private bool _003ChasFadedUp_003E5__11;

		[Token(Token = "0x170002B3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001299")]
			[Address(RVA = "0x8C557C", Offset = "0x8C557C", VA = "0x8C557C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002B4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600129B")]
			[Address(RVA = "0x8C55C4", Offset = "0x8C55C4", VA = "0x8C55C4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001296")]
		[Address(RVA = "0x8C49B8", Offset = "0x8C49B8", VA = "0x8C49B8")]
		[DebuggerHidden]
		public _003CExecute_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001297")]
		[Address(RVA = "0x8C49E4", Offset = "0x8C49E4", VA = "0x8C49E4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001298")]
		[Address(RVA = "0x8C49E8", Offset = "0x8C49E8", VA = "0x8C49E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600129A")]
		[Address(RVA = "0x8C5584", Offset = "0x8C5584", VA = "0x8C5584", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200030A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593344", Offset = "0x593344")]
	private sealed class _003CShowCompletion_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40010D9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40010DA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40010DB")]
		[FieldOffset(Offset = "0x20")]
		public ReloadArrowData arrow;

		[Token(Token = "0x40010DC")]
		[FieldOffset(Offset = "0x28")]
		public bool success;

		[Token(Token = "0x40010DD")]
		[FieldOffset(Offset = "0x30")]
		public MagReloadInteraction _003C_003E4__this;

		[Token(Token = "0x40010DE")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 _003CstoredScale_003E5__2;

		[Token(Token = "0x40010DF")]
		[FieldOffset(Offset = "0x44")]
		private Color _003CtargetColour_003E5__3;

		[Token(Token = "0x170002B5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600129F")]
			[Address(RVA = "0x8C5C28", Offset = "0x8C5C28", VA = "0x8C5C28", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002B6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60012A1")]
			[Address(RVA = "0x8C5C70", Offset = "0x8C5C70", VA = "0x8C5C70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600129C")]
		[Address(RVA = "0x8C58F4", Offset = "0x8C58F4", VA = "0x8C58F4")]
		[DebuggerHidden]
		public _003CShowCompletion_003Ed__31(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600129D")]
		[Address(RVA = "0x8C5920", Offset = "0x8C5920", VA = "0x8C5920", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600129E")]
		[Address(RVA = "0x8C5924", Offset = "0x8C5924", VA = "0x8C5924", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60012A0")]
		[Address(RVA = "0x8C5C30", Offset = "0x8C5C30", VA = "0x8C5C30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40010B4")]
	[FieldOffset(Offset = "0xDC")]
	public Vector2 InputFilter;

	[Token(Token = "0x40010B5")]
	[FieldOffset(Offset = "0xE4")]
	public float GestureAcceptanceAngle;

	[Token(Token = "0x40010B6")]
	[FieldOffset(Offset = "0xE8")]
	public float MinimalDragLength;

	[Token(Token = "0x40010B7")]
	[FieldOffset(Offset = "0xEC")]
	public float MinimalDragFailureLength;

	[Token(Token = "0x40010B8")]
	[FieldOffset(Offset = "0xF0")]
	public bool DoBackAndForth;

	[Token(Token = "0x40010B9")]
	[FieldOffset(Offset = "0xF8")]
	public ReloadArrowData Arrow1;

	[Token(Token = "0x40010BA")]
	[FieldOffset(Offset = "0x100")]
	public ReloadArrowData Arrow2;

	[Token(Token = "0x40010BB")]
	[FieldOffset(Offset = "0x108")]
	public string NormalArrowSpriteName;

	[Token(Token = "0x40010BC")]
	[FieldOffset(Offset = "0x110")]
	public string FinishArrowSpriteName;

	[Token(Token = "0x40010BD")]
	[FieldOffset(Offset = "0x118")]
	private bool _autoComplete;

	[Token(Token = "0x40010BE")]
	[FieldOffset(Offset = "0x120")]
	private UIWidget[] _arrows;

	[Token(Token = "0x40010BF")]
	[FieldOffset(Offset = "0x128")]
	private UIPanel _panel;

	[Token(Token = "0x40010C0")]
	[FieldOffset(Offset = "0x130")]
	private bool _completionRoutineStarted;

	[Token(Token = "0x40010C1")]
	[FieldOffset(Offset = "0x131")]
	private bool _interactionFinished;

	[Token(Token = "0x40010C2")]
	[FieldOffset(Offset = "0x134")]
	private Vector2 _cumulativeDrag;

	[Token(Token = "0x40010C3")]
	[FieldOffset(Offset = "0x0")]
	private static Color IndicatorWarningColor;

	[Token(Token = "0x40010C4")]
	[FieldOffset(Offset = "0x10")]
	private static Color IndicatorColor;

	[Token(Token = "0x40010C5")]
	[FieldOffset(Offset = "0x20")]
	private static Color IndicatorSuccessColor;

	[Token(Token = "0x40010C6")]
	[FieldOffset(Offset = "0x30")]
	private static Color IndicatorFailureColor;

	[Token(Token = "0x40010C7")]
	[FieldOffset(Offset = "0x40")]
	private static float SlowMoTimeScalar;

	[Token(Token = "0x14000050")]
	public event EventHandler OnReloadFailed
	{
		[Token(Token = "0x6001282")]
		[Address(RVA = "0x9AB4FC", Offset = "0x9AB4FC", VA = "0x9AB4FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616344", Offset = "0x616344")]
		add
		{
		}
		[Token(Token = "0x6001283")]
		[Address(RVA = "0x9AB5A0", Offset = "0x9AB5A0", VA = "0x9AB5A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616354", Offset = "0x616354")]
		remove
		{
		}
	}

	[Token(Token = "0x6001284")]
	[Address(RVA = "0x9AB644", Offset = "0x9AB644", VA = "0x9AB644", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6001285")]
	[Address(RVA = "0x9AB674", Offset = "0x9AB674", VA = "0x9AB674")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x616364", Offset = "0x616364")]
	protected IEnumerator LocalInit()
	{
		return null;
	}

	[Token(Token = "0x6001286")]
	[Address(RVA = "0x9AB6E0", Offset = "0x9AB6E0", VA = "0x9AB6E0", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6001287")]
	[Address(RVA = "0x9AB718", Offset = "0x9AB718", VA = "0x9AB718", Slot = "15")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001288")]
	[Address(RVA = "0x9ABAB0", Offset = "0x9ABAB0", VA = "0x9ABAB0", Slot = "16")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6163C4", Offset = "0x6163C4")]
	public override IEnumerator Execute()
	{
		return null;
	}

	[Token(Token = "0x6001289")]
	[Address(RVA = "0x9ABB1C", Offset = "0x9ABB1C", VA = "0x9ABB1C")]
	private bool HasAutoCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x600128A")]
	[Address(RVA = "0x9ABB24", Offset = "0x9ABB24", VA = "0x9ABB24", Slot = "19")]
	public override void OnGestureDrag(FingerInput.FingerID finger, Vector2 drag)
	{
	}

	[Token(Token = "0x600128B")]
	[Address(RVA = "0x9ABB3C", Offset = "0x9ABB3C", VA = "0x9ABB3C", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x600128C")]
	[Address(RVA = "0x9ABCF0", Offset = "0x9ABCF0", VA = "0x9ABCF0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x616424", Offset = "0x616424")]
	private IEnumerator ShowCompletion(ReloadArrowData arrow, bool success)
	{
		return null;
	}

	[Token(Token = "0x600128D")]
	[Address(RVA = "0x9ABD78", Offset = "0x9ABD78", VA = "0x9ABD78", Slot = "17")]
	public override void AutoComplete()
	{
	}

	[Token(Token = "0x600128E")]
	[Address(RVA = "0x9ABD84", Offset = "0x9ABD84", VA = "0x9ABD84")]
	public MagReloadInteraction()
	{
	}
}
