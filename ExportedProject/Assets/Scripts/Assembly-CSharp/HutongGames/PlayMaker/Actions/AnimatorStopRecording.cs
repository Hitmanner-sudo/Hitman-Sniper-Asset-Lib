using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000ECB")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599EE0", Offset = "0x599EE0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599EE0", Offset = "0x599EE0")]
	public class AnimatorStopRecording : ComponentAction<Animator>
	{
		[Token(Token = "0x400460A")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C40A8", Offset = "0x5C40A8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C40A8", Offset = "0x5C40A8")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400460B")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ActionSection", RVA = "0x5C413C", Offset = "0x5C413C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C413C", Offset = "0x5C413C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C413C", Offset = "0x5C413C")]
		public FsmFloat recorderStartTime;

		[Token(Token = "0x400460C")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C41B0", Offset = "0x5C41B0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C41B0", Offset = "0x5C41B0")]
		public FsmFloat recorderStopTime;

		[Token(Token = "0x6005B53")]
		[Address(RVA = "0xD47CEC", Offset = "0xD47CEC", VA = "0xD47CEC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B54")]
		[Address(RVA = "0xD47CF8", Offset = "0xD47CF8", VA = "0xD47CF8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B55")]
		[Address(RVA = "0xD47DB8", Offset = "0xD47DB8", VA = "0xD47DB8")]
		public AnimatorStopRecording()
		{
		}
	}
}
