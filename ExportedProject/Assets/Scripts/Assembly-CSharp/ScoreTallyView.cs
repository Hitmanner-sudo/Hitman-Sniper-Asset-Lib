using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using Technology.Security;
using UnityEngine;

[Token(Token = "0x20006C8")]
public class ScoreTallyView : View
{
	[Token(Token = "0x20006C9")]
	public enum TallyItem
	{
		[Token(Token = "0x4002642")]
		None = 0,
		[Token(Token = "0x4002643")]
		EnemyKill = 1,
		[Token(Token = "0x4002644")]
		ConclaveKill = 2,
		[Token(Token = "0x4002645")]
		HeadshotChain = 3,
		[Token(Token = "0x4002646")]
		QuickKillChain = 4,
		[Token(Token = "0x4002647")]
		UndetectedChain = 5,
		[Token(Token = "0x4002648")]
		OneShotKill = 6,
		[Token(Token = "0x4002649")]
		MovingTarget = 7,
		[Token(Token = "0x400264A")]
		BodyDisposal = 8,
		[Token(Token = "0x400264B")]
		AccidentKill = 9,
		[Token(Token = "0x400264C")]
		MultipleKill = 10,
		[Token(Token = "0x400264D")]
		Lured = 11,
		[Token(Token = "0x400264E")]
		ScenarioTriggered = 12,
		[Token(Token = "0x400264F")]
		ExplosiveKill = 13,
		[Token(Token = "0x4002650")]
		MinimumZoomAndLongShots = 14,
		[Token(Token = "0x4002651")]
		NoHoldBreath = 15,
		[Token(Token = "0x4002652")]
		XRayKill = 16,
		[Token(Token = "0x4002653")]
		CurrencyOnKill = 17,
		[Token(Token = "0x4002654")]
		ChallengeTokenBonus = 18,
		[Token(Token = "0x4002655")]
		TankKill = 19,
		[Token(Token = "0x4002656")]
		HunterKill = 20,
		[Token(Token = "0x4002657")]
		ScreamerKill = 21,
		[Token(Token = "0x4002658")]
		ScaredKill = 22,
		[Token(Token = "0x4002659")]
		ChallengeTokenOnKill = 23
	}

	[Token(Token = "0x20006CA")]
	protected class ScoreItem
	{
		[Token(Token = "0x400265A")]
		[FieldOffset(Offset = "0x10")]
		public TallyItem TallyItem;

		[Token(Token = "0x400265B")]
		[FieldOffset(Offset = "0x18")]
		public string Title;

		[Token(Token = "0x400265C")]
		[FieldOffset(Offset = "0x20")]
		public string Amount;

		[Token(Token = "0x400265D")]
		[FieldOffset(Offset = "0x28")]
		public SecureLocalInt ScoreBonus;

		[Token(Token = "0x400265E")]
		[FieldOffset(Offset = "0x30")]
		public SecureLocalInt CurrencyBonus;

		[Token(Token = "0x400265F")]
		[FieldOffset(Offset = "0x38")]
		public Wallet.Currency CurrencyType;

		[Token(Token = "0x4002660")]
		[FieldOffset(Offset = "0x3C")]
		public bool IsCurrencyBonus;

		[Token(Token = "0x4002661")]
		[FieldOffset(Offset = "0x3D")]
		public bool IsScaredKill;

		[Token(Token = "0x6002CC6")]
		[Address(RVA = "0x8BA500", Offset = "0x8BA500", VA = "0x8BA500")]
		public ScoreItem()
		{
		}
	}

