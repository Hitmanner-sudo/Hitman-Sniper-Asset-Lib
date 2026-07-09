using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200129B")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD944", Offset = "0x5AD944")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD944", Offset = "0x5AD944")]
	public class VideoPlayerGetIsPrepared : FsmStateAction
	{
		[Token(Token = "0x4005923")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60DF68", Offset = "0x60DF68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x60DF68", Offset = "0x60DF68")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005924")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60DFFC", Offset = "0x60DFFC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60DFFC", Offset = "0x60DFFC")]
		public FsmBool isPrepared;

		[Token(Token = "0x4005925")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E04C", Offset = "0x60E04C")]
		public FsmEvent isPreparedEvent;

		[Token(Token = "0x4005926")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E084", Offset = "0x60E084")]
		public FsmEvent isNotPreparedEvent;

		[Token(Token = "0x4005927")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60E0BC", Offset = "0x60E0BC")]
		public bool everyframe;

		[Token(Token = "0x4005928")]
		[FieldOffset(Offset = "0x78")]
		private GameObject go;

		[Token(Token = "0x4005929")]
		[FieldOffset(Offset = "0x80")]
		private VideoPlayer _vp;

		[Token(Token = "0x400592A")]
		[FieldOffset(Offset = "0x88")]
		private int _isPrepared;

		[Token(Token = "0x6006C9E")]
		[Address(RVA = "0x13CD750", Offset = "0x13CD750", VA = "0x13CD750", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C9F")]
		[Address(RVA = "0x13CD75C", Offset = "0x13CD75C", VA = "0x13CD75C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006CA0")]
		[Address(RVA = "0x13CD920", Offset = "0x13CD920", VA = "0x13CD920", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006CA1")]
		[Address(RVA = "0x13CD838", Offset = "0x13CD838", VA = "0x13CD838")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x6006CA2")]
		[Address(RVA = "0x13CD780", Offset = "0x13CD780", VA = "0x13CD780")]
		private void GetVideoPlayer()
		{
		}

		[Token(Token = "0x6006CA3")]
		[Address(RVA = "0x13CD924", Offset = "0x13CD924", VA = "0x13CD924")]
		public VideoPlayerGetIsPrepared()
		{
		}
	}
}
