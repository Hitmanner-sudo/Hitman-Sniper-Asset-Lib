using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using UnityEngine;

[Serializable]
[Token(Token = "0x20003BD")]
public class LootBox : ScriptableObject, ISaveable
{
	[Serializable]
	[Token(Token = "0x20003BE")]
	public struct ItemMapping
	{
		[Serializable]
		[Token(Token = "0x20003BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59362C", Offset = "0x59362C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400154B")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x600175A")]
			[Address(RVA = "0xA461D8", Offset = "0xA461D8", VA = "0xA461D8")]
			public _003C_003Ec()
			{
			}
		}

		[Token(Token = "0x4001545")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string ITEM_FIELD_NAME;

		[Token(Token = "0x4001546")]
		private const string ITEM_TYPE_KEY = "type";

		[Token(Token = "0x4001547")]
		private const string ITEM_VALUE_KEY = "value";

		[Token(Token = "0x4001548")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string DROP_RATE_FIELD_NAME;

		[Token(Token = "0x4001549")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private LootBoxItem _item;

		[Token(Token = "0x400154A")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B4E58", Offset = "0x5B4E58")]
		private float _dropRate;

		[Token(Token = "0x170003C0")]
		public LootBoxItem Item
		{
			[Token(Token = "0x6001754")]
			[Address(RVA = "0x8C3470", Offset = "0x8C3470", VA = "0x8C3470")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003C1")]
		public float DropRate
		{
			[Token(Token = "0x6001755")]
			[Address(RVA = "0x8C3478", Offset = "0x8C3478", VA = "0x8C3478")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6001756")]
		[Address(RVA = "0x8C3480", Offset = "0x8C3480", VA = "0x8C3480")]
		public void Restore(JSONNode data)
		{
		}

		[Token(Token = "0x6001757")]
		[Address(RVA = "0x8C35CC", Offset = "0x8C35CC", VA = "0x8C35CC")]
		private void DeserializeItem(JSONNode data)
		{
		}
	}

	[Token(Token = "0x20003C0")]
	public struct OverridableValue<TValue> : IEquatable<OverridableValue<TValue>> where TValue : UnityEngine.Object
	{
		[Token(Token = "0x400154C")]
		[FieldOffset(Offset = "0x0")]
		private readonly LazyReference<TValue> _value;

		[Token(Token = "0x400154D")]
		[FieldOffset(Offset = "0x0")]
		private LazyReference<TValue> _overrideValue;

		[Token(Token = "0x170003C2")]
		public TValue Value
		{
			[Token(Token = "0x600175B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003C3")]
		public TValue OverrideValue
		{
			[Token(Token = "0x600175C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003C4")]
		public TValue OriginalValue
		{
			[Token(Token = "0x600175D")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600175E")]
		public OverridableValue(LazyReference<TValue> value)
		{
		}

		[Token(Token = "0x600175F")]
		public void SetOverride(LazyReference<TValue> data)
		{
		}

		[Token(Token = "0x6001760")]
		public bool Equals(OverridableValue<TValue> other)
		{
			return default(bool);
		}

		[Token(Token = "0x6001761")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6001762")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Serializable]
	[Token(Token = "0x20003C1")]
	public struct VisualData : ISerializationCallbackReceiver
	{
		[Token(Token = "0x400154E")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private LazyGameObject _lootBox;

		[Token(Token = "0x400154F")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private LazyGameObject _uiVisual;

		[Token(Token = "0x4001550")]
		[FieldOffset(Offset = "0x10")]
		private OverridableValue<GameObject> _overridableLootBox;

		[Token(Token = "0x4001551")]
		[FieldOffset(Offset = "0x20")]
		private OverridableValue<GameObject> _overridableUIVisual;

		[Token(Token = "0x170003C5")]
		public OverridableValue<GameObject> LootBoxPrefab
		{
			[Token(Token = "0x6001763")]
			[Address(RVA = "0x8C3BB4", Offset = "0x8C3BB4", VA = "0x8C3BB4")]
			get
			{
				return default(OverridableValue<GameObject>);
			}
		}

		[Token(Token = "0x170003C6")]
		public OverridableValue<GameObject> UIVisual
		{
			[Token(Token = "0x6001764")]
			[Address(RVA = "0x8C3BC0", Offset = "0x8C3BC0", VA = "0x8C3BC0")]
			get
			{
				return default(OverridableValue<GameObject>);
			}
		}

		[Token(Token = "0x6001765")]
		[Address(RVA = "0x8C3BCC", Offset = "0x8C3BCC", VA = "0x8C3BCC")]
		public void SetOverride(VisualData data)
		{
		}

		[Token(Token = "0x6001766")]
		[Address(RVA = "0x8C3C24", Offset = "0x8C3C24", VA = "0x8C3C24")]
		public void ClearOverride()
		{
		}

		[Token(Token = "0x6001767")]
		[Address(RVA = "0x8C3C68", Offset = "0x8C3C68", VA = "0x8C3C68", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6001768")]
		[Address(RVA = "0x8C3C6C", Offset = "0x8C3C6C", VA = "0x8C3C6C", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20003C2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59363C", Offset = "0x59363C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001552")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001553")]
		[FieldOffset(Offset = "0x8")]
		public static Func<ItemMapping, LootBoxItem> _003C_003E9__23_0;

		[Token(Token = "0x600176A")]
		[Address(RVA = "0x8C3460", Offset = "0x8C3460", VA = "0x8C3460")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600176B")]
		[Address(RVA = "0x8C3468", Offset = "0x8C3468", VA = "0x8C3468")]
		internal LootBoxItem _003CCachePotentialDrop_003Eb__23_0(ItemMapping i)
		{
			return null;
		}
	}

	[Token(Token = "0x400153C")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string NAME_KEY;

	[Token(Token = "0x400153D")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string DROPPED_ITEMS_KEY;

	[Token(Token = "0x400153E")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string TYPE_KEY;

	[Token(Token = "0x400153F")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string VALUE_KEY;

	[Token(Token = "0x4001540")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string ITEMS_FIELD_NAME;

	[Token(Token = "0x4001541")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ItemMapping[] _items;

	[Token(Token = "0x4001542")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private VisualData _visual;

	[Token(Token = "0x4001543")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B4E38", Offset = "0x5B4E38")]
	private readonly List<LootBoxDroppedItem> _droppedItems;

	[Token(Token = "0x4001544")]
	[FieldOffset(Offset = "0x58")]
	private LootBoxItem[] _cachedPotentialDrop;

	[Token(Token = "0x170003BD")]
	public LootBoxItem[] PotentialDrop
	{
		[Token(Token = "0x6001744")]
		[Address(RVA = "0x9E0714", Offset = "0x9E0714", VA = "0x9E0714")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003BE")]
	public ReadOnlyCollection<LootBoxDroppedItem> DroppedItems
	{
		[Token(Token = "0x6001745")]
		[Address(RVA = "0x9E0870", Offset = "0x9E0870", VA = "0x9E0870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003BF")]
	public VisualData Visual
	{
		[Token(Token = "0x6001746")]
		[Address(RVA = "0x9E08C4", Offset = "0x9E08C4", VA = "0x9E08C4")]
		get
		{
			return default(VisualData);
		}
	}

	[Token(Token = "0x6001747")]
	[Address(RVA = "0x9C8634", Offset = "0x9C8634", VA = "0x9C8634")]
	public void Open(bool fromSkip = false)
	{
	}

	[Token(Token = "0x6001748")]
	[Address(RVA = "0x9E0AA4", Offset = "0x9E0AA4", VA = "0x9E0AA4")]
	private void MergeDroppedItems(IList<LootBoxDroppedItem> droppedItems)
	{
	}

	[Token(Token = "0x6001749")]
	[Address(RVA = "0x9E0D18", Offset = "0x9E0D18", VA = "0x9E0D18")]
	public void ApplyModifier(Func<LootBoxDroppedItem, IList<LootBoxDroppedItem>> modifier)
	{
	}

	[Token(Token = "0x600174A")]
	[Address(RVA = "0x9E0EB0", Offset = "0x9E0EB0", VA = "0x9E0EB0")]
	public void Claim()
	{
	}

	[Token(Token = "0x600174B")]
	[Address(RVA = "0x9E08D8", Offset = "0x9E08D8", VA = "0x9E08D8")]
	private static float GetDropModifier()
	{
		return default(float);
	}

	[Token(Token = "0x600174C")]
	[Address(RVA = "0x9E0728", Offset = "0x9E0728", VA = "0x9E0728")]
	private LootBoxItem[] CachePotentialDrop()
	{
		return null;
	}

	[Token(Token = "0x600174D")]
	[Address(RVA = "0x9E116C", Offset = "0x9E116C", VA = "0x9E116C", Slot = "4")]
	public void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x600174E")]
	[Address(RVA = "0x9E1248", Offset = "0x9E1248", VA = "0x9E1248")]
	private void DeserializeDroppedItems(JSONNode data)
	{
	}

	[Token(Token = "0x600174F")]
	[Address(RVA = "0x9E15B0", Offset = "0x9E15B0", VA = "0x9E15B0", Slot = "5")]
	public JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6001750")]
	[Address(RVA = "0x9E1860", Offset = "0x9E1860", VA = "0x9E1860")]
	public void RestoreForDDNAUpdate(JSONNode data)
	{
	}

	[Token(Token = "0x6001751")]
	[Address(RVA = "0x9E192C", Offset = "0x9E192C", VA = "0x9E192C")]
	private void DeserializeItems(JSONArray itemsNode)
	{
	}

	[Token(Token = "0x6001752")]
	[Address(RVA = "0x9E1AB4", Offset = "0x9E1AB4", VA = "0x9E1AB4")]
	public LootBox()
	{
	}
}
