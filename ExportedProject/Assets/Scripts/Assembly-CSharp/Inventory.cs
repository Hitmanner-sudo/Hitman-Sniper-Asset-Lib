using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000320")]
public class Inventory
{
	[Token(Token = "0x2000321")]
	public enum BoneID
	{
		[Token(Token = "0x400116D")]
		Hidden = 0,
		[Token(Token = "0x400116E")]
		LeftHand = 1,
		[Token(Token = "0x400116F")]
		RightHand = 2,
		[Token(Token = "0x4001170")]
		Belt = 3,
		[Token(Token = "0x4001171")]
		Head = 4
	}

	[Token(Token = "0x2000322")]
	public class ItemBrokenArgs : EventArgs
	{
		[Token(Token = "0x4001172")]
		[FieldOffset(Offset = "0x10")]
		public InventoryItem Prop;

		[Token(Token = "0x4001173")]
		[FieldOffset(Offset = "0x18")]
		public Damage Damage;

		[Token(Token = "0x6001334")]
		[Address(RVA = "0xB27960", Offset = "0xB27960", VA = "0xB27960")]
		public ItemBrokenArgs()
		{
		}
	}

	[Token(Token = "0x2000323")]
	public class EquipArgs : EventArgs
	{
		[Token(Token = "0x4001174")]
		[FieldOffset(Offset = "0x10")]
		public InventoryItem PreviousItem;

		[Token(Token = "0x4001175")]
		[FieldOffset(Offset = "0x18")]
		public InventoryItem NewItem;

		[Token(Token = "0x4001176")]
		[FieldOffset(Offset = "0x20")]
		public bool Dropped;

		[Token(Token = "0x6001335")]
		[Address(RVA = "0xB278FC", Offset = "0xB278FC", VA = "0xB278FC")]
		public EquipArgs()
		{
		}
	}

	[Token(Token = "0x2000324")]
	public class Bone
	{
		[Token(Token = "0x4001177")]
		[FieldOffset(Offset = "0x10")]
		public Transform Transform;

