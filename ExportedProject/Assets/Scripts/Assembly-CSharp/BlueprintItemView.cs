using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x20006D8")]
public class BlueprintItemView : View
{
	[Serializable]
	[Token(Token = "0x20006D9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595BE8", Offset = "0x595BE8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002704")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002705")]
		[FieldOffset(Offset = "0x8")]
		public static Converter<ModItemSlotView, AttachmentSlotView> _003C_003E9__126_0;

		[Token(Token = "0x4002706")]
		[FieldOffset(Offset = "0x10")]
		public static Converter<PowerUpItemSlotView, AttachmentSlotView> _003C_003E9__126_1;

		[Token(Token = "0x4002707")]
		[FieldOffset(Offset = "0x18")]
		public static Func<AttachmentSlotView, bool> _003C_003E9__126_2;

		[Token(Token = "0x4002708")]
		[FieldOffset(Offset = "0x20")]
		public static Func<ModItemSlotView, bool> _003C_003E9__165_0;

		[Token(Token = "0x4002709")]
		[FieldOffset(Offset = "0x28")]
		public static Func<PowerUpItemSlotView, bool> _003C_003E9__165_1;

		[Token(Token = "0x400270A")]
		[FieldOffset(Offset = "0x30")]
		public static Func<BlueprintPartIconView, bool> _003C_003E9__179_0;

		[Token(Token = "0x400270B")]
		[FieldOffset(Offset = "0x38")]
		public static Predicate<DataModel> _003C_003E9__183_0;

		[Token(Token = "0x400270C")]
		[FieldOffset(Offset = "0x40")]
		public static Func<DataModel, bool> _003C_003E9__186_0;

		[Token(Token = "0x400270D")]
		[FieldOffset(Offset = "0x48")]
		public static Predicate<DataModel> _003C_003E9__202_0;

		[Token(Token = "0x6002D8B")]
		[Address(RVA = "0x927AD0", Offset = "0x927AD0", VA = "0x927AD0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002D8C")]
		[Address(RVA = "0x927AD8", Offset = "0x927AD8", VA = "0x927AD8")]
		internal AttachmentSlotView _003COnUpgradePurchased_003Eb__126_0(ModItemSlotView v)
		{
			return null;
		}

		[Token(Token = "0x6002D8D")]
		[Address(RVA = "0x927AE0", Offset = "0x927AE0", VA = "0x927AE0")]
		internal AttachmentSlotView _003COnUpgradePurchased_003Eb__126_1(PowerUpItemSlotView v)
		{
			return null;
		}

		[Token(Token = "0x6002D8E")]
		[Address(RVA = "0x927AE8", Offset = "0x927AE8", VA = "0x927AE8")]
		internal bool _003COnUpgradePurchased_003Eb__126_2(AttachmentSlotView m)
		{
			return default(bool);
		}

		[Token(Token = "0x6002D8F")]
		[Address(RVA = "0x927B6C", Offset = "0x927B6C", VA = "0x927B6C")]
		internal bool _003CHideNewFeedback_003Eb__165_0(ModItemSlotView s)
		{
			return default(bool);
		}

		[Token(Token = "0x6002D90")]
		[Address(RVA = "0x927BE4", Offset = "0x927BE4", VA = "0x927BE4")]
		internal bool _003CHideNewFeedback_003Eb__165_1(PowerUpItemSlotView s)
		{
			return default(bool);
		}

		[Token(Token = "0x6002D91")]
		[Address(RVA = "0x927C5C", Offset = "0x927C5C", VA = "0x927C5C")]
		internal bool _003Cget_FirstLockedBlueprintPart_003Eb__179_0(BlueprintPartIconView part)
		{
			return default(bool);
		}

		[Token(Token = "0x6002D92")]
		[Address(RVA = "0x927C88", Offset = "0x927C88", VA = "0x927C88")]
		internal bool _003CCreateModSlots_003Eb__183_0(DataModel m)
		{
			return default(bool);
		}

		[Token(Token = "0x6002D93")]
		[Address(RVA = "0x927D04", Offset = "0x927D04", VA = "0x927D04")]
		internal bool _003CCreateCustomizeableAbilitySlot_003Eb__186_0(DataModel m)
		{
			return default(bool);
		}

		[Token(Token = "0x6002D94")]
		[Address(RVA = "0x927D80", Offset = "0x927D80", VA = "0x927D80")]
		internal bool _003CSetupTierView_003Eb__202_0(DataModel d)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20006DA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595BF8", Offset = "0x595BF8")]
	private sealed class _003CShowWeaponNextFrame_003Ed__145 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400270E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400270F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002710")]
		[FieldOffset(Offset = "0x20")]
		public BlueprintItemView _003C_003E4__this;

		[Token(Token = "0x170005E2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002D98")]
			[Address(RVA = "0x928AD0", Offset = "0x928AD0", VA = "0x928AD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D9A")]
			[Address(RVA = "0x928B18", Offset = "0x928B18", VA = "0x928B18", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002D95")]
		[Address(RVA = "0x928980", Offset = "0x928980", VA = "0x928980")]
		[DebuggerHidden]
		public _003CShowWeaponNextFrame_003Ed__145(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002D96")]
		[Address(RVA = "0x9289AC", Offset = "0x9289AC", VA = "0x9289AC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002D97")]
		[Address(RVA = "0x9289B0", Offset = "0x9289B0", VA = "0x9289B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002D99")]
		[Address(RVA = "0x928AD8", Offset = "0x928AD8", VA = "0x928AD8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006DB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595C08", Offset = "0x595C08")]
	private sealed class _003COutlineEffect_003Ed__148 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002711")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002712")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002713")]
		[FieldOffset(Offset = "0x20")]
		public BlueprintItemView _003C_003E4__this;

		[Token(Token = "0x4002714")]
		[FieldOffset(Offset = "0x28")]
		private Color _003Ccolor_003E5__2;

		[Token(Token = "0x170005E4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002D9E")]
			[Address(RVA = "0x928420", Offset = "0x928420", VA = "0x928420", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002DA0")]
			[Address(RVA = "0x928468", Offset = "0x928468", VA = "0x928468", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002D9B")]
		[Address(RVA = "0x9282B4", Offset = "0x9282B4", VA = "0x9282B4")]
		[DebuggerHidden]
		public _003COutlineEffect_003Ed__148(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002D9C")]
		[Address(RVA = "0x9282E0", Offset = "0x9282E0", VA = "0x9282E0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002D9D")]
		[Address(RVA = "0x9282E4", Offset = "0x9282E4", VA = "0x9282E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002D9F")]
		[Address(RVA = "0x928428", Offset = "0x928428", VA = "0x928428", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595C18", Offset = "0x595C18")]
	private sealed class _003CWaitToHideNewFeedback_003Ed__162 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002715")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002716")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002717")]
		[FieldOffset(Offset = "0x20")]
		public BlueprintItemView _003C_003E4__this;

		[Token(Token = "0x4002718")]
		[FieldOffset(Offset = "0x28")]
		private ContinuousTimer _003Ctimer_003E5__2;

		[Token(Token = "0x170005E6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002DA4")]
			[Address(RVA = "0x928C50", Offset = "0x928C50", VA = "0x928C50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002DA6")]
			[Address(RVA = "0x928C98", Offset = "0x928C98", VA = "0x928C98", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002DA1")]
		[Address(RVA = "0x928B20", Offset = "0x928B20", VA = "0x928B20")]
		[DebuggerHidden]
		public _003CWaitToHideNewFeedback_003Ed__162(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002DA2")]
		[Address(RVA = "0x928B4C", Offset = "0x928B4C", VA = "0x928B4C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002DA3")]
		[Address(RVA = "0x928B50", Offset = "0x928B50", VA = "0x928B50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002DA5")]
		[Address(RVA = "0x928C58", Offset = "0x928C58", VA = "0x928C58", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006DD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595C28", Offset = "0x595C28")]
	private sealed class _003C_003Ec__DisplayClass190_0
	{
		[Token(Token = "0x4002719")]
		[FieldOffset(Offset = "0x10")]
		public PlayerProfileData profile;

		[Token(Token = "0x400271A")]
		[FieldOffset(Offset = "0x18")]
		public BlueprintItemView _003C_003E4__this;

		[Token(Token = "0x6002DA7")]
		[Address(RVA = "0x927DFC", Offset = "0x927DFC", VA = "0x927DFC")]
		public _003C_003Ec__DisplayClass190_0()
		{
		}

		[Token(Token = "0x6002DA8")]
		[Address(RVA = "0x927E04", Offset = "0x927E04", VA = "0x927E04")]
		internal bool _003CIncreaseNumberOwned_003Eb__0(WeaponUnlockable.RequiredPartInfo rpi)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20006DE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595C38", Offset = "0x595C38")]
	private sealed class _003C_003Ec__DisplayClass197_0
	{
		[Token(Token = "0x400271B")]
		[FieldOffset(Offset = "0x10")]
		public AttachmentsUnlockableSaveData partData;

		[Token(Token = "0x6002DA9")]
		[Address(RVA = "0x927F48", Offset = "0x927F48", VA = "0x927F48")]
		public _003C_003Ec__DisplayClass197_0()
		{
		}

		[Token(Token = "0x6002DAA")]
		[Address(RVA = "0x927F50", Offset = "0x927F50", VA = "0x927F50")]
		internal bool _003CPartAddEffect_003Eb__0(BlueprintPartIconView r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20006DF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595C48", Offset = "0x595C48")]
	private sealed class _003CPartAddEffect_003Ed__197 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400271C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400271D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400271E")]
		[FieldOffset(Offset = "0x20")]
		public AttachmentsUnlockableSaveData partData;

		[Token(Token = "0x400271F")]
		[FieldOffset(Offset = "0x28")]
		public BlueprintItemView _003C_003E4__this;

		[Token(Token = "0x4002720")]
		[FieldOffset(Offset = "0x30")]
		private BlueprintPartIconView _003CpartIconView_003E5__2;

		[Token(Token = "0x170005E8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002DAE")]
			[Address(RVA = "0x928930", Offset = "0x928930", VA = "0x928930", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002DB0")]
			[Address(RVA = "0x928978", Offset = "0x928978", VA = "0x928978", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002DAB")]
		[Address(RVA = "0x928470", Offset = "0x928470", VA = "0x928470")]
		[DebuggerHidden]
		public _003CPartAddEffect_003Ed__197(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002DAC")]
		[Address(RVA = "0x92849C", Offset = "0x92849C", VA = "0x92849C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002DAD")]
		[Address(RVA = "0x9284A0", Offset = "0x9284A0", VA = "0x9284A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002DAF")]
		[Address(RVA = "0x928938", Offset = "0x928938", VA = "0x928938", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595C58", Offset = "0x595C58")]
	private sealed class _003CWeaponLevelUpEffect_003Ed__198 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002721")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002722")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002723")]
		[FieldOffset(Offset = "0x20")]
		public BlueprintItemView _003C_003E4__this;

		[Token(Token = "0x4002724")]
		[FieldOffset(Offset = "0x28")]
		public AttachmentSlotView view;

		[Token(Token = "0x170005EA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002DB4")]
			[Address(RVA = "0x928FBC", Offset = "0x928FBC", VA = "0x928FBC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005EB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002DB6")]
			[Address(RVA = "0x929004", Offset = "0x929004", VA = "0x929004", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002DB1")]
		[Address(RVA = "0x928CA0", Offset = "0x928CA0", VA = "0x928CA0")]
		[DebuggerHidden]
		public _003CWeaponLevelUpEffect_003Ed__198(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002DB2")]
		[Address(RVA = "0x928CCC", Offset = "0x928CCC", VA = "0x928CCC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002DB3")]
		[Address(RVA = "0x928CD0", Offset = "0x928CD0", VA = "0x928CD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002DB5")]
		[Address(RVA = "0x928FC4", Offset = "0x928FC4", VA = "0x928FC4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006E1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595C68", Offset = "0x595C68")]
	private sealed class _003CModEquipEffect_003Ed__200 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002725")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002726")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002727")]
		[FieldOffset(Offset = "0x20")]
		public ModItemSlotView modItemSlot;

		[Token(Token = "0x4002728")]
		[FieldOffset(Offset = "0x28")]
		public BlueprintItemView _003C_003E4__this;

		[Token(Token = "0x170005EC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002DBA")]
			[Address(RVA = "0x928264", Offset = "0x928264", VA = "0x928264", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005ED")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002DBC")]
			[Address(RVA = "0x9282AC", Offset = "0x9282AC", VA = "0x9282AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002DB7")]
		[Address(RVA = "0x927FE8", Offset = "0x927FE8", VA = "0x927FE8")]
		[DebuggerHidden]
		public _003CModEquipEffect_003Ed__200(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002DB8")]
		[Address(RVA = "0x928014", Offset = "0x928014", VA = "0x928014", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002DB9")]
		[Address(RVA = "0x928018", Offset = "0x928018", VA = "0x928018", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002DBB")]
		[Address(RVA = "0x92826C", Offset = "0x92826C", VA = "0x92826C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40026A3")]
	private const float EFFECT1_PASS1_WAIT = 0.5f;

	[Token(Token = "0x40026A4")]
	private const float EFFECT1_PASS1_DURATION = 0.3f;

	[Token(Token = "0x40026A5")]
	private const float EFFECT1_PASS1_COUNT = 4f;

	[Token(Token = "0x40026A6")]
	private const float PAUSE_TIME1 = 0.4f;

	[Token(Token = "0x40026A7")]
	private const float PAUSE_TIME2 = 0.13f;

	[Token(Token = "0x40026A8")]
	private const float EFFECT3_PASS1_START_SCALE = 1.25f;

	[Token(Token = "0x40026A9")]
	private const float EFFECT3_PASS1_DURATION = 0.36f;

	[Token(Token = "0x40026AA")]
	private const float PAUSE_TIME3 = 0.28f;

	[Token(Token = "0x40026AB")]
	private const float EFFECT4_PASS1_DURATION = 0.65f;

	[Token(Token = "0x40026AC")]
	private const float EFFECT4_PASS1_SCALE_SIZE = 1.25f;

	[Token(Token = "0x40026AD")]
	private const float STATS_ANIMATION_TIME = 2f;

	[Token(Token = "0x40026AF")]
	[FieldOffset(Offset = "0x68")]
	public UILabel MaxMultiplierLabel;

	[Token(Token = "0x40026B0")]
	[FieldOffset(Offset = "0x70")]
	public WeaponStatWidget MultiplierStat;

	[Token(Token = "0x40026B1")]
	[FieldOffset(Offset = "0x78")]
	public WeaponStatWidget MasteryStat;

	[Token(Token = "0x40026B2")]
	[FieldOffset(Offset = "0x80")]
	public WeaponStatWidget StabilityStat;

	[Token(Token = "0x40026B3")]
	[FieldOffset(Offset = "0x88")]
	public WeaponStatWidget ClipSizeStat;

	[Token(Token = "0x40026B4")]
	[FieldOffset(Offset = "0x90")]
	public WeaponStatWidget MaxZoomStat;

	[Token(Token = "0x40026B5")]
	[FieldOffset(Offset = "0x98")]
	public WeaponStatWidget FireRateStat;

	[Token(Token = "0x40026B6")]
	[FieldOffset(Offset = "0xA0")]
	public UnlockableProgressWidget UnlockProgressBar;

	[Token(Token = "0x40026B7")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject UnlockableProgressBarSection;

	[Token(Token = "0x40026B8")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel UnlockableProgressLabel;

	[Token(Token = "0x40026B9")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject BuyButton;

	[Token(Token = "0x40026BA")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject DisabledBuyButton;

	[Token(Token = "0x40026BB")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel BuyCostLabel;

	[Token(Token = "0x40026BC")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject OnSaleButton;

	[Token(Token = "0x40026BD")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel OnSaleLabel;

	[Token(Token = "0x40026BE")]
	[FieldOffset(Offset = "0xE0")]
	public UILabel OnSaleCostTopLabel;

	[Token(Token = "0x40026BF")]
	[FieldOffset(Offset = "0xE8")]
	public UISprite OnSaleCostTopSlashSprite;

	[Token(Token = "0x40026C0")]
	[FieldOffset(Offset = "0xF0")]
	public UILabel OnSaleCostBottomLabel;

	[Token(Token = "0x40026C1")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject OnSaleFreeButton;

	[Token(Token = "0x40026C2")]
	[FieldOffset(Offset = "0x100")]
	public GameObject LockedRankButton;

	[Token(Token = "0x40026C3")]
	[FieldOffset(Offset = "0x108")]
	public UILabel LockedRankButtonLabel;

	[Token(Token = "0x40026C4")]
	[FieldOffset(Offset = "0x110")]
	public GameObject AssemblingButton;

	[Token(Token = "0x40026C5")]
	[FieldOffset(Offset = "0x118")]
	public GameObject UpgradeButton;

	[Token(Token = "0x40026C6")]
	[FieldOffset(Offset = "0x120")]
	public UILabel UpgradeCostLabel;

	[Token(Token = "0x40026C7")]
	[FieldOffset(Offset = "0x128")]
	public GameObject LevelMaxButton;

	[Token(Token = "0x40026C8")]
	[FieldOffset(Offset = "0x130")]
	public GameObject InsufficentFundsButton;

	[Token(Token = "0x40026C9")]
	[FieldOffset(Offset = "0x138")]
	public UILabel InsufficientFundsLabel;

	[Token(Token = "0x40026CA")]
	[FieldOffset(Offset = "0x140")]
	public UILabel InsufficientFindsCost;

	[Token(Token = "0x40026CB")]
	[FieldOffset(Offset = "0x148")]
	public GameObject UpgradeLockedByRankButton;

	[Token(Token = "0x40026CC")]
	[FieldOffset(Offset = "0x150")]
	public UILabel UpgradeLockedByRankLabel;

	[Token(Token = "0x40026CD")]
	[FieldOffset(Offset = "0x158")]
	public UILocalize NameLocalize;

	[Token(Token = "0x40026CE")]
	[FieldOffset(Offset = "0x160")]
	public UILabel LevelLabel;

	[Token(Token = "0x40026CF")]
	[FieldOffset(Offset = "0x168")]
	public GameObject PopupHeader;

	[Token(Token = "0x40026D0")]
	[FieldOffset(Offset = "0x170")]
	public UILabel NameLabelForPopup;

	[Token(Token = "0x40026D1")]
	[FieldOffset(Offset = "0x178")]
	public Transform WeaponHolder;

	[Token(Token = "0x40026D2")]
	[FieldOffset(Offset = "0x180")]
	public UIAnchor WeaponHolderAnchor;

	[Token(Token = "0x40026D3")]
	[FieldOffset(Offset = "0x188")]
	public GameObject EquipButton;

	[Token(Token = "0x40026D4")]
	[FieldOffset(Offset = "0x190")]
	public UILabel EquippedLabel;

	[Token(Token = "0x40026D5")]
	[FieldOffset(Offset = "0x198")]
	public GameObject LockedGroup;

	[Token(Token = "0x40026D6")]
	[FieldOffset(Offset = "0x1A0")]
	public UILabel LockRankLabel;

	[Token(Token = "0x40026D7")]
	[FieldOffset(Offset = "0x1A8")]
	public GameObject NewIcon;

	[Token(Token = "0x40026D8")]
	[FieldOffset(Offset = "0x1B0")]
	public UIAlignedList ModsGridDefault;

	[Token(Token = "0x40026D9")]
	[FieldOffset(Offset = "0x1B8")]
	public UIAlignedList ModsGridCustomizable;

	[Token(Token = "0x40026DA")]
	[FieldOffset(Offset = "0x1C0")]
	public LazyGameObject ModItemSlotViewPrefab;

	[Token(Token = "0x40026DB")]
	[FieldOffset(Offset = "0x1C8")]
	public LazyGameObject CustomizableModItemSlotPrefab;

	[Token(Token = "0x40026DC")]
	[FieldOffset(Offset = "0x1D0")]
	public LazyGameObject AbilitySlotViewPrefab;

	[Token(Token = "0x40026DD")]
	[FieldOffset(Offset = "0x1D8")]
	public LazyGameObject CustomizableAbilitySlotViewPrefab;

	[Token(Token = "0x40026DE")]
	[FieldOffset(Offset = "0x1E0")]
	public UILabel AbilityTitle;

	[Token(Token = "0x40026DF")]
	[FieldOffset(Offset = "0x1E8")]
	public UIGrid AbilitiesGrid;

	[Token(Token = "0x40026E0")]
	[FieldOffset(Offset = "0x1F0")]
	public GameObject PartsTopSection;

	[Token(Token = "0x40026E1")]
	[FieldOffset(Offset = "0x1F8")]
	public UILabel PartsCollectedLabel;

	[Token(Token = "0x40026E2")]
	[FieldOffset(Offset = "0x200")]
	public UILocalize PartsCollectedLocalize;

	[Token(Token = "0x40026E3")]
	[FieldOffset(Offset = "0x208")]
	public UIGrid PartsGrid;

	[Token(Token = "0x40026E4")]
	[FieldOffset(Offset = "0x210")]
	public LazyGameObject PartIconPrefab;

	[Token(Token = "0x40026E5")]
	[FieldOffset(Offset = "0x218")]
	public UISprite TitleBackground;

	[Token(Token = "0x40026E6")]
	[FieldOffset(Offset = "0x220")]
	public GameObject ExtraUIDisplayGO;

	[Token(Token = "0x40026E7")]
	[FieldOffset(Offset = "0x228")]
	public GameObject SaleOnGO;

	[Token(Token = "0x40026E8")]
	[FieldOffset(Offset = "0x230")]
	public UILabel SaleOnLabel;

	[Token(Token = "0x40026E9")]
	[FieldOffset(Offset = "0x238")]
	public GameObject CloseButtonGO;

	[Token(Token = "0x40026EA")]
	[FieldOffset(Offset = "0x240")]
	[SerializeField]
	private GameObject _upgradeMasteryButton;

	[Token(Token = "0x40026EB")]
	[FieldOffset(Offset = "0x248")]
	[SerializeField]
	private UILabel _upgradeMasteryLabel;

	[Token(Token = "0x40026EC")]
	[FieldOffset(Offset = "0x250")]
	[SerializeField]
	private UILabel _upgradeMasteryCostLabel;

	[Token(Token = "0x40026ED")]
	[FieldOffset(Offset = "0x258")]
	[SerializeField]
	private GameObject _cantMasterSection;

	[Token(Token = "0x40026EE")]
	[FieldOffset(Offset = "0x260")]
	[SerializeField]
	private UILabel _cantMasterLabel;

	[Token(Token = "0x40026EF")]
	[FieldOffset(Offset = "0x268")]
	[SerializeField]
	private WeaponTierView _tierView;

	[NonSerialized]
	[Token(Token = "0x40026F0")]
	[FieldOffset(Offset = "0x270")]
	public BlueprintView BlueprintView;

	[NonSerialized]
	[Token(Token = "0x40026F1")]
	[FieldOffset(Offset = "0x278")]
	public bool InPopupMode;

	[NonSerialized]
	[Token(Token = "0x40026F2")]
	[FieldOffset(Offset = "0x279")]
	public bool IsHidden;

	[Token(Token = "0x40026F3")]
	[FieldOffset(Offset = "0x280")]
	[SerializeField]
	private UIWidget _fakeTopBar;

	[Token(Token = "0x40026F4")]
	[FieldOffset(Offset = "0x288")]
	[SerializeField]
	private GameObject _gunLevelVisual;

	[Token(Token = "0x40026F5")]
	[FieldOffset(Offset = "0x290")]
	private bool _created;

	[Token(Token = "0x40026F6")]
	[FieldOffset(Offset = "0x291")]
	private bool _hidingNewFeedback;

	[Token(Token = "0x40026F7")]
	[FieldOffset(Offset = "0x298")]
	private GameObject _weapon;

	[Token(Token = "0x40026F8")]
	[FieldOffset(Offset = "0x2A0")]
	private GameObject _extraUIDisplay;

	[Token(Token = "0x40026F9")]
	[FieldOffset(Offset = "0x2A8")]
	private bool _isCurrentWeapon;

	[Token(Token = "0x40026FA")]
	[FieldOffset(Offset = "0x2AC")]
	private int _nextUpgradeIdx;

	[Token(Token = "0x40026FB")]
	[FieldOffset(Offset = "0x2B0")]
	private int _currentUpgradeIdx;

	[Token(Token = "0x40026FC")]
	[FieldOffset(Offset = "0x2B4")]
	private int _currentAnimations;

	[Token(Token = "0x40026FD")]
	[FieldOffset(Offset = "0x2B8")]
	private List<Renderer> _weaponRenderers;

	[Token(Token = "0x40026FE")]
	[FieldOffset(Offset = "0x2C0")]
	private readonly GameTimer _timer;

	[Token(Token = "0x40026FF")]
	[FieldOffset(Offset = "0x2C8")]
	private readonly List<Material[]> _initMaterials;

	[Token(Token = "0x4002700")]
	[FieldOffset(Offset = "0x2D0")]
	private readonly List<ModItemSlotView> _modSlotsViews;

	[Token(Token = "0x4002701")]
	[FieldOffset(Offset = "0x2D8")]
	private readonly List<PowerUpItemSlotView> _abilityViews;

	[Token(Token = "0x4002702")]
	[FieldOffset(Offset = "0x2E0")]
	private readonly List<BlueprintPartIconView> _partIconViews;

	[Token(Token = "0x4002703")]
	[FieldOffset(Offset = "0x2E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B9A0C", Offset = "0x5B9A0C")]
	private WeaponUnlockable _003CWeaponUnlockable_003Ek__BackingField;

	[Token(Token = "0x170005DA")]
	public WeaponUnlockable WeaponUnlockable
	{
		[Token(Token = "0x6002D29")]
		[Address(RVA = "0xC6EC94", Offset = "0xC6EC94", VA = "0xC6EC94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620C50", Offset = "0x620C50")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002D2A")]
		[Address(RVA = "0xC6EC9C", Offset = "0xC6EC9C", VA = "0xC6EC9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620C60", Offset = "0x620C60")]
		private set
		{
		}
	}

	[Token(Token = "0x170005DB")]
	public WeaponUnlockableSaveData WeaponUnlockableData
	{
		[Token(Token = "0x6002D2B")]
		[Address(RVA = "0xC6ECA4", Offset = "0xC6ECA4", VA = "0xC6ECA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005DC")]
	public bool IsNewlyCompleted
	{
		[Token(Token = "0x6002D2C")]
		[Address(RVA = "0xC6ECC0", Offset = "0xC6ECC0", VA = "0xC6ECC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005DD")]
	public List<BlueprintPartIconView> PartViews
	{
		[Token(Token = "0x6002D2D")]
		[Address(RVA = "0xC6EDB0", Offset = "0xC6EDB0", VA = "0xC6EDB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005DE")]
	public List<ModItemSlotView> ModSlotsViews
	{
		[Token(Token = "0x6002D2E")]
		[Address(RVA = "0xC6EDB8", Offset = "0xC6EDB8", VA = "0xC6EDB8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005DF")]
	public List<PowerUpItemSlotView> AbilityViews
	{
		[Token(Token = "0x6002D2F")]
		[Address(RVA = "0xC6EDC0", Offset = "0xC6EDC0", VA = "0xC6EDC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005E0")]
	private UIAlignedList ModsGrid
	{
		[Token(Token = "0x6002D30")]
		[Address(RVA = "0xC6EDC8", Offset = "0xC6EDC8", VA = "0xC6EDC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005E1")]
	public BlueprintPartIconView FirstLockedBlueprintPart
	{
		[Token(Token = "0x6002D71")]
		[Address(RVA = "0xC77B64", Offset = "0xC77B64", VA = "0xC77B64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x140000A3")]
	public event EventHandler OnLevelUpAnimationFinished
	{
		[Token(Token = "0x6002D27")]
		[Address(RVA = "0xC6EB54", Offset = "0xC6EB54", VA = "0xC6EB54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620C30", Offset = "0x620C30")]
		add
		{
		}
		[Token(Token = "0x6002D28")]
		[Address(RVA = "0xC6EBF4", Offset = "0xC6EBF4", VA = "0xC6EBF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620C40", Offset = "0x620C40")]
		remove
		{
		}
	}

	[Token(Token = "0x6002D31")]
	[Address(RVA = "0xC6EE0C", Offset = "0xC6EE0C", VA = "0xC6EE0C", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002D32")]
	[Address(RVA = "0xC6EFE4", Offset = "0xC6EFE4", VA = "0xC6EFE4")]
	public void Init()
	{
	}

	[Token(Token = "0x6002D33")]
	[Address(RVA = "0xC6F668", Offset = "0xC6F668", VA = "0xC6F668", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002D34")]
	[Address(RVA = "0xC6F9DC", Offset = "0xC6F9DC", VA = "0xC6F9DC", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002D35")]
	[Address(RVA = "0xC6FC74", Offset = "0xC6FC74", VA = "0xC6FC74")]
	public void SetIsHidden()
	{
	}

	[Token(Token = "0x6002D36")]
	[Address(RVA = "0xC6FDF4", Offset = "0xC6FDF4", VA = "0xC6FDF4")]
	private void OnInventoryChanged(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x6002D37")]
	[Address(RVA = "0xC6FE08", Offset = "0xC6FE08", VA = "0xC6FE08")]
	private void OnShopReloadRefresh(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x6002D38")]
	[Address(RVA = "0xC6FE1C", Offset = "0xC6FE1C", VA = "0xC6FE1C")]
	private void OnPromotionRefreshed()
	{
	}

	[Token(Token = "0x6002D39")]
	[Address(RVA = "0xC6FE30", Offset = "0xC6FE30", VA = "0xC6FE30")]
	private void OnWeaponUnlockableUpdated(object sender, PlayerProfileData.WeaponUnlockableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002D3A")]
	[Address(RVA = "0xC6FF68", Offset = "0xC6FF68", VA = "0xC6FF68", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002D3B")]
	[Address(RVA = "0xC70A38", Offset = "0xC70A38", VA = "0xC70A38")]
	private void OnGetStar(object sender, ContractAssignmentView.OnStarGainedArgs args)
	{
	}

	[Token(Token = "0x6002D3C")]
	[Address(RVA = "0xC70D50", Offset = "0xC70D50", VA = "0xC70D50", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002D3D")]
	[Address(RVA = "0xC71274", Offset = "0xC71274", VA = "0xC71274")]
	private void OnUpgradePurchased()
	{
	}

	[Token(Token = "0x6002D3E")]
	[Address(RVA = "0xC71858", Offset = "0xC71858", VA = "0xC71858")]
	private void OnMasteryUpgraded()
	{
	}

	[Token(Token = "0x6002D3F")]
	[Address(RVA = "0xC710C0", Offset = "0xC710C0", VA = "0xC710C0")]
	private void RefreshEquippedState()
	{
	}

	[Token(Token = "0x6002D40")]
	[Address(RVA = "0xC70898", Offset = "0xC70898", VA = "0xC70898")]
	private void ClearUnusedAsset()
	{
	}

	[Token(Token = "0x6002D41")]
	[Address(RVA = "0xC6F2E8", Offset = "0xC6F2E8", VA = "0xC6F2E8")]
	private void OnUnlockableChanged(WeaponUnlockable unlockable)
	{
	}

	[Token(Token = "0x6002D42")]
	[Address(RVA = "0xC6F8D0", Offset = "0xC6F8D0", VA = "0xC6F8D0")]
	private void RefreshWeaponState()
	{
	}

	[Token(Token = "0x6002D43")]
	[Address(RVA = "0xC74444", Offset = "0xC74444", VA = "0xC74444")]
	public static string GetEventLockedName(WeaponUnlockable weaponUnlockable)
	{
		return null;
	}

	[Token(Token = "0x6002D44")]
	[Address(RVA = "0xC7444C", Offset = "0xC7444C", VA = "0xC7444C")]
	public void PromotionRefresh()
	{
	}

	[Token(Token = "0x6002D45")]
	[Address(RVA = "0xC74480", Offset = "0xC74480", VA = "0xC74480", Slot = "15")]
	protected virtual void RefreshLockedState(bool forceUnlocked = false)
	{
	}

	[Token(Token = "0x6002D46")]
	[Address(RVA = "0xC75FA8", Offset = "0xC75FA8", VA = "0xC75FA8", Slot = "16")]
	protected virtual bool IsLockedExternally()
	{
		return default(bool);
	}

	[Token(Token = "0x6002D47")]
	[Address(RVA = "0xC75C6C", Offset = "0xC75C6C", VA = "0xC75C6C")]
	private void AddMaterial(List<Renderer> weaponRenderers, Material material)
	{
	}

	[Token(Token = "0x6002D48")]
	[Address(RVA = "0xC75EB4", Offset = "0xC75EB4", VA = "0xC75EB4")]
	private void RemoveMaterial(List<Renderer> weaponRenderers, Material material)
	{
	}

	[Token(Token = "0x6002D49")]
	[Address(RVA = "0xC70A3C", Offset = "0xC70A3C", VA = "0xC70A3C")]
	private void SetLockLabel()
	{
	}

	[Token(Token = "0x6002D4A")]
	[Address(RVA = "0xC74EE0", Offset = "0xC74EE0", VA = "0xC74EE0")]
	public static bool IsLeaderboardLocked(WeaponUnlockable weaponUnlockable)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D4B")]
	[Address(RVA = "0xC76084", Offset = "0xC76084", VA = "0xC76084")]
	private bool IsLockedByCurrencyDebits()
	{
		return default(bool);
	}

	[Token(Token = "0x6002D4C")]
	[Address(RVA = "0xC726D4", Offset = "0xC726D4", VA = "0xC726D4")]
	public static void Create3DWeapon(WeaponUnlockable unlockable, Transform weaponHolder, ref GameObject weapon, ref List<Renderer> weaponRenderers, List<Material[]> initMaterials)
	{
	}

	[Token(Token = "0x6002D4D")]
	[Address(RVA = "0xC74118", Offset = "0xC74118", VA = "0xC74118")]
	private void SetupWeaponHolderDisplay(bool showExtraDisplay)
	{
	}

	[Token(Token = "0x6002D4E")]
	[Address(RVA = "0xC7425C", Offset = "0xC7425C", VA = "0xC7425C")]
	private void SetupExtraUIDisplay(bool showExtraDisplay)
	{
	}

	[Token(Token = "0x6002D4F")]
	[Address(RVA = "0xC72F28", Offset = "0xC72F28", VA = "0xC72F28")]
	private void SetupLights()
	{
	}

	[Token(Token = "0x6002D50")]
	[Address(RVA = "0xC76164", Offset = "0xC76164", VA = "0xC76164")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x620C70", Offset = "0x620C70")]
	private IEnumerator ShowWeaponNextFrame()
	{
		return null;
	}

	[Token(Token = "0x6002D51")]
	[Address(RVA = "0xC72A5C", Offset = "0xC72A5C", VA = "0xC72A5C")]
	private void CreatePartsSection()
	{
	}

	[Token(Token = "0x6002D52")]
	[Address(RVA = "0xC730A4", Offset = "0xC730A4", VA = "0xC730A4")]
	private void UpdatePartsCountLabels()
	{
	}

	[Token(Token = "0x6002D53")]
	[Address(RVA = "0xC761D0", Offset = "0xC761D0", VA = "0xC761D0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x620CD0", Offset = "0x620CD0")]
	private IEnumerator OutlineEffect()
	{
		return null;
	}

	[Token(Token = "0x6002D54")]
	[Address(RVA = "0xC73EF0", Offset = "0xC73EF0", VA = "0xC73EF0")]
	private void SetXPLevels()
	{
	}

	[Token(Token = "0x6002D55")]
	[Address(RVA = "0xC7623C", Offset = "0xC7623C", VA = "0xC7623C")]
	public void ShowLevelUpEffect()
	{
	}

	[Token(Token = "0x6002D56")]
	[Address(RVA = "0xC76DB8", Offset = "0xC76DB8", VA = "0xC76DB8")]
	private void OnLevelUpAnimationCompleted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6002D57")]
	[Address(RVA = "0xC76C68", Offset = "0xC76C68", VA = "0xC76C68")]
	private void OnAnimationFinished(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6002D58")]
	[Address(RVA = "0xC76460", Offset = "0xC76460", VA = "0xC76460")]
	private void WeaponLevelUpStatsEffects()
	{
	}

	[Token(Token = "0x6002D59")]
	[Address(RVA = "0xC71A68", Offset = "0xC71A68", VA = "0xC71A68")]
	private void DisplayWeaponStats()
	{
	}

	[Token(Token = "0x6002D5A")]
	[Address(RVA = "0xC76F5C", Offset = "0xC76F5C", VA = "0xC76F5C")]
	private static int GetShootDelay(GameplayConfig config, WeaponXPUpgrade upgrade)
	{
		return default(int);
	}

	[Token(Token = "0x6002D5B")]
	[Address(RVA = "0xC76E50", Offset = "0xC76E50", VA = "0xC76E50")]
	private static float GetStability(GameplayConfig config, WeaponXPUpgrade upgrade)
	{
		return default(float);
	}

	[Token(Token = "0x6002D5C")]
	[Address(RVA = "0xC76E3C", Offset = "0xC76E3C", VA = "0xC76E3C")]
	public static int MultiplierToPercentage(float multiplier)
	{
		return default(int);
	}

	[Token(Token = "0x6002D5D")]
	[Address(RVA = "0xC76EF4", Offset = "0xC76EF4", VA = "0xC76EF4")]
	private static int GetClipSize(GameplayConfig config, WeaponXPUpgrade upgrade)
	{
		return default(int);
	}

	[Token(Token = "0x6002D5E")]
	[Address(RVA = "0xC76F28", Offset = "0xC76F28", VA = "0xC76F28")]
	private static float GetMaxZoom(GameplayConfig config, WeaponXPUpgrade upgrade)
	{
		return default(float);
	}

	[Token(Token = "0x6002D5F")]
	[Address(RVA = "0xC7701C", Offset = "0xC7701C", VA = "0xC7701C")]
	public Transform GetWeaponPartBoneTransform(string transformName)
	{
		return null;
	}

	[Token(Token = "0x6002D60")]
	[Address(RVA = "0xC77058", Offset = "0xC77058", VA = "0xC77058")]
	public void HideNewFeedbackForSlot()
	{
	}

	[Token(Token = "0x6002D61")]
	[Address(RVA = "0xC770D0", Offset = "0xC770D0", VA = "0xC770D0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x620D30", Offset = "0x620D30")]
	private IEnumerator WaitToHideNewFeedback()
	{
		return null;
	}

	[Token(Token = "0x6002D62")]
	[Address(RVA = "0xC7713C", Offset = "0xC7713C", VA = "0xC7713C")]
	private void SetNewIconVisibility(bool visibility)
	{
	}

	[Token(Token = "0x6002D63")]
	[Address(RVA = "0xC771F8", Offset = "0xC771F8", VA = "0xC771F8")]
	private void SetCurrentWeapon(bool isCurrent)
	{
	}

	[Token(Token = "0x6002D64")]
	[Address(RVA = "0xC772B0", Offset = "0xC772B0", VA = "0xC772B0")]
	private void HideNewFeedback()
	{
	}

	[Token(Token = "0x6002D65")]
	[Address(RVA = "0xC7792C", Offset = "0xC7792C", VA = "0xC7792C")]
	public void UpdateWeaponVisibility(bool isCurrent, bool doRender)
	{
	}

	[Token(Token = "0x6002D66")]
	[Address(RVA = "0xC74FA0", Offset = "0xC74FA0", VA = "0xC74FA0")]
	private void RefreshBuyPrice()
	{
	}

	[Token(Token = "0x6002D67")]
	[Address(RVA = "0xC7540C", Offset = "0xC7540C", VA = "0xC7540C")]
	private void RefreshSaleOnBanner()
	{
	}

	[Token(Token = "0x6002D68")]
	[Address(RVA = "0xC75514", Offset = "0xC75514", VA = "0xC75514")]
	private void RefreshUpgradePrice()
	{
	}

	[Token(Token = "0x6002D69")]
	[Address(RVA = "0xC75760", Offset = "0xC75760", VA = "0xC75760")]
	private void RefreshUpgradeMasteryLabels()
	{
	}

	[Token(Token = "0x6002D6A")]
	[Address(RVA = "0xC75A34", Offset = "0xC75A34", VA = "0xC75A34")]
	private void RefreshCantUpgradeMasterySection()
	{
	}

	[Token(Token = "0x6002D6B")]
	[Address(RVA = "0xC75B90", Offset = "0xC75B90", VA = "0xC75B90")]
	private void RefreshUpgradeLockedByRank(LeaderboardConfiguration leaderboardConfiguration, int tierIndex, int leaderboardID)
	{
	}

	[Token(Token = "0x6002D6C")]
	[Address(RVA = "0xC7799C", Offset = "0xC7799C", VA = "0xC7799C")]
	public void RefreshEquippedWeapon()
	{
	}

	[Token(Token = "0x6002D6D")]
	[Address(RVA = "0xC779A0", Offset = "0xC779A0", VA = "0xC779A0")]
	public void UpdateNewPowerUpsFeedback(bool hasNewPowerUps)
	{
	}

	[Token(Token = "0x6002D6E")]
	[Address(RVA = "0xC779A4", Offset = "0xC779A4", VA = "0xC779A4")]
	public void UpdateAttachmentsInAbilitySlots()
	{
	}

	[Token(Token = "0x6002D6F")]
	[Address(RVA = "0xC77A84", Offset = "0xC77A84", VA = "0xC77A84")]
	public void UpdateAttachmentsInModSlots()
	{
	}

	[Token(Token = "0x6002D70")]
	[Address(RVA = "0xC71220", Offset = "0xC71220", VA = "0xC71220")]
	private void OnComplete()
	{
	}

	[Token(Token = "0x6002D72")]
	[Address(RVA = "0xC719D0", Offset = "0xC719D0", VA = "0xC719D0")]
	private void UpgradeWeaponXP(int nextUpgradeIdx)
	{
	}

	[Token(Token = "0x6002D73")]
	[Address(RVA = "0xC77C80", Offset = "0xC77C80", VA = "0xC77C80")]
	public void HideModSlot(int upgradeIdx)
	{
	}

	[Token(Token = "0x6002D74")]
	[Address(RVA = "0xC77DB0", Offset = "0xC77DB0", VA = "0xC77DB0")]
	public void HideAbilitySlot(int abilityIdx)
	{
	}

	[Token(Token = "0x6002D75")]
	[Address(RVA = "0xC73690", Offset = "0xC73690", VA = "0xC73690")]
	private void CreateModSlots()
	{
	}

	[Token(Token = "0x6002D76")]
	[Address(RVA = "0xC77EE0", Offset = "0xC77EE0", VA = "0xC77EE0")]
	private ModItemSlotView CreateModSlot(WeaponUnlockableSaveData unlockableSaveData, int index, int resourceIndex, bool isUnlocked, bool isUnlockedByDefault, bool showNewFeedback, LazyGameObject lazyPrefab)
	{
		return null;
	}

	[Token(Token = "0x6002D77")]
	[Address(RVA = "0xC73AC4", Offset = "0xC73AC4", VA = "0xC73AC4")]
	private void CreateAbilitySlots()
	{
	}

	[Token(Token = "0x6002D78")]
	[Address(RVA = "0xC78688", Offset = "0xC78688", VA = "0xC78688")]
	private CustomizablePowerUpItemSlotView CreateCustomizeableAbilitySlot(WeaponUnlockableSaveData unlockableSaveData, PowerUpItemSlotView slot, int resourceIndex, bool isUnlocked, bool showNewFeedback)
	{
		return null;
	}

	[Token(Token = "0x6002D79")]
	[Address(RVA = "0xC784CC", Offset = "0xC784CC", VA = "0xC784CC")]
	private PowerUpItemSlotView CreateAbilitySlot(WeaponUnlockableSaveData unlockableSaveData, PowerUpItemSlotView slot, int resourceIndex, bool isUnlocked, bool showNewFeedback)
	{
		return null;
	}

	[Token(Token = "0x6002D7A")]
	[Address(RVA = "0xC781C8", Offset = "0xC781C8", VA = "0xC781C8")]
	private AttachmentSlotView CreateSlot(GameObject prefab, AttachmentSlotView slot, int index, WeaponUnlockableSaveData unlockableSaveData, int resourceIndex, bool isUnlocked, bool showNewFeedback, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6002D7B")]
	[Address(RVA = "0xC789EC", Offset = "0xC789EC", VA = "0xC789EC")]
	public void SetupAsPopup(string title, string weaponName)
	{
	}

	[Token(Token = "0x6002D7C")]
	[Address(RVA = "0xC78CA8", Offset = "0xC78CA8", VA = "0xC78CA8")]
	public void IncreaseNumberOwned(AttachmentsUnlockableSaveData partData)
	{
	}

	[Token(Token = "0x6002D7D")]
	[Address(RVA = "0xC78FF8", Offset = "0xC78FF8", VA = "0xC78FF8")]
	private static void PlayBlinkEffect(GameObject effectObject, float duration)
	{
	}

	[Token(Token = "0x6002D7E")]
	[Address(RVA = "0xC790E8", Offset = "0xC790E8", VA = "0xC790E8")]
	private static void StopEffect(GameObject effectObject)
	{
	}

	[Token(Token = "0x6002D7F")]
	[Address(RVA = "0xC79104", Offset = "0xC79104", VA = "0xC79104")]
	public static void PlayFlashEffect(GameObject effectObject, float duration)
	{
	}

	[Token(Token = "0x6002D80")]
	[Address(RVA = "0xC79164", Offset = "0xC79164", VA = "0xC79164")]
	public static void PlayTextureScaleInEffect(UITexture textureContainer, Texture originalTexture, float duration)
	{
	}

	[Token(Token = "0x6002D81")]
	[Address(RVA = "0xC791D4", Offset = "0xC791D4", VA = "0xC791D4")]
	private static void StartScale(GameObject effectObject, float duration)
	{
	}

	[Token(Token = "0x6002D82")]
	[Address(RVA = "0xC79274", Offset = "0xC79274", VA = "0xC79274")]
	public static void PlayExplodeEffect(GameObject effectObject, float duration)
	{
	}

	[Token(Token = "0x6002D83")]
	[Address(RVA = "0xC78F80", Offset = "0xC78F80", VA = "0xC78F80")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x620D90", Offset = "0x620D90")]
	private IEnumerator PartAddEffect(AttachmentsUnlockableSaveData partData)
	{
		return null;
	}

	[Token(Token = "0x6002D84")]
	[Address(RVA = "0xC76BF0", Offset = "0xC76BF0", VA = "0xC76BF0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x620DF0", Offset = "0x620DF0")]
	private IEnumerator WeaponLevelUpEffect(AttachmentSlotView view)
	{
		return null;
	}

	[Token(Token = "0x6002D85")]
	[Address(RVA = "0xC79390", Offset = "0xC79390", VA = "0xC79390")]
	public void PlayModEquipEffect(ModItemSlotView modItemSlot)
	{
	}

	[Token(Token = "0x6002D86")]
	[Address(RVA = "0xC79474", Offset = "0xC79474", VA = "0xC79474")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x620E50", Offset = "0x620E50")]
	private IEnumerator ModEquipEffect(ModItemSlotView modItemSlot)
	{
		return null;
	}

	[Token(Token = "0x6002D87")]
	[Address(RVA = "0xC794EC", Offset = "0xC794EC", VA = "0xC794EC")]
	private void OnLanguageChanged(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6002D88")]
	[Address(RVA = "0xC6F488", Offset = "0xC6F488", VA = "0xC6F488")]
	private void SetupTierView()
	{
	}

	[Token(Token = "0x6002D89")]
	[Address(RVA = "0xC79534", Offset = "0xC79534", VA = "0xC79534")]
	public BlueprintItemView()
	{
	}
}
