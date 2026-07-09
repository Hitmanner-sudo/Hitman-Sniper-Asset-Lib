using Il2CppDummyDll;

[Token(Token = "0x20005D9")]
public class WeaponCustomizationModel : DataModel
{
	[Token(Token = "0x4001FA0")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string WEAPON_SAVE_DATA;

	[Token(Token = "0x4001FA1")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string PARENT_BLUEPRINT_VIEW;

	[Token(Token = "0x4001FA2")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string CURRENT_SELECTED_SLOT;

	[Token(Token = "0x4001FA3")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string INITIALLY_SELECTED_SLOT_INDEX;

	[Token(Token = "0x4001FA4")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string REFRESH_COLLECTION_ITEMS;

	[Token(Token = "0x4001FA5")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string CURRENT_SELECTED_COLLECTION_ITEM;

	[Token(Token = "0x4001FA6")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string LEFT_ARROW_CLICKED;

	[Token(Token = "0x4001FA7")]
	[FieldOffset(Offset = "0x38")]
	public static readonly string RIGHT_ARROW_CLICKED;

	[Token(Token = "0x4001FA8")]
	[FieldOffset(Offset = "0x48")]
	private WeaponUnlockableSaveData _weaponSaveData;

	[Token(Token = "0x4001FA9")]
	[FieldOffset(Offset = "0x50")]
	private BlueprintItemView _parentBlueprintView;

	[Token(Token = "0x4001FAA")]
	[FieldOffset(Offset = "0x58")]
	private SelectedSlot _currentSelectedSlot;

	[Token(Token = "0x4001FAB")]
	[FieldOffset(Offset = "0x60")]
	private int _initiallySelected;

	[Token(Token = "0x4001FAC")]
	[FieldOffset(Offset = "0x64")]
	private bool _refreshCollectionItems;

	[Token(Token = "0x4001FAD")]
	[FieldOffset(Offset = "0x68")]
	private SelectedSlot _currentSelectedCollectionItem;

	[Token(Token = "0x4001FAE")]
	[FieldOffset(Offset = "0x70")]
	private bool _leftArrowClicked;

	[Token(Token = "0x4001FAF")]
	[FieldOffset(Offset = "0x71")]
	private bool _rightArrowClicked;

	[Token(Token = "0x6002593")]
	[Address(RVA = "0x984944", Offset = "0x984944", VA = "0x984944", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x6002594")]
	[Address(RVA = "0x984EF0", Offset = "0x984EF0", VA = "0x984EF0")]
	public WeaponCustomizationModel()
	{
	}

	[Token(Token = "0x6002596")]
	[Address(RVA = "0x985040", Offset = "0x985040", VA = "0x985040")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BED0", Offset = "0x61BED0")]
	private object _003CBindAllVariables_003Eb__16_0()
	{
		return null;
	}

	[Token(Token = "0x6002597")]
	[Address(RVA = "0x985048", Offset = "0x985048", VA = "0x985048")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BEE0", Offset = "0x61BEE0")]
	private void _003CBindAllVariables_003Eb__16_1(object a)
	{
	}

	[Token(Token = "0x6002598")]
	[Address(RVA = "0x9850D4", Offset = "0x9850D4", VA = "0x9850D4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BEF0", Offset = "0x61BEF0")]
	private object _003CBindAllVariables_003Eb__16_2()
	{
		return null;
	}

	[Token(Token = "0x6002599")]
	[Address(RVA = "0x9850DC", Offset = "0x9850DC", VA = "0x9850DC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BF00", Offset = "0x61BF00")]
	private void _003CBindAllVariables_003Eb__16_3(object a)
	{
	}

	[Token(Token = "0x600259A")]
	[Address(RVA = "0x985168", Offset = "0x985168", VA = "0x985168")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BF10", Offset = "0x61BF10")]
	private object _003CBindAllVariables_003Eb__16_4()
	{
		return null;
	}

	[Token(Token = "0x600259B")]
	[Address(RVA = "0x985170", Offset = "0x985170", VA = "0x985170")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BF20", Offset = "0x61BF20")]
	private void _003CBindAllVariables_003Eb__16_5(object a)
	{
	}

	[Token(Token = "0x600259C")]
	[Address(RVA = "0x9851FC", Offset = "0x9851FC", VA = "0x9851FC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BF30", Offset = "0x61BF30")]
	private int _003CBindAllVariables_003Eb__16_6()
	{
		return default(int);
	}

	[Token(Token = "0x600259D")]
	[Address(RVA = "0x985204", Offset = "0x985204", VA = "0x985204")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BF40", Offset = "0x61BF40")]
	private void _003CBindAllVariables_003Eb__16_7(int a)
	{
	}

	[Token(Token = "0x600259E")]
	[Address(RVA = "0x98520C", Offset = "0x98520C", VA = "0x98520C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BF50", Offset = "0x61BF50")]
	private bool _003CBindAllVariables_003Eb__16_8()
	{
		return default(bool);
	}

	[Token(Token = "0x600259F")]
	[Address(RVA = "0x985214", Offset = "0x985214", VA = "0x985214")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BF60", Offset = "0x61BF60")]
	private void _003CBindAllVariables_003Eb__16_9(bool a)
	{
	}

	[Token(Token = "0x60025A0")]
	[Address(RVA = "0x985220", Offset = "0x985220", VA = "0x985220")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BF70", Offset = "0x61BF70")]
	private object _003CBindAllVariables_003Eb__16_10()
	{
		return null;
	}

	[Token(Token = "0x60025A1")]
	[Address(RVA = "0x985228", Offset = "0x985228", VA = "0x985228")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BF80", Offset = "0x61BF80")]
	private void _003CBindAllVariables_003Eb__16_11(object a)
	{
	}

	[Token(Token = "0x60025A2")]
	[Address(RVA = "0x9852B4", Offset = "0x9852B4", VA = "0x9852B4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BF90", Offset = "0x61BF90")]
	private bool _003CBindAllVariables_003Eb__16_12()
	{
		return default(bool);
	}

	[Token(Token = "0x60025A3")]
	[Address(RVA = "0x9852BC", Offset = "0x9852BC", VA = "0x9852BC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BFA0", Offset = "0x61BFA0")]
	private void _003CBindAllVariables_003Eb__16_13(bool a)
	{
	}

	[Token(Token = "0x60025A4")]
	[Address(RVA = "0x9852C8", Offset = "0x9852C8", VA = "0x9852C8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BFB0", Offset = "0x61BFB0")]
	private bool _003CBindAllVariables_003Eb__16_14()
	{
		return default(bool);
	}

	[Token(Token = "0x60025A5")]
	[Address(RVA = "0x9852D0", Offset = "0x9852D0", VA = "0x9852D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BFC0", Offset = "0x61BFC0")]
	private void _003CBindAllVariables_003Eb__16_15(bool a)
	{
	}
}
