using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FF9")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59FBD8", Offset = "0x59FBD8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59FBD8", Offset = "0x59FBD8")]
	public class GetKeyDown : FsmStateAction
	{
		[Token(Token = "0x4004AFE")]
		[FieldOffset(Offset = "0x4C")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8AF8", Offset = "0x5D8AF8")]
		public KeyCode key;

		[Token(Token = "0x4004AFF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8B44", Offset = "0x5D8B44")]
		public FsmEvent sendEvent;

		[Token(Token = "0x4004B00")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8B7C", Offset = "0x5D8B7C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D8B7C", Offset = "0x5D8B7C")]
		public FsmBool storeResult;

		[Token(Token = "0x600601E")]
		[Address(RVA = "0x1063A80", Offset = "0x1063A80", VA = "0x1063A80", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600601F")]
		[Address(RVA = "0x1063A90", Offset = "0x1063A90", VA = "0x1063A90", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006020")]
		[Address(RVA = "0x1063AEC", Offset = "0x1063AEC", VA = "0x1063AEC")]
		public GetKeyDown()
		{
		}
	}
}
