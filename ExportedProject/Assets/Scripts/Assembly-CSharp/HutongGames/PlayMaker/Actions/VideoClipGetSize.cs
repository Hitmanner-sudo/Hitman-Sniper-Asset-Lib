using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001288")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD354", Offset = "0x5AD354")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD354", Offset = "0x5AD354")]
	public class VideoClipGetSize : FsmStateAction
	{
		[Token(Token = "0x40058B2")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60C640", Offset = "0x60C640")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C640", Offset = "0x60C640")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40058B3")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C6C4", Offset = "0x60C6C4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60C6C4", Offset = "0x60C6C4")]
		public FsmObject orVideoClip;

		[Token(Token = "0x40058B4")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C714", Offset = "0x60C714")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60C714", Offset = "0x60C714")]
		public FsmInt width;

		[Token(Token = "0x40058B5")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60C764", Offset = "0x60C764")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C764", Offset = "0x60C764")]
		public FsmInt height;

		[Token(Token = "0x40058B6")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60C7B4", Offset = "0x60C7B4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C7B4", Offset = "0x60C7B4")]
		public FsmVector2 size;

		[Token(Token = "0x40058B7")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60C804", Offset = "0x60C804")]
		public bool everyFrame;

		[Token(Token = "0x40058B8")]
		[FieldOffset(Offset = "0x80")]
		private GameObject go;

		[Token(Token = "0x40058B9")]
		[FieldOffset(Offset = "0x88")]
		private VideoPlayer _vp;

		[Token(Token = "0x40058BA")]
		[FieldOffset(Offset = "0x90")]
		private VideoClip _vc;

		[Token(Token = "0x6006C2D")]
		[Address(RVA = "0x13CAF24", Offset = "0x13CAF24", VA = "0x13CAF24", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C2E")]
		[Address(RVA = "0x13CAF9C", Offset = "0x13CAF9C", VA = "0x13CAF9C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C2F")]
		[Address(RVA = "0x13CB268", Offset = "0x13CB268", VA = "0x13CB268", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C30")]
		[Address(RVA = "0x13CB140", Offset = "0x13CB140", VA = "0x13CB140")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006C31")]
		[Address(RVA = "0x13CAFE0", Offset = "0x13CAFE0", VA = "0x13CAFE0")]
		private void GetVideoClip()
		{
		}

		[Token(Token = "0x6006C32")]
		[Address(RVA = "0x13CB28C", Offset = "0x13CB28C", VA = "0x13CB28C")]
		public VideoClipGetSize()
		{
		}
	}
}
