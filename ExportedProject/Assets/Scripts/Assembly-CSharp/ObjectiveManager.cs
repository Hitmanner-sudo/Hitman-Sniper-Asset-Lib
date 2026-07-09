using System;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x200025D")]
[Scope]
public class ObjectiveManager : GameSingleton<ObjectiveManager>
{
	[Serializable]
	[Token(Token = "0x200025E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592DFC", Offset = "0x592DFC")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000D2A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000D2B")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<ObjectiveTagBase> _003C_003E9__15_0;

		[Token(Token = "0x6000E46")]
		[Address(RVA = "0x8CD2E4", Offset = "0x8CD2E4", VA = "0x8CD2E4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000E47")]
		[Address(RVA = "0x8CD2EC", Offset = "0x8CD2EC", VA = "0x8CD2EC")]
		internal bool _003CActiveMainTargetObjective_003Eb__15_0(ObjectiveTagBase r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200025F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592E0C", Offset = "0x592E0C")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x4000D2C")]
		[FieldOffset(Offset = "0x10")]
		public TargetType targetType;

		[Token(Token = "0x6000E48")]
		[Address(RVA = "0x8CD344", Offset = "0x8CD344", VA = "0x8CD344")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[Token(Token = "0x6000E49")]
		[Address(RVA = "0x8CD34C", Offset = "0x8CD34C", VA = "0x8CD34C")]
		internal bool _003CGameUpdate_003Eb__0(ObjectiveTagBase r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000D24")]
	[FieldOffset(Offset = "0x48")]
	private AssignmentData _assignmentData;

	[Token(Token = "0x4000D25")]
	[FieldOffset(Offset = "0x50")]
	private int _objectivesGroupID;

	[Token(Token = "0x4000D26")]
	[FieldOffset(Offset = "0x54")]
	private bool _isActive;

	[Token(Token = "0x4000D27")]
	[FieldOffset(Offset = "0x58")]
	private ObjectiveTagBase _currentObjectiveTag;

	[Token(Token = "0x4000D28")]
	[FieldOffset(Offset = "0x60")]
	private bool _dirtyTag;

	[Token(Token = "0x4000D29")]
	[FieldOffset(Offset = "0x61")]
	private bool _playerSpawned;

	[Token(Token = "0x6000E2F")]
	[Address(RVA = "0x9E9B60", Offset = "0x9E9B60", VA = "0x9E9B60", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000E30")]
	[Address(RVA = "0x9EA0D4", Offset = "0x9EA0D4", VA = "0x9EA0D4", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000E31")]
	[Address(RVA = "0x9EA1D4", Offset = "0x9EA1D4", VA = "0x9EA1D4")]
	private void UnbindEvents()
	{
	}

	[Token(Token = "0x6000E32")]
	[Address(RVA = "0x9EA428", Offset = "0x9EA428", VA = "0x9EA428")]
	private void OnPlayerAdded(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6000E33")]
	[Address(RVA = "0x9E9CD0", Offset = "0x9E9CD0", VA = "0x9E9CD0")]
	private void StartObjectives()
	{
	}

	[Token(Token = "0x6000E34")]
	[Address(RVA = "0x9EA45C", Offset = "0x9EA45C", VA = "0x9EA45C")]
	private void StopObjectives()
	{
	}

	[Token(Token = "0x6000E35")]
	[Address(RVA = "0x9EA578", Offset = "0x9EA578", VA = "0x9EA578")]
	private void OnObjectiveTagAdded(ObjectiveTagBase objectiveTag)
	{
	}

	[Token(Token = "0x6000E36")]
	[Address(RVA = "0x9EA584", Offset = "0x9EA584", VA = "0x9EA584")]
	private void OnObjectiveTagRemoved(ObjectiveTagBase objectiveTag)
	{
	}

	[Token(Token = "0x6000E37")]
	[Address(RVA = "0x9EA434", Offset = "0x9EA434", VA = "0x9EA434")]
	private static void OnTrackableTagAdded(Trackable trackable)
	{
	}

	[Token(Token = "0x6000E38")]
	[Address(RVA = "0x9EA60C", Offset = "0x9EA60C", VA = "0x9EA60C")]
	private void ActiveMainTargetObjective()
	{
	}

	[Token(Token = "0x6000E39")]
	[Address(RVA = "0x9EA808", Offset = "0x9EA808", VA = "0x9EA808", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6000E3A")]
	[Address(RVA = "0x9EABEC", Offset = "0x9EABEC", VA = "0x9EABEC")]
	private void OnAssignmentCompleted(object sender, MissionManager.AssignmentUpdateEventArgs args)
	{
	}

	[Token(Token = "0x6000E3B")]
	[Address(RVA = "0x9EAC78", Offset = "0x9EAC78", VA = "0x9EAC78")]
	private void OnSubAssignmentCompleted(object sender, MissionManager.AssignmentUpdateEventArgs args)
	{
	}

	[Token(Token = "0x6000E3C")]
	[Address(RVA = "0x9EAC7C", Offset = "0x9EAC7C", VA = "0x9EAC7C")]
	private void OnAssignmentFailed(object sender, MissionManager.AssignmentUpdateEventArgs args)
	{
	}

	[Token(Token = "0x6000E3D")]
	[Address(RVA = "0x9EABF0", Offset = "0x9EABF0", VA = "0x9EABF0")]
	private void OnAssignmentUpdate()
	{
	}

	[Token(Token = "0x6000E3E")]
	[Address(RVA = "0x9EAC80", Offset = "0x9EAC80", VA = "0x9EAC80")]
	private bool IsSubTargetCompleted(TargetGroup targetGroup)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E3F")]
	[Address(RVA = "0x9EACF8", Offset = "0x9EACF8", VA = "0x9EACF8")]
	private void DeactivateTags()
	{
	}

	[Token(Token = "0x6000E40")]
	[Address(RVA = "0x9EAD8C", Offset = "0x9EAD8C", VA = "0x9EAD8C")]
	public bool IsTargetTypeUsed(TargetType targetType)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E41")]
	[Address(RVA = "0x9EAEB4", Offset = "0x9EAEB4", VA = "0x9EAEB4")]
	public bool IsTargetTypeUsed(TargetType[] targetType)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E42")]
	[Address(RVA = "0x9EAF3C", Offset = "0x9EAF3C", VA = "0x9EAF3C")]
	public bool NeedToDelaySpawn(Spawner spawner)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E43")]
	[Address(RVA = "0x9EB0D4", Offset = "0x9EB0D4", VA = "0x9EB0D4")]
	public bool IsSpawnDelay()
	{
		return default(bool);
	}

	[Token(Token = "0x6000E44")]
	[Address(RVA = "0x9EB170", Offset = "0x9EB170", VA = "0x9EB170")]
	public ObjectiveManager()
	{
	}
}
