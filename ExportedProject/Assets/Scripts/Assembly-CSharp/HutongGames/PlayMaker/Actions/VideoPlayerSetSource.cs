using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20012B9")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AE2A4", Offset = "0x5AE2A4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AE2A4", Offset = "0x5AE2A4")]
	public class VideoPlayerSetSource : FsmStateAction
	{
		[Token(Token = "0x40059BD")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x610228", Offset = "0x610228")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x610228", Offset = "0x610228")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40059BE")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6102BC", Offset = "0x6102BC")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x6102BC", Offset = "0x6102BC")]
		public FsmEnum source;

		[Token(Token = "0x40059BF")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x610350", Offset = "0x610350")]
		public bool everyFrame;

		[Token(Token = "0x40059C0")]
		[FieldOffset(Offset = "0x68")]
		private GameObject go;

		[Token(Token = "0x40059C1")]
		[FieldOffset(Offset = "0x70")]
		private VideoPlayer _vp;

		[Token(Token = "0x6006D4A")]
		[Address(RVA = "0x13D1188", Offset = "0x13D1188", VA = "0x13D1188", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006D4B")]
		[Address(RVA = "0x13D1194", Offset = "0x13D1194", VA = "0x13D1194", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006D4C")]
		[Address(RVA = "0x13D1370", Offset = "0x13D1370", VA = "0x13D1370", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006D4D")]
		[Address(RVA = "0x13D1290", Offset = "0x13D1290", VA = "0x13D1290")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006D4E")]
		[Address(RVA = "0x13D11D8", Offset = "0x13D11D8", VA = "0x13D11D8")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006D4F")]
		[Address(RVA = "0x13D1374", Offset = "0x13D1374", VA = "0x13D1374")]
		public VideoPlayerSetSource()
		{
		}
	}
}
