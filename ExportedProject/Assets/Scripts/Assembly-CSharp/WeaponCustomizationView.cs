using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000709")]
public abstract class WeaponCustomizationView : View
{
	[Token(Token = "0x200070A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595DC8", Offset = "0x595DC8")]
	private sealed class _003C_003Ec__DisplayClass43_0
	{
		[Token(Token = "0x40027E9")]
		[FieldOffset(Offset = "0x10")]
		public SlotView newView;

		[Token(Token = "0x6002EF3")]
		[Address(RVA = "0xA429CC", Offset = "0xA429CC", VA = "0xA429CC")]
		public _003C_003Ec__DisplayClass43_0()
		{
		}

		[Token(Token = "0x6002EF4")]
		[Address(RVA = "0xA429D4", Offset = "0xA429D4", VA = "0xA429D4")]
		internal bool _003COnCurrentSelectedSlotChanged_003Eb__0(CollectionItemView i)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200070B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595DD8", Offset = "0x595DD8")]
	private sealed class _003C_003Ec__DisplayClass46_0
	{
		[Token(Token = "0x40027EA")]
		[FieldOffset(Offset = "0x10")]
		public WeaponCustomizationView _003C_003E4__this;

		[Token(Token = "0x40027EB")]
		[FieldOffset(Offset = "0x18")]
		public int initiallySelectedIdx;

		[Token(Token = "0x6002EF5")]
		[Address(RVA = "0xA42A10", Offset = "0xA42A10", VA = "0xA42A10")]
		public _003C_003Ec__DisplayClass46_0()
		{
		}

		[Token(Token = "0x6002EF6")]
		[Address(RVA = "0xA42A18", Offset = "0xA42A18", VA = "0xA42A18")]
		internal bool _003CDoRefresh_003Eb__0(CollectionItemView i)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200070C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595DE8", Offset = "0x595DE8")]
	private sealed class _003CDelayCenterOnCollectionItem_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40027EC")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40027ED")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40027EE")]
		[FieldOffset(Offset = "0x20")]
		public WeaponCustomizationView _003C_003E4__this;

		[Token(Token = "0x40027EF")]
		[FieldOffset(Offset = "0x28")]
		public CollectionItemView collectionItem;

