using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core;
using UnityEngine;

[Token(Token = "0x2000812")]
[Attribute(Name = "ResourcePathAttribute", RVA = "0x596664", Offset = "0x596664")]
public class DDNAMappingManager : ScriptableSingleton<DDNAMappingManager>
{
	[Token(Token = "0x4002CE8")]
	private const string OFFER_ID_KEY = "offer_id_mapping";

	[Token(Token = "0x4002CE9")]
	private const string WEAPON_PATH_KEY = "weapon_path_mapping";

	[Token(Token = "0x4002CEA")]
	private const string GIFT_KEY = "gift_mapping";

	[Token(Token = "0x4002CEB")]
	private const string DATABASE_ID = "ddna_override_mappings";

	[Token(Token = "0x4002CEC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string _persistenceKey;

	[Token(Token = "0x4002CED")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private DDNAMapping _offerIdMapping;

	[Token(Token = "0x4002CEE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private DDNAMapping _weaponPathMapping;

	[Token(Token = "0x4002CEF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private DDNAMapping _giftMapping;

	[Token(Token = "0x170006B9")]
	public DDNAMapping OfferIdMapping
	{
		[Token(Token = "0x6003486")]
		[Address(RVA = "0xBD3E20", Offset = "0xBD3E20", VA = "0xBD3E20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006BA")]
	public DDNAMapping WeaponPathMapping
	{
		[Token(Token = "0x6003487")]
		[Address(RVA = "0xBD3E28", Offset = "0xBD3E28", VA = "0xBD3E28")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006BB")]
	public DDNAMapping GiftMapping
	{
		[Token(Token = "0x6003488")]
		[Address(RVA = "0xBD3E30", Offset = "0xBD3E30", VA = "0xBD3E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003489")]
	[Address(RVA = "0xBD3E38", Offset = "0xBD3E38", VA = "0xBD3E38", Slot = "4")]
	protected override void Initialize()
	{
	}

	[Token(Token = "0x600348A")]
	[Address(RVA = "0xBD3F98", Offset = "0xBD3F98", VA = "0xBD3F98")]
	public void GetOverrideMappings()
	{
	}

	[Token(Token = "0x600348B")]
	[Address(RVA = "0xBD407C", Offset = "0xBD407C", VA = "0xBD407C")]
	private void OnGetDatabaseComplete(JSONNode valueNode)
	{
	}

	[Token(Token = "0x600348C")]
	[Address(RVA = "0xBD419C", Offset = "0xBD419C", VA = "0xBD419C")]
	private void Save()
	{
	}

	[Token(Token = "0x600348D")]
	[Address(RVA = "0xBD3E3C", Offset = "0xBD3E3C", VA = "0xBD3E3C")]
	private void Load()
	{
	}

	[Token(Token = "0x600348E")]
	[Address(RVA = "0xBD4300", Offset = "0xBD4300", VA = "0xBD4300")]
	public DDNAMappingManager()
	{
	}
}
