using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001235")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ABA04", Offset = "0x5ABA04")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ABA04", Offset = "0x5ABA04")]
	public class UiRawImageSetTexture : ComponentAction<RawImage>
	{
		[Token(Token = "0x400572F")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606B34", Offset = "0x606B34")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x606B34", Offset = "0x606B34")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005730")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606BC8", Offset = "0x606BC8")]
		public FsmTexture texture;

		[Token(Token = "0x4005731")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606C14", Offset = "0x606C14")]
		public FsmBool resetOnExit;

		[Token(Token = "0x4005732")]
		[FieldOffset(Offset = "0x80")]
		private RawImage _texture;

		[Token(Token = "0x4005733")]
		[FieldOffset(Offset = "0x88")]
		private Texture _originalTexture;

		[Token(Token = "0x6006AA5")]
		[Address(RVA = "0xB954FC", Offset = "0xB954FC", VA = "0xB954FC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006AA6")]
		[Address(RVA = "0xB95508", Offset = "0xB95508", VA = "0xB95508", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006AA7")]
		[Address(RVA = "0xB955A8", Offset = "0xB955A8", VA = "0xB955A8")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x6006AA8")]
		[Address(RVA = "0xB95650", Offset = "0xB95650", VA = "0xB95650", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006AA9")]
		[Address(RVA = "0xB956F8", Offset = "0xB956F8", VA = "0xB956F8")]
		public UiRawImageSetTexture()
		{
		}
	}
}
