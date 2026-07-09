using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200063C")]
public class ActiveZombieView : View
{
	[Serializable]
	[Token(Token = "0x200063D")]
	public class UIGridElementData
	{
		[Token(Token = "0x4002253")]
		[FieldOffset(Offset = "0x10")]
		public Faction Faction;

		[Token(Token = "0x4002254")]
		[FieldOffset(Offset = "0x18")]
		public LazyUIAtlas IconAtlas;

		[Token(Token = "0x4002255")]
		[FieldOffset(Offset = "0x20")]
		public string IconName;

		[Token(Token = "0x4002256")]
		[FieldOffset(Offset = "0x28")]
		public LazyUIAtlas BackgroundAtlas;

		[Token(Token = "0x4002257")]
		[FieldOffset(Offset = "0x30")]
		public string BackgroundName;

		[Token(Token = "0x4002258")]
		[FieldOffset(Offset = "0x38")]
		public Color BackgroundColor;

		[NonSerialized]
		[Token(Token = "0x4002259")]
		[FieldOffset(Offset = "0x48")]
		public ActiveZombieElementView ActiveZombieElementView;

		[NonSerialized]
		[Token(Token = "0x400225A")]
		[FieldOffset(Offset = "0x50")]
		public int CurrentZombieAmount;

		[Token(Token = "0x6002845")]
		[Address(RVA = "0x9124A8", Offset = "0x9124A8", VA = "0x9124A8")]
		public UIGridElementData()
		{
		}
	}

	[Token(Token = "0x200063E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595718", Offset = "0x595718")]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x400225B")]
		[FieldOffset(Offset = "0x10")]
		public Faction faction;

		[Token(Token = "0x6002846")]
		[Address(RVA = "0x912458", Offset = "0x912458", VA = "0x912458")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6002847")]
		[Address(RVA = "0x912460", Offset = "0x912460", VA = "0x912460")]
		internal bool _003CSetElement_003Eb__0(ActiveZombieElementView x)
		{
			return default(bool);
		}

		[Token(Token = "0x6002848")]
		[Address(RVA = "0x912484", Offset = "0x912484", VA = "0x912484")]
		internal bool _003CSetElement_003Eb__1(ActiveZombieElementView x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400224F")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UIGrid _uiGrid;

	[Token(Token = "0x4002250")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject _uiGridElementPrefab;

	[Token(Token = "0x4002251")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<ActiveZombieElementView> _uiGridElements;

	[Token(Token = "0x4002252")]
	[FieldOffset(Offset = "0x78")]
	public ZombieProperties ZombieTable;

	[Token(Token = "0x600283C")]
	[Address(RVA = "0xD5B644", Offset = "0xD5B644", VA = "0xD5B644", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600283D")]
	[Address(RVA = "0xD5B798", Offset = "0xD5B798", VA = "0xD5B798", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600283E")]
	[Address(RVA = "0xD5B8E0", Offset = "0xD5B8E0", VA = "0xD5B8E0", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x600283F")]
	[Address(RVA = "0xD5B75C", Offset = "0xD5B75C", VA = "0xD5B75C")]
	private void ShowUI(bool show)
	{
	}

	[Token(Token = "0x6002840")]
	[Address(RVA = "0xD5B9D0", Offset = "0xD5B9D0", VA = "0xD5B9D0")]
	private void SetElement(Faction faction, int increaseAmount)
	{
	}

	[Token(Token = "0x6002841")]
	[Address(RVA = "0xD5BD74", Offset = "0xD5BD74", VA = "0xD5BD74")]
	private void OnDied(object sender, Character.DeathEvent e)
	{
	}

	[Token(Token = "0x6002842")]
	[Address(RVA = "0xD5BE8C", Offset = "0xD5BE8C", VA = "0xD5BE8C")]
	private void OnGlobalOnSpawn(object sender, Spawner.SpawnerEventArgs e)
	{
	}

	[Token(Token = "0x6002843")]
	[Address(RVA = "0xD5BD90", Offset = "0xD5BD90", VA = "0xD5BD90")]
	private void SetElementData(Character character, int increaseAmount)
	{
	}

	[Token(Token = "0x6002844")]
	[Address(RVA = "0xD5BEA8", Offset = "0xD5BEA8", VA = "0xD5BEA8")]
	public ActiveZombieView()
	{
	}
}
