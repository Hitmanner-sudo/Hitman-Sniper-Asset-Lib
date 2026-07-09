using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012B8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AE254", Offset = "0x5AE254")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AE254", Offset = "0x5AE254")]
	public class VideoPlayerSetSkipOnDrop : FsmStateAction
	{
		[Token(Token = "0x40059B8")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x610110", Offset = "0x610110")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x610110", Offset = "0x610110")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40059B9")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6101A4", Offset = "0x6101A4")]
		public FsmBool skipOnDrop;

		[Token(Token = "0x40059BA")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6101F0", Offset = "0x6101F0")]
		public bool everyFrame;

		[Token(Token = "0x40059BB")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x40059BC")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D44")]
		[Address(RVA = "0x13D0FCC", Offset = "0x13D0FCC", VA = "0x13D0FCC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D45")]
		[Address(RVA = "0x13D0FD8", Offset = "0x13D0FD8", VA = "0x13D0FD8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D46")]
		[Address(RVA = "0x13D117C", Offset = "0x13D117C", VA = "0x13D117C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006D47")]
		[Address(RVA = "0x13D10D4", Offset = "0x13D10D4", VA = "0x13D10D4")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006D48")]
		[Address(RVA = "0x13D101C", Offset = "0x13D101C", VA = "0x13D101C")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D49")]
		[Address(RVA = "0x13D1180", Offset = "0x13D1180", VA = "0x13D1180")]
		public VideoPlayerSetSkipOnDrop()
		{
		}
	}
}
