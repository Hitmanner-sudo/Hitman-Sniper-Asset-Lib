using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200100B")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0124", Offset = "0x5A0124")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0124", Offset = "0x5A0124")]
	public class DontDestroyOnLoad : FsmStateAction
	{
		[Token(Token = "0x4004B5F")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA1F4", Offset = "0x5DA1F4")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x6006067")]
		[Address(RVA = "0xC188F4", Offset = "0xC188F4", VA = "0xC188F4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006068")]
		[Address(RVA = "0xC188FC", Offset = "0xC188FC", VA = "0xC188FC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006069")]
		[Address(RVA = "0xC189F0", Offset = "0xC189F0", VA = "0xC189F0")]
		public DontDestroyOnLoad()
		{
		}
	}
}