	[Token(Token = "0x20006CB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595B38", Offset = "0x595B38")]
	private sealed class _003Cget_VisibleSections_003Ed__44 : IEnumerable<GameObject>, IEnumerable, IEnumerator<GameObject>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002662")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002663")]
		[FieldOffset(Offset = "0x18")]
		private GameObject _003C_003E2__current;

		[Token(Token = "0x4002664")]
		[FieldOffset(Offset = "0x20")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x4002665")]
		[FieldOffset(Offset = "0x28")]
		public ScoreTallyView _003C_003E4__this;

		[Token(Token = "0x170005C1")]
		private GameObject System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EGameObject_003E_002ECurrent
		{
			[Token(Token = "0x6002CCA")]
			[Address(RVA = "0x8BA404", Offset = "0x8BA404", VA = "0x8BA404", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005C2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002CCC")]
			[Address(RVA = "0x8BA44C", Offset = "0x8BA44C", VA = "0x8BA44C", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002CC7")]
		[Address(RVA = "0x8BA318", Offset = "0x8BA318", VA = "0x8BA318")]
		[DebuggerHidden]
		public _003Cget_VisibleSections_003Ed__44(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002CC8")]
		[Address(RVA = "0x8BA350", Offset = "0x8BA350", VA = "0x8BA350", Slot = "7")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002CC9")]
		[Address(RVA = "0x8BA354", Offset = "0x8BA354", VA = "0x8BA354", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002CCB")]
		[Address(RVA = "0x8BA40C", Offset = "0x8BA40C", VA = "0x8BA40C", Slot = "10")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002CCD")]
		[Address(RVA = "0x8BA454", Offset = "0x8BA454", VA = "0x8BA454", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GameObject> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EGameObject_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6002CCE")]
		[Address(RVA = "0x8BA4FC", Offset = "0x8BA4FC", VA = "0x8BA4FC", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x20006CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595B48", Offset = "0x595B48")]
	private sealed class _003C_003Ec__DisplayClass56_0
	{
		[Token(Token = "0x4002666")]
		[FieldOffset(Offset = "0x10")]
		public CalenderModel.ScoreItemData scoreItemData;

		[Token(Token = "0x4002667")]
		[FieldOffset(Offset = "0x18")]
		public Predicate<TallyItem> _003C_003E9__0;

		[Token(Token = "0x6002CCF")]
		[Address(RVA = "0x8B8AE8", Offset = "0x8B8AE8", VA = "0x8B8AE8")]
		public _003C_003Ec__DisplayClass56_0()
		{
		}

		[Token(Token = "0x6002CD0")]
		[Address(RVA = "0x8B8AF0", Offset = "0x8B8AF0", VA = "0x8B8AF0")]
		internal bool _003CAddScoreTallyItemIfAwarded_003Eb__0(TallyItem item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20006CD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595B58", Offset = "0x595B58")]
	private sealed class _003C_003Ec__DisplayClass62_0
	{
		[Token(Token = "0x4002668")]
		[FieldOffset(Offset = "0x10")]
		public TallyItem tallyItem;

		[Token(Token = "0x4002669")]
		[FieldOffset(Offset = "0x18")]
		public Predicate<TallyItem> _003C_003E9__0;

		[Token(Token = "0x6002CD1")]
		[Address(RVA = "0x8B8B14", Offset = "0x8B8B14", VA = "0x8B8B14")]
		public _003C_003Ec__DisplayClass62_0()
		{
		}

		[Token(Token = "0x6002CD2")]
		[Address(RVA = "0x8B8B1C", Offset = "0x8B8B1C", VA = "0x8B8B1C")]
		internal bool _003CAddScoreAndCount_003Eb__0(TallyItem item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20006CE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595B68", Offset = "0x595B68")]
	private sealed class _003CFadeOnResults_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400266A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400266B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400266C")]
		[FieldOffset(Offset = "0x20")]
		public ScoreTallyView _003C_003E4__this;

		[Token(Token = "0x400266D")]
		[FieldOffset(Offset = "0x28")]
		private Color _003CbackgroundStartingColor_003E5__2;

		[Token(Token = "0x400266E")]
		[FieldOffset(Offset = "0x38")]
		private Color _003CvignetteStartingColor_003E5__3;

		[Token(Token = "0x400266F")]
		[FieldOffset(Offset = "0x48")]
		private ContinuousTimer _003Ctimer_003E5__4;

		[Token(Token = "0x4002670")]
		[FieldOffset(Offset = "0x50")]
		private Color _003CbackgroundTargetColor_003E5__5;

		[Token(Token = "0x4002671")]
		[FieldOffset(Offset = "0x60")]
		private Color _003CvignetteTargetColor_003E5__6;

		[Token(Token = "0x170005C3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002CD6")]
			[Address(RVA = "0x8B931C", Offset = "0x8B931C", VA = "0x8B931C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005C4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002CD8")]
			[Address(RVA = "0x8B9364", Offset = "0x8B9364", VA = "0x8B9364", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002CD3")]
		[Address(RVA = "0x8B8E5C", Offset = "0x8B8E5C", VA = "0x8B8E5C")]
		[DebuggerHidden]
		public _003CFadeOnResults_003Ed__65(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002CD4")]
		[Address(RVA = "0x8B8E88", Offset = "0x8B8E88", VA = "0x8B8E88", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002CD5")]
		[Address(RVA = "0x8B8E8C", Offset = "0x8B8E8C", VA = "0x8B8E8C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002CD7")]
		[Address(RVA = "0x8B9324", Offset = "0x8B9324", VA = "0x8B9324", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006CF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595B78", Offset = "0x595B78")]
	private sealed class _003C_003Ec__DisplayClass73_0
	{
		[Token(Token = "0x4002672")]
		[FieldOffset(Offset = "0x10")]
		public ScoreTallyView _003C_003E4__this;

		[Token(Token = "0x4002673")]
		[FieldOffset(Offset = "0x18")]
		public PopupManager pm;

		[Token(Token = "0x6002CD9")]
		[Address(RVA = "0x8B8B2C", Offset = "0x8B8B2C", VA = "0x8B8B2C")]
		public _003C_003Ec__DisplayClass73_0()
		{
		}

		[Token(Token = "0x6002CDA")]
		[Address(RVA = "0x8B8B34", Offset = "0x8B8B34", VA = "0x8B8B34")]
		internal void _003CUpdateScoreBonuses_003Eb__1()
		{
		}
	}

	[Token(Token = "0x20006D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595B88", Offset = "0x595B88")]
	private sealed class _003C_003Ec__DisplayClass73_1
	{
		[Token(Token = "0x4002674")]
		[FieldOffset(Offset = "0x10")]
		public Action<bool> onScorePosted;

		[Token(Token = "0x4002675")]
		[FieldOffset(Offset = "0x18")]
		public ContractDataModel level;

		[Token(Token = "0x6002CDB")]
		[Address(RVA = "0x8B8CE0", Offset = "0x8B8CE0", VA = "0x8B8CE0")]
		public _003C_003Ec__DisplayClass73_1()
		{
		}

		[Token(Token = "0x6002CDC")]
		[Address(RVA = "0x8B8CE8", Offset = "0x8B8CE8", VA = "0x8B8CE8")]
		internal void _003CUpdateScoreBonuses_003Eb__0(bool success)
		{
		}
	}

	[Token(Token = "0x20006D1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595B98", Offset = "0x595B98")]
	private sealed class _003CUpdateScoreBonuses_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002676")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002677")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002678")]
		[FieldOffset(Offset = "0x20")]
		public ScoreTallyView _003C_003E4__this;

		[Token(Token = "0x4002679")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass73_0 _003C_003E8__1;

		[Token(Token = "0x400267A")]
		[FieldOffset(Offset = "0x30")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x400267B")]
		[FieldOffset(Offset = "0x34")]
		private int _003Ccount_003E5__3;

		[Token(Token = "0x170005C5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002CE0")]
			[Address(RVA = "0x8BA024", Offset = "0x8BA024", VA = "0x8BA024", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005C6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002CE2")]
			[Address(RVA = "0x8BA06C", Offset = "0x8BA06C", VA = "0x8BA06C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002CDD")]
		[Address(RVA = "0x8B9710", Offset = "0x8B9710", VA = "0x8B9710")]
		[DebuggerHidden]
		public _003CUpdateScoreBonuses_003Ed__73(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002CDE")]
		[Address(RVA = "0x8B973C", Offset = "0x8B973C", VA = "0x8B973C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002CDF")]
		[Address(RVA = "0x8B9740", Offset = "0x8B9740", VA = "0x8B9740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002CE1")]
		[Address(RVA = "0x8BA02C", Offset = "0x8BA02C", VA = "0x8BA02C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006D2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595BA8", Offset = "0x595BA8")]
	private sealed class _003CUpdateMissionSection_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400267C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400267D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400267E")]
		[FieldOffset(Offset = "0x20")]
		public ScoreTallyView _003C_003E4__this;

		[Token(Token = "0x170005C7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002CE6")]
			[Address(RVA = "0x8B94F0", Offset = "0x8B94F0", VA = "0x8B94F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005C8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002CE8")]
			[Address(RVA = "0x8B9538", Offset = "0x8B9538", VA = "0x8B9538", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002CE3")]
		[Address(RVA = "0x8B936C", Offset = "0x8B936C", VA = "0x8B936C")]
		[DebuggerHidden]
		public _003CUpdateMissionSection_003Ed__74(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002CE4")]
		[Address(RVA = "0x8B9398", Offset = "0x8B9398", VA = "0x8B9398", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002CE5")]
		[Address(RVA = "0x8B939C", Offset = "0x8B939C", VA = "0x8B939C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002CE7")]
		[Address(RVA = "0x8B94F8", Offset = "0x8B94F8", VA = "0x8B94F8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006D3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595BB8", Offset = "0x595BB8")]
	private sealed class _003CUpdateRewardSection_003Ed__75 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400267F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002680")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002681")]
		[FieldOffset(Offset = "0x20")]
		public ScoreTallyView _003C_003E4__this;

		[Token(Token = "0x170005C9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002CEC")]
			[Address(RVA = "0x8B96C0", Offset = "0x8B96C0", VA = "0x8B96C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005CA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002CEE")]
			[Address(RVA = "0x8B9708", Offset = "0x8B9708", VA = "0x8B9708", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002CE9")]
		[Address(RVA = "0x8B9540", Offset = "0x8B9540", VA = "0x8B9540")]
		[DebuggerHidden]
		public _003CUpdateRewardSection_003Ed__75(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002CEA")]
		[Address(RVA = "0x8B956C", Offset = "0x8B956C", VA = "0x8B956C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002CEB")]
		[Address(RVA = "0x8B9570", Offset = "0x8B9570", VA = "0x8B9570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002CED")]
		[Address(RVA = "0x8B96C8", Offset = "0x8B96C8", VA = "0x8B96C8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595BC8", Offset = "0x595BC8")]
	private sealed class _003CUpdateShare_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002682")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002683")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002684")]
		[FieldOffset(Offset = "0x20")]
		public ScoreTallyView _003C_003E4__this;

		[Token(Token = "0x170005CB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002CF2")]
			[Address(RVA = "0x8BA2C8", Offset = "0x8BA2C8", VA = "0x8BA2C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005CC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002CF4")]
			[Address(RVA = "0x8BA310", Offset = "0x8BA310", VA = "0x8BA310", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002CEF")]
		[Address(RVA = "0x8BA074", Offset = "0x8BA074", VA = "0x8BA074")]
		[DebuggerHidden]
		public _003CUpdateShare_003Ed__76(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002CF0")]
		[Address(RVA = "0x8BA0A0", Offset = "0x8BA0A0", VA = "0x8BA0A0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002CF1")]
		[Address(RVA = "0x8BA0A4", Offset = "0x8BA0A4", VA = "0x8BA0A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002CF3")]
		[Address(RVA = "0x8BA2D0", Offset = "0x8BA2D0", VA = "0x8BA2D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400261B")]
	[FieldOffset(Offset = "0x60")]
	public UITexture Vignette;

	[Token(Token = "0x400261C")]
	[FieldOffset(Offset = "0x68")]
	public UISprite Background;

	[Token(Token = "0x400261D")]
	[FieldOffset(Offset = "0x70")]
	public UILabel TotalScore;

	[Token(Token = "0x400261E")]
	[FieldOffset(Offset = "0x78")]
	public GameObject ScoreBonusesSection;

	[Token(Token = "0x400261F")]
	[FieldOffset(Offset = "0x80")]
	public GameObject MissionSection;

	[Token(Token = "0x4002620")]
	[FieldOffset(Offset = "0x88")]
	public GameObject RewardSection;

	[Token(Token = "0x4002621")]
	[FieldOffset(Offset = "0x90")]
	public GameObject ShareSection;

	[Token(Token = "0x4002622")]
	[FieldOffset(Offset = "0x98")]
	public Transform MainSection;

	[Token(Token = "0x4002623")]
	[FieldOffset(Offset = "0xA0")]
	public ButtonHandler RestartButton;

	[Token(Token = "0x4002624")]
	[FieldOffset(Offset = "0xA8")]
	public ButtonHandler ContinueButton;

	[Token(Token = "0x4002625")]
	[FieldOffset(Offset = "0xB0")]
	public ButtonHandler ShareButton;

	[Token(Token = "0x4002626")]
	[FieldOffset(Offset = "0xB8")]
	public PopupShareScore SharePopupPrefab;

	[Token(Token = "0x4002627")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject FeedbackButtonGO;

	[Token(Token = "0x4002628")]
	[FieldOffset(Offset = "0xC8")]
	public UIGrid TallyScoreGrid;

	[Token(Token = "0x4002629")]
	[FieldOffset(Offset = "0xD0")]
	public TallyScoreItem TallyScoreItemPrefab;

	[Token(Token = "0x400262A")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject ScoreBonusAnchorContainer;

	[Token(Token = "0x400262B")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject PrimaryMissionViewPrefab;

	[Token(Token = "0x400262C")]
	[FieldOffset(Offset = "0xE8")]
	public ScoreTallyRewardView ScoreTallyRewardViewPrefab;

	[Token(Token = "0x400262D")]
	[FieldOffset(Offset = "0xF0")]
	private GameObject _currentPage;

	[Token(Token = "0x400262E")]
	[FieldOffset(Offset = "0xF8")]
	private GameObject[] _pages;

	[Token(Token = "0x400262F")]
	[FieldOffset(Offset = "0x100")]
	protected bool CanAdvancePage;

	[Token(Token = "0x4002630")]
	[FieldOffset(Offset = "0x104")]
	private int _currentPageIndex;

	[Token(Token = "0x4002631")]
	[FieldOffset(Offset = "0x108")]
	protected GameObject PrimaryMissionViewPrefabInstance;

	[Token(Token = "0x4002632")]
	[FieldOffset(Offset = "0x110")]
	private bool _isSpeedUp;

	[Token(Token = "0x4002633")]
	[FieldOffset(Offset = "0x118")]
	private SecureLocalInt _currentScore;

	[Token(Token = "0x4002634")]
	[FieldOffset(Offset = "0x120")]
	private int _finalScore;

	[Token(Token = "0x4002635")]
	[FieldOffset(Offset = "0x124")]
	private bool _canSpeedUp;

	[Token(Token = "0x4002636")]
	[FieldOffset(Offset = "0x128")]
	private float _timeInCurrentPage;

	[Token(Token = "0x4002637")]
	[FieldOffset(Offset = "0x12C")]
	private bool _finishedAnimation;

	[Token(Token = "0x4002638")]
	[FieldOffset(Offset = "0x130")]
	private PlayingSoundContainer _currentSound;

	[Token(Token = "0x4002639")]
	[FieldOffset(Offset = "0x138")]
	private readonly List<ScoreItem> _scoreItemList;

	[Token(Token = "0x400263A")]
	[FieldOffset(Offset = "0x140")]
	private bool _restartButtonActive;

	[Token(Token = "0x400263B")]
	private const float SPEED_UP_RATE = 10f;

	[Token(Token = "0x400263C")]
	private const float NORMAL_UP_RATE = 1f;

	[Token(Token = "0x400263D")]
	private const float TIME_BETWEEN_SECTION = 0.3f;

	[Token(Token = "0x400263E")]
	private const float TIME_IN_SCORE_SECTION = 1.5f;

	[Token(Token = "0x400263F")]
	protected const float TIME_IN_MISSION_SECTION = 1f;

	[Token(Token = "0x4002640")]
	private const float MIN_TIME_PER_PAGE = 0.2f;

	[Token(Token = "0x170005BE")]
	public float TimeMultiplier
	{
		[Token(Token = "0x6002C9C")]
		[Address(RVA = "0xB619A4", Offset = "0xB619A4", VA = "0xB619A4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005BF")]
	private float DeltaTime
	{
		[Token(Token = "0x6002C9D")]
		[Address(RVA = "0xB619C0", Offset = "0xB619C0", VA = "0xB619C0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005C0")]
	protected virtual IEnumerable<GameObject> VisibleSections
	{
		[Token(Token = "0x6002C9E")]
		[Address(RVA = "0xB61A90", Offset = "0xB61A90", VA = "0xB61A90", Slot = "15")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6206B8", Offset = "0x6206B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002C9F")]
	[Address(RVA = "0xB61AFC", Offset = "0xB61AFC", VA = "0xB61AFC", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002CA0")]
	[Address(RVA = "0xB61B98", Offset = "0xB61B98", VA = "0xB61B98", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6002CA1")]
	[Address(RVA = "0xB61C18", Offset = "0xB61C18", VA = "0xB61C18", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002CA2")]
	[Address(RVA = "0xB6263C", Offset = "0xB6263C", VA = "0xB6263C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002CA3")]
	[Address(RVA = "0xB62098", Offset = "0xB62098", VA = "0xB62098")]
	private void CreateMissionSection()
	{
	}

	[Token(Token = "0x6002CA4")]
	[Address(RVA = "0xB62280", Offset = "0xB62280", VA = "0xB62280")]
	private void CreateRewardSection()
	{
	}

	[Token(Token = "0x6002CA5")]
	[Address(RVA = "0xB628DC", Offset = "0xB628DC", VA = "0xB628DC", Slot = "16")]
	protected virtual void SetVignetteTexture(LazyUITexture currentContractTexture, UITexture texture)
	{
	}

	[Token(Token = "0x6002CA6")]
	[Address(RVA = "0xB62A14", Offset = "0xB62A14", VA = "0xB62A14", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002CA7")]
	[Address(RVA = "0xB62B8C", Offset = "0xB62B8C", VA = "0xB62B8C")]
	private void OnRewardClaimedChanged(bool value)
	{
	}

	[Token(Token = "0x6002CA8")]
	[Address(RVA = "0xB62C74", Offset = "0xB62C74", VA = "0xB62C74", Slot = "17")]
	protected virtual void CreateAllScoreItem()
	{
	}

	[Token(Token = "0x6002CA9")]
	[Address(RVA = "0xB63A18", Offset = "0xB63A18", VA = "0xB63A18")]
	private void CreateEventExtraScoreTallyItems()
	{
	}

	[Token(Token = "0x6002CAA")]
	[Address(RVA = "0xB63D44", Offset = "0xB63D44", VA = "0xB63D44")]
	private void AddScoreTallyItemIfAwarded(CalenderModel.ScoreItemData scoreItemData)
	{
	}

	[Token(Token = "0x6002CAB")]
	[Address(RVA = "0xB63CC0", Offset = "0xB63CC0", VA = "0xB63CC0")]
	private void CreateEventExtraElements(CalenderModel.ScoreItemData[] scoreItemsData)
	{
	}

	[Token(Token = "0x6002CAC")]
	[Address(RVA = "0xB63F5C", Offset = "0xB63F5C", VA = "0xB63F5C")]
	private void CreateEventExtraElement(CalenderModel.ScoreItemData scoreItemData)
	{
	}

	[Token(Token = "0x6002CAD")]
	[Address(RVA = "0xB63FF4", Offset = "0xB63FF4", VA = "0xB63FF4")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x620718", Offset = "0x620718")]
	protected void ValidateData()
	{
	}

	[Token(Token = "0x6002CAE")]
	[Address(RVA = "0xB6384C", Offset = "0xB6384C", VA = "0xB6384C")]
	protected void CreateChainScoreItem(string title, TallyItem tallyItem, Wallet.Currency defaultCurrency = Wallet.Currency.NONE)
	{
	}

	[Token(Token = "0x6002CAF")]
	[Address(RVA = "0xB64174", Offset = "0xB64174", VA = "0xB64174")]
	private static void AddScoreAndCount(TallyItem tallyItem, ref int score, ref int currencyBonus, ref Wallet.Currency currencyType, ref bool isCurrencyBonus, ref int totalCount, ref bool isScaredKill)
	{
	}

	[Token(Token = "0x6002CB0")]
	[Address(RVA = "0xB63B8C", Offset = "0xB63B8C", VA = "0xB63B8C")]
	protected void CreateScoreItem(string aTitle, string amount, int scoreBonus, int currencyBonus = 0, Wallet.Currency currencyType = Wallet.Currency.NONE, bool isCurrencyBonus = false, TallyItem tallyItem = TallyItem.None, bool isScaredKill = false)
	{
	}

	[Token(Token = "0x6002CB1")]
	[Address(RVA = "0xB6473C", Offset = "0xB6473C", VA = "0xB6473C")]
	private TallyScoreItem CreateScoreItemView(ScoreItem aScoreItem, TallyScoreItem aTallyScoreItemPrefab)
	{
		return null;
	}

	[Token(Token = "0x6002CB2")]
	[Address(RVA = "0xB625D0", Offset = "0xB625D0", VA = "0xB625D0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x620750", Offset = "0x620750")]
	private IEnumerator FadeOnResults()
	{
		return null;
	}

	[Token(Token = "0x6002CB3")]
	[Address(RVA = "0xB64B18", Offset = "0xB64B18", VA = "0xB64B18")]
	protected void Update()
	{
	}

	[Token(Token = "0x6002CB4")]
	[Address(RVA = "0xB64E04", Offset = "0xB64E04", VA = "0xB64E04")]
	private void AnimatePageTransition(int nextPageIndex)
	{
	}

	[Token(Token = "0x6002CB5")]
	[Address(RVA = "0xB64BD0", Offset = "0xB64BD0", VA = "0xB64BD0")]
	private void AdvancePage()
	{
	}

	[Token(Token = "0x6002CB6")]
	[Address(RVA = "0xB64E58", Offset = "0xB64E58", VA = "0xB64E58")]
	private void StartNextPageAnimation(int nextPageIndex)
	{
	}

	[Token(Token = "0x6002CB7")]
	[Address(RVA = "0xB61F7C", Offset = "0xB61F7C", VA = "0xB61F7C")]
	private void OnTotalScoreChanged(int value)
	{
	}

	[Token(Token = "0x6002CB8")]
	[Address(RVA = "0xB65124", Offset = "0xB65124", VA = "0xB65124")]
	protected void UpdateMissionRewards()
	{
	}

	[Token(Token = "0x6002CB9")]
	[Address(RVA = "0xB65224", Offset = "0xB65224", VA = "0xB65224")]
	private void UpdateScore(int from, int to)
	{
	}

	[Token(Token = "0x6002CBA")]
	[Address(RVA = "0xB64FDC", Offset = "0xB64FDC", VA = "0xB64FDC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6207B0", Offset = "0x6207B0")]
	private IEnumerator UpdateScoreBonuses()
	{
		return null;
	}

	[Token(Token = "0x6002CBB")]
	[Address(RVA = "0xB652F0", Offset = "0xB652F0", VA = "0xB652F0", Slot = "18")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x620810", Offset = "0x620810")]
	protected virtual IEnumerator UpdateMissionSection()
	{
		return null;
	}

	[Token(Token = "0x6002CBC")]
	[Address(RVA = "0xB65048", Offset = "0xB65048", VA = "0xB65048")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x620870", Offset = "0x620870")]
	private IEnumerator UpdateRewardSection()
	{
		return null;
	}

	[Token(Token = "0x6002CBD")]
	[Address(RVA = "0xB650B4", Offset = "0xB650B4", VA = "0xB650B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6208D0", Offset = "0x6208D0")]
	private IEnumerator UpdateShare()
	{
		return null;
	}

	[Token(Token = "0x6002CBE")]
	[Address(RVA = "0xB6535C", Offset = "0xB6535C", VA = "0xB6535C")]
	private void EnableButtons()
	{
	}

	[Token(Token = "0x6002CBF")]
	[Address(RVA = "0xB65364", Offset = "0xB65364", VA = "0xB65364")]
	private void SetButtonsActive(bool isActive)
	{
	}

	[Token(Token = "0x6002CC0")]
	[Address(RVA = "0xB6559C", Offset = "0xB6559C", VA = "0xB6559C")]
	private static void SetButtonColliderActive(ButtonHandler button, bool active)
	{
	}

	[Token(Token = "0x6002CC1")]
	[Address(RVA = "0xB65668", Offset = "0xB65668", VA = "0xB65668")]
	protected void PlaySectionAppearSound(SoundContainer sound)
	{
	}

	[Token(Token = "0x6002CC2")]
	[Address(RVA = "0xB6250C", Offset = "0xB6250C", VA = "0xB6250C")]
	private void SetRestartButtonActive(bool isActive)
	{
	}

	[Token(Token = "0x6002CC3")]
	[Address(RVA = "0xB65758", Offset = "0xB65758", VA = "0xB65758")]
	private bool IsHacker()
	{
		return default(bool);
	}

	[Token(Token = "0x6002CC4")]
	[Address(RVA = "0xB658AC", Offset = "0xB658AC", VA = "0xB658AC")]
	public ScoreTallyView()
	{
	}

	[Token(Token = "0x6002CC5")]
	[Address(RVA = "0xB6592C", Offset = "0xB6592C", VA = "0xB6592C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620930", Offset = "0x620930")]
	private void _003COnRewardClaimedChanged_003Eb__53_0()
	{
	}
}