		[Token(Token = "0x17000611")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002EFA")]
			[Address(RVA = "0xA42B70", Offset = "0xA42B70", VA = "0xA42B70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000612")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002EFC")]
			[Address(RVA = "0xA42BB8", Offset = "0xA42BB8", VA = "0xA42BB8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002EF7")]
		[Address(RVA = "0xA42AB4", Offset = "0xA42AB4", VA = "0xA42AB4")]
		[DebuggerHidden]
		public _003CDelayCenterOnCollectionItem_003Ed__49(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002EF8")]
		[Address(RVA = "0xA42AE0", Offset = "0xA42AE0", VA = "0xA42AE0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002EF9")]
		[Address(RVA = "0xA42AE4", Offset = "0xA42AE4", VA = "0xA42AE4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002EFB")]
		[Address(RVA = "0xA42B78", Offset = "0xA42B78", VA = "0xA42B78", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200070D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595DF8", Offset = "0x595DF8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40027F0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40027F1")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<DataModel> _003C_003E9__63_0;

		[Token(Token = "0x40027F2")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<DataModel> _003C_003E9__64_0;

		[Token(Token = "0x6002EFE")]
		[Address(RVA = "0xA428CC", Offset = "0xA428CC", VA = "0xA428CC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002EFF")]
		[Address(RVA = "0xA428D4", Offset = "0xA428D4", VA = "0xA428D4")]
		internal bool _003CCreateSlots_003Eb__63_0(DataModel m)
		{
			return default(bool);
		}

		[Token(Token = "0x6002F00")]
		[Address(RVA = "0xA42950", Offset = "0xA42950", VA = "0xA42950")]
		internal bool _003CCreateItemCollection_003Eb__64_0(DataModel m)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40027D1")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected UIGrid _slotParent;

	[Token(Token = "0x40027D2")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	protected UIGrid _collectionParent;

	[Token(Token = "0x40027D3")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	protected GameObject _slotPrefab;

	[Token(Token = "0x40027D4")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	protected GameObject _collectionItemPrefab;

	[Token(Token = "0x40027D5")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	protected GameObject _removeItemPrefab;

	[Token(Token = "0x40027D6")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UIWidget _collectionBackground;

	[Token(Token = "0x40027D7")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private float _collectionBackgroundAlpha;

	[Token(Token = "0x40027D8")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private UIDraggablePanel _draggablePanel;

	[Token(Token = "0x40027D9")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private UILabel _collectionItemName;

	[Token(Token = "0x40027DA")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private UILabel _collectionItemDescription;

	[Token(Token = "0x40027DB")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private string _lockedItemDesciptionKey;

	[Token(Token = "0x40027DC")]
	[FieldOffset(Offset = "0xB8")]
	private WeaponUnlockableSaveData _weaponSaveData;

	[Token(Token = "0x40027DD")]
	[FieldOffset(Offset = "0xC0")]
	private List<SlotView> _slots;

	[Token(Token = "0x40027DE")]
	[FieldOffset(Offset = "0xC8")]
	private List<CollectionItemView> _collectionItems;

	[Token(Token = "0x40027DF")]
	[FieldOffset(Offset = "0xD0")]
	private UIPanel _panel;

	[Token(Token = "0x40027E0")]
	[FieldOffset(Offset = "0xD8")]
	private UICenterOnChild _centerOnChild;

	[Token(Token = "0x40027E1")]
	[FieldOffset(Offset = "0xE0")]
	private Bounds _collectionItemBounds;

	[Token(Token = "0x40027E2")]
	[FieldOffset(Offset = "0xF8")]
	private Transform _currentClosestCenter;

	[Token(Token = "0x40027E3")]
	[FieldOffset(Offset = "0x100")]
	private SoundContainer _nextCollectionItemSound;

	[Token(Token = "0x40027E4")]
	[FieldOffset(Offset = "0x108")]
	private SoundContainer _slotItemSound;

	[Token(Token = "0x40027E5")]
	[FieldOffset(Offset = "0x110")]
	private SoundContainer _removeItemSound;

	[Token(Token = "0x40027E6")]
	[FieldOffset(Offset = "0x118")]
	private SoundContainer _selectSlotSound;

	[Token(Token = "0x40027E7")]
	[FieldOffset(Offset = "0x120")]
	private WeaponUnlockableSaveData.AttachmentSlot[] _originalAttachments;

	[Token(Token = "0x40027E8")]
	[FieldOffset(Offset = "0x128")]
	private CustomizableWeaponConfig _config;

	[Token(Token = "0x1700060C")]
	protected UIGrid SlotParent
	{
		[Token(Token = "0x6002ECE")]
		[Address(RVA = "0x9852DC", Offset = "0x9852DC", VA = "0x9852DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700060D")]
	protected UIGrid CollectionParent
	{
		[Token(Token = "0x6002ECF")]
		[Address(RVA = "0x9852E4", Offset = "0x9852E4", VA = "0x9852E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700060E")]
	protected WeaponUnlockableSaveData WeaponSaveData
	{
		[Token(Token = "0x6002ED0")]
		[Address(RVA = "0x9852EC", Offset = "0x9852EC", VA = "0x9852EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700060F")]
	protected CustomizableWeaponConfig Config
	{
		[Token(Token = "0x6002ED1")]
		[Address(RVA = "0x9852F4", Offset = "0x9852F4", VA = "0x9852F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000610")]
	protected abstract WeaponUnlockableSaveData.AttachmentSlot[] AttachmentList
	{
		[Token(Token = "0x6002EE7")]
		get;
	}

	[Token(Token = "0x6002ED2")]
	[Address(RVA = "0x9852FC", Offset = "0x9852FC", VA = "0x9852FC", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002ED3")]
	[Address(RVA = "0x985448", Offset = "0x985448", VA = "0x985448", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6002ED4")]
	[Address(RVA = "0x985758", Offset = "0x985758", VA = "0x985758", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002ED5")]
	[Address(RVA = "0x985914", Offset = "0x985914", VA = "0x985914", Slot = "6")]
	protected override void LateGameUpdate()
	{
	}

	[Token(Token = "0x6002ED6")]
	[Address(RVA = "0x985940", Offset = "0x985940", VA = "0x985940")]
	private void UpdateCarouselLeft()
	{
	}

	[Token(Token = "0x6002ED7")]
	[Address(RVA = "0x985AA4", Offset = "0x985AA4", VA = "0x985AA4")]
	private void UpdateCarouselRight()
	{
	}

	[Token(Token = "0x6002ED8")]
	[Address(RVA = "0x985F08", Offset = "0x985F08", VA = "0x985F08")]
	private Transform GetLeftmost()
	{
		return null;
	}

	[Token(Token = "0x6002ED9")]
	[Address(RVA = "0x985E04", Offset = "0x985E04", VA = "0x985E04")]
	private Transform GetRightmost()
	{
		return null;
	}

	[Token(Token = "0x6002EDA")]
	[Address(RVA = "0x985C0C", Offset = "0x985C0C", VA = "0x985C0C")]
	private void UpdateHighlightedChild()
	{
	}

	[Token(Token = "0x6002EDB")]
	[Address(RVA = "0x98600C", Offset = "0x98600C", VA = "0x98600C", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002EDC")]
	[Address(RVA = "0x985440", Offset = "0x985440", VA = "0x985440")]
	private void OnWeaponSaveDataChanged(WeaponUnlockableSaveData weaponSaveData)
	{
	}

	[Token(Token = "0x6002EDD")]
	[Address(RVA = "0x98644C", Offset = "0x98644C", VA = "0x98644C")]
	private void OnCurrentSelectedSlotChanged(SelectedSlot oldSlot, SelectedSlot newSlot)
	{
	}

	[Token(Token = "0x6002EDE")]
	[Address(RVA = "0x98679C", Offset = "0x98679C", VA = "0x98679C")]
	private void OnCurrentSelectedCollectionItemChanged(SelectedSlot collectionitem)
	{
	}

	[Token(Token = "0x6002EDF")]
	[Address(RVA = "0x9866F8", Offset = "0x9866F8", VA = "0x9866F8")]
	private void OnRefreshCollectionItemsChanged(bool doRefresh)
	{
	}

	[Token(Token = "0x6002EE0")]
	[Address(RVA = "0x986914", Offset = "0x986914", VA = "0x986914")]
	private void DoRefresh()
	{
	}

	[Token(Token = "0x6002EE1")]
	[Address(RVA = "0x986CA4", Offset = "0x986CA4", VA = "0x986CA4")]
	private void RefreshCollectionItems()
	{
	}

	[Token(Token = "0x6002EE2")]
	[Address(RVA = "0x9879AC", Offset = "0x9879AC", VA = "0x9879AC")]
	private void OnCenteredCollectionItemChanged(Vector3 offset)
	{
	}

	[Token(Token = "0x6002EE3")]
	[Address(RVA = "0x987934", Offset = "0x987934", VA = "0x987934")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x621500", Offset = "0x621500")]
	private IEnumerator DelayCenterOnCollectionItem(CollectionItemView collectionItem)
	{
		return null;
	}

	[Token(Token = "0x6002EE4")]
	[Address(RVA = "0x9867C4", Offset = "0x9867C4", VA = "0x9867C4")]
	private void OnLeftArrowClickedChanged(bool clicked)
	{
	}

	[Token(Token = "0x6002EE5")]
	[Address(RVA = "0x98686C", Offset = "0x98686C", VA = "0x98686C")]
	private void OnRightArrowClickedChanged(bool clicked)
	{
	}

	[Token(Token = "0x6002EE6")]
	[Address(RVA = "0x987C60", Offset = "0x987C60", VA = "0x987C60")]
	private void ChangeCenteredChild(int numToMove)
	{
	}

	[Token(Token = "0x6002EE8")]
	protected abstract int GetNumAttachmentsForUpgrade(WeaponXPUpgrade upgrade);

	[Token(Token = "0x6002EE9")]
	protected abstract bool IsAttachmentCustomizable(WeaponXPUpgrade upgrade, int idx);

	[Token(Token = "0x6002EEA")]
	protected abstract int GetNumAvailableAttachments();

	[Token(Token = "0x6002EEB")]
	protected abstract int GetNumRestrictedAttachments();

	[Token(Token = "0x6002EEC")]
	protected abstract string GetAvailableAttachmentPath(int idx);

	[Token(Token = "0x6002EED")]
	protected abstract string GetRestrictedAttachmentPath(int idx);

	[Token(Token = "0x6002EEE")]
	protected abstract string GetRestrictedAttachmentWeaponName(int idx);

	[Token(Token = "0x6002EEF")]
	protected abstract bool IsRestrictedAttachmentUnlocked(int idx);

	[Token(Token = "0x6002EF0")]
	[Address(RVA = "0x986D44", Offset = "0x986D44", VA = "0x986D44")]
	private List<SlotView> CreateSlots(WeaponUnlockable weapon)
	{
		return null;
	}

	[Token(Token = "0x6002EF1")]
	[Address(RVA = "0x98722C", Offset = "0x98722C", VA = "0x98722C")]
	protected List<CollectionItemView> CreateItemCollection()
	{
		return null;
	}

	[Token(Token = "0x6002EF2")]
	[Address(RVA = "0x987D78", Offset = "0x987D78", VA = "0x987D78")]
	protected WeaponCustomizationView()
	{
	}
}