		[Token(Token = "0x4001178")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 Offset;

		[Token(Token = "0x4001179")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 Rotation;

		[Token(Token = "0x400117A")]
		[FieldOffset(Offset = "0x30")]
		public InventoryItem Item;

		[Token(Token = "0x6001336")]
		[Address(RVA = "0xB278B8", Offset = "0xB278B8", VA = "0xB278B8")]
		public Bone()
		{
		}
	}

	[Token(Token = "0x2000325")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5933C4", Offset = "0x5933C4")]
	private sealed class _003CDelayedUnequip_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400117B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400117C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400117D")]
		[FieldOffset(Offset = "0x20")]
		public float delayedTime;

		[Token(Token = "0x400117E")]
		[FieldOffset(Offset = "0x28")]
		public Inventory _003C_003E4__this;

		[Token(Token = "0x400117F")]
		[FieldOffset(Offset = "0x30")]
		public InventoryItem item;

		[Token(Token = "0x170002D0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600133A")]
			[Address(RVA = "0xB27868", Offset = "0xB27868", VA = "0xB27868", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002D1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600133C")]
			[Address(RVA = "0xB278B0", Offset = "0xB278B0", VA = "0xB278B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001337")]
		[Address(RVA = "0xB2768C", Offset = "0xB2768C", VA = "0xB2768C")]
		[DebuggerHidden]
		public _003CDelayedUnequip_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001338")]
		[Address(RVA = "0xB276B8", Offset = "0xB276B8", VA = "0xB276B8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001339")]
		[Address(RVA = "0xB276BC", Offset = "0xB276BC", VA = "0xB276BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600133B")]
		[Address(RVA = "0xB27870", Offset = "0xB27870", VA = "0xB27870", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000326")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5933D4", Offset = "0x5933D4")]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		[Token(Token = "0x4001180")]
		[FieldOffset(Offset = "0x10")]
		public string itemName;

		[Token(Token = "0x600133D")]
		[Address(RVA = "0xB2763C", Offset = "0xB2763C", VA = "0xB2763C")]
		public _003C_003Ec__DisplayClass28_0()
		{
		}

		[Token(Token = "0x600133E")]
		[Address(RVA = "0xB27644", Offset = "0xB27644", VA = "0xB27644")]
		internal bool _003CFindItem_003Eb__0(InventoryItem item)
		{
			return default(bool);
		}
	}

	[Serializable]
	[Token(Token = "0x2000327")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5933E4", Offset = "0x5933E4")]
	private sealed class _003C_003Ec__30<T> where T : InventoryItem
	{
		[Token(Token = "0x4001181")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec__30<T> _003C_003E9;

		[Token(Token = "0x4001182")]
		[FieldOffset(Offset = "0x0")]
		public static Predicate<InventoryItem> _003C_003E9__30_0;

		[Token(Token = "0x6001340")]
		public _003C_003Ec__30()
		{
		}

		[Token(Token = "0x6001341")]
		internal bool _003CEquipFirst_003Eb__30_0(InventoryItem item)
		{
			return default(bool);
		}
	}

	[Serializable]
	[Token(Token = "0x2000328")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5933F4", Offset = "0x5933F4")]
	private sealed class _003C_003Ec__32<T> where T : InventoryItem
	{
		[Token(Token = "0x4001183")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec__32<T> _003C_003E9;

		[Token(Token = "0x4001184")]
		[FieldOffset(Offset = "0x0")]
		public static Predicate<InventoryItem> _003C_003E9__32_0;

		[Token(Token = "0x6001343")]
		public _003C_003Ec__32()
		{
		}

		[Token(Token = "0x6001344")]
		internal bool _003CHas_003Eb__32_0(InventoryItem x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001166")]
	[FieldOffset(Offset = "0x10")]
	private List<InventoryItem> _items;

	[Token(Token = "0x4001167")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<BoneID, Bone> _ownerBones;

	[Token(Token = "0x4001168")]
	[FieldOffset(Offset = "0x20")]
	private MonoBehaviour _owner;

	[Token(Token = "0x4001169")]
	[FieldOffset(Offset = "0x28")]
	private Coroutine _delayedTimeCoroutine;

	[Token(Token = "0x14000053")]
	public event EventHandler<ItemBrokenArgs> OnItemBroken
	{
		[Token(Token = "0x600131D")]
		[Address(RVA = "0xB17668", Offset = "0xB17668", VA = "0xB17668")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616B34", Offset = "0x616B34")]
		add
		{
		}
		[Token(Token = "0x600131E")]
		[Address(RVA = "0xB17708", Offset = "0xB17708", VA = "0xB17708")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616B44", Offset = "0x616B44")]
		remove
		{
		}
	}

	[Token(Token = "0x14000054")]
	public event EventHandler<EquipArgs> OnItemEquipped
	{
		[Token(Token = "0x600131F")]
		[Address(RVA = "0xB177A8", Offset = "0xB177A8", VA = "0xB177A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616B54", Offset = "0x616B54")]
		add
		{
		}
		[Token(Token = "0x6001320")]
		[Address(RVA = "0xB17848", Offset = "0xB17848", VA = "0xB17848")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616B64", Offset = "0x616B64")]
		remove
		{
		}
	}

	[Token(Token = "0x6001321")]
	[Address(RVA = "0xB178E8", Offset = "0xB178E8", VA = "0xB178E8")]
	public Inventory(MonoBehaviour owner)
	{
	}

	[Token(Token = "0x6001322")]
	[Address(RVA = "0xB179B4", Offset = "0xB179B4", VA = "0xB179B4")]
	public bool Equip(InventoryItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x6001323")]
	[Address(RVA = "0xB17F44", Offset = "0xB17F44", VA = "0xB17F44")]
	public void Unequip(InventoryItem item, float delayedTime = 0f)
	{
	}

	[Token(Token = "0x6001324")]
	public void Unequip<T>() where T : InventoryItem
	{
	}

	[Token(Token = "0x6001325")]
	[Address(RVA = "0xB180DC", Offset = "0xB180DC", VA = "0xB180DC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x616B74", Offset = "0x616B74")]
	private IEnumerator DelayedUnequip(InventoryItem item, float delayedTime)
	{
		return null;
	}

	[Token(Token = "0x6001326")]
	[Address(RVA = "0xB17D5C", Offset = "0xB17D5C", VA = "0xB17D5C")]
	private void InternalUnequip(InventoryItem item)
	{
	}

	[Token(Token = "0x6001327")]
	[Address(RVA = "0xB17DF4", Offset = "0xB17DF4", VA = "0xB17DF4")]
	private void Attach(InventoryItem item, Bone bone)
	{
	}

	[Token(Token = "0x6001328")]
	[Address(RVA = "0xB17BAC", Offset = "0xB17BAC", VA = "0xB17BAC")]
	public void AddItem(InventoryItem item)
	{
	}

	[Token(Token = "0x6001329")]
	[Address(RVA = "0xB18270", Offset = "0xB18270", VA = "0xB18270")]
	public void Drop(BoneID[] bones)
	{
	}

	[Token(Token = "0x600132A")]
	[Address(RVA = "0xB18390", Offset = "0xB18390", VA = "0xB18390")]
	public void Drop(InventoryItem item)
	{
	}

	[Token(Token = "0x600132B")]
	[Address(RVA = "0xB18768", Offset = "0xB18768", VA = "0xB18768")]
	public void ItemBroken(InventoryItem item, Damage damage)
	{
	}

	[Token(Token = "0x600132C")]
	[Address(RVA = "0xB18818", Offset = "0xB18818", VA = "0xB18818")]
	public void AddBone(BoneID id, Bone bone)
	{
	}

	[Token(Token = "0x600132D")]
	[Address(RVA = "0xB18884", Offset = "0xB18884", VA = "0xB18884")]
	public List<InventoryItem> GetAllEquippedItems()
	{
		return null;
	}

	[Token(Token = "0x600132E")]
	[Address(RVA = "0xB1888C", Offset = "0xB1888C", VA = "0xB1888C")]
	public InventoryItem GetItem(BoneID id)
	{
		return null;
	}

	[Token(Token = "0x600132F")]
	[Address(RVA = "0xB188FC", Offset = "0xB188FC", VA = "0xB188FC")]
	public InventoryItem FindItem(string itemName)
	{
		return null;
	}

	[Token(Token = "0x6001330")]
	[Address(RVA = "0xB17B48", Offset = "0xB17B48", VA = "0xB17B48")]
	public bool Contains(InventoryItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x6001331")]
	public T EquipFirst<T>() where T : InventoryItem
	{
		return null;
	}

	[Token(Token = "0x6001332")]
	[Address(RVA = "0xB189EC", Offset = "0xB189EC", VA = "0xB189EC")]
	public InventoryItem EquipFirst(Predicate<InventoryItem> filter)
	{
		return null;
	}

	[Token(Token = "0x6001333")]
	public bool Has<T>() where T : InventoryItem
	{
		return default(bool);
	}
}
