using Il2CppDummyDll;
using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200111E")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A58EC", Offset = "0x5A58EC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A58EC", Offset = "0x5A58EC")]
	public class MergeScenes : FsmStateAction
	{
		[Token(Token = "0x4005110")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ActionSection", RVA = "0x5F24D4", Offset = "0x5F24D4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F24D4", Offset = "0x5F24D4")]
		public GetSceneActionBase.SceneAllReferenceOptions sourceReference;

		[Token(Token = "0x4005111")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2534", Offset = "0x5F2534")]
		public FsmInt sourceAtIndex;

		[Token(Token = "0x4005112")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F256C", Offset = "0x5F256C")]
		public FsmString sourceByName;

		[Token(Token = "0x4005113")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F25A4", Offset = "0x5F25A4")]
		public FsmString sourceByPath;

		[Token(Token = "0x4005114")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F25DC", Offset = "0x5F25DC")]
		public FsmOwnerDefault sourceByGameObject;

		[Token(Token = "0x4005115")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ActionSection", RVA = "0x5F2614", Offset = "0x5F2614")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2614", Offset = "0x5F2614")]
		public GetSceneActionBase.SceneAllReferenceOptions destinationReference;

		[Token(Token = "0x4005116")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2674", Offset = "0x5F2674")]
		public FsmInt destinationAtIndex;

		[Token(Token = "0x4005117")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F26AC", Offset = "0x5F26AC")]
		public FsmString destinationByName;

		[Token(Token = "0x4005118")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F26E4", Offset = "0x5F26E4")]
		public FsmString destinationByPath;

		[Token(Token = "0x4005119")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F271C", Offset = "0x5F271C")]
		public FsmOwnerDefault destinationByGameObject;

		[Token(Token = "0x400511A")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F2754", Offset = "0x5F2754")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2754", Offset = "0x5F2754")]
		[Attribute(Name = "ActionSection", RVA = "0x5F2754", Offset = "0x5F2754")]
		public FsmBool success;

		[Token(Token = "0x400511B")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F27C8", Offset = "0x5F27C8")]
		public FsmEvent successEvent;

		[Token(Token = "0x400511C")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F2800", Offset = "0x5F2800")]
		public FsmEvent failureEvent;

		[Token(Token = "0x400511D")]
		[FieldOffset(Offset = "0xB0")]
		private Scene _sourceScene;

		[Token(Token = "0x400511E")]
		[FieldOffset(Offset = "0xB4")]
		private bool _sourceFound;

		[Token(Token = "0x400511F")]
		[FieldOffset(Offset = "0xB8")]
		private Scene _destinationScene;

		[Token(Token = "0x4005120")]
		[FieldOffset(Offset = "0xBC")]
		private bool _destinationFound;

		[Token(Token = "0x6006593")]
		[Address(RVA = "0x9C0090", Offset = "0x9C0090", VA = "0x9C0090", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006594")]
		[Address(RVA = "0x9C00B8", Offset = "0x9C00B8", VA = "0x9C00B8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006595")]
		[Address(RVA = "0x9C020C", Offset = "0x9C020C", VA = "0x9C020C")]
		private void GetSourceScene()
		{
		}

		[Token(Token = "0x6006596")]
		[Address(RVA = "0x9C044C", Offset = "0x9C044C", VA = "0x9C044C")]
		private void GetDestinationScene()
		{
		}

		[Token(Token = "0x6006597")]
		[Address(RVA = "0x9C068C", Offset = "0x9C068C", VA = "0x9C068C", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x6006598")]
		[Address(RVA = "0x9C0704", Offset = "0x9C0704", VA = "0x9C0704")]
		public MergeScenes()
		{
		}
	}
}
