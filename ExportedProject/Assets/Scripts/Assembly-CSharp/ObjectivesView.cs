using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006B2")]
public class ObjectivesView : View
{
	[Token(Token = "0x4002550")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UIAlignedList _objectivesUIAlignedList;

	[Token(Token = "0x4002551")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private int _offsetBetweenObjectivesElements;

	[Token(Token = "0x4002552")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private int _offsetAboveSeparator;

	[Token(Token = "0x4002553")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private int _offsetBelowSeparator;

	[Token(Token = "0x4002554")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject _objectiveViewPrefab;

	[Token(Token = "0x4002555")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject _objectiveViewParentGO;

	[Token(Token = "0x4002556")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UIPanel _objectivesUIPanel;

	[Token(Token = "0x4002557")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private UILabel _separatorUILabel;

	[Token(Token = "0x4002558")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private PointyTooltip _tooltip;

	[Token(Token = "0x4002559")]
	[FieldOffset(Offset = "0xA0")]
	private ObjectiveView _goal1ObjectiveView;

	[Token(Token = "0x400255A")]
	[FieldOffset(Offset = "0xA8")]
	private ObjectiveView _goal2ObjectiveView;

	[Token(Token = "0x400255B")]
	[FieldOffset(Offset = "0xB0")]
	private ObjectiveView _restrictionObjectiveView;

	[Token(Token = "0x400255C")]
	[FieldOffset(Offset = "0xB8")]
	private ObjectiveView _goal3ObjectiveView;

	[Token(Token = "0x400255D")]
	[FieldOffset(Offset = "0xC0")]
	private ObjectiveView _lastObjective;

	[Token(Token = "0x400255E")]
	[FieldOffset(Offset = "0xC8")]
	private MissionData _missionData;

	[Token(Token = "0x400255F")]
	[FieldOffset(Offset = "0xD0")]
	private AssignmentData _assignmentData;

	[Token(Token = "0x4002560")]
	[FieldOffset(Offset = "0xD8")]
	private bool _goal1Failed;

	[Token(Token = "0x4002561")]
	[FieldOffset(Offset = "0xD9")]
	private bool _goal2Failed;

	[Token(Token = "0x4002562")]
	[FieldOffset(Offset = "0xDA")]
	private bool _restrictionFailed;

	[Token(Token = "0x4002563")]
	[FieldOffset(Offset = "0xDB")]
	private bool _initDone;

	[Token(Token = "0x6002BD8")]
	[Address(RVA = "0x9EE04C", Offset = "0x9EE04C", VA = "0x9EE04C", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002BD9")]
	[Address(RVA = "0x9EE524", Offset = "0x9EE524", VA = "0x9EE524", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002BDA")]
	[Address(RVA = "0x9EE6E4", Offset = "0x9EE6E4", VA = "0x9EE6E4", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002BDB")]
	[Address(RVA = "0x9EE3EC", Offset = "0x9EE3EC", VA = "0x9EE3EC")]
	private void AddCallback()
	{
	}

	[Token(Token = "0x6002BDC")]
	[Address(RVA = "0x9EE5AC", Offset = "0x9EE5AC", VA = "0x9EE5AC")]
	private void RemoveCallback()
	{
	}

	[Token(Token = "0x6002BDD")]
	[Address(RVA = "0x9EE76C", Offset = "0x9EE76C", VA = "0x9EE76C", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002BDE")]
	[Address(RVA = "0x9EE114", Offset = "0x9EE114", VA = "0x9EE114")]
	private void InitData(bool showObjectives)
	{
	}

	[Token(Token = "0x6002BDF")]
	[Address(RVA = "0x9EECC4", Offset = "0x9EECC4", VA = "0x9EECC4")]
	private void CreateObjectiveView(ref ObjectiveView objectiveView, bool show, string name)
	{
	}

	[Token(Token = "0x6002BE0")]
	[Address(RVA = "0x9EEF58", Offset = "0x9EEF58", VA = "0x9EEF58")]
	private void SetSeparator()
	{
	}

	[Token(Token = "0x6002BE1")]
	[Address(RVA = "0x9EEF24", Offset = "0x9EEF24", VA = "0x9EEF24")]
	private void UpdateObjectives()
	{
	}

	[Token(Token = "0x6002BE2")]
	[Address(RVA = "0x9EF284", Offset = "0x9EF284", VA = "0x9EF284")]
	private void UpdateGoal1()
	{
	}

	[Token(Token = "0x6002BE3")]
	[Address(RVA = "0x9EF364", Offset = "0x9EF364", VA = "0x9EF364")]
	private void UpdateGoal2()
	{
	}

	[Token(Token = "0x6002BE4")]
	[Address(RVA = "0x9EF738", Offset = "0x9EF738", VA = "0x9EF738")]
	private void UpdateGoal(ObjectiveView objectiveView, string hudDescription, int[] hudDescriptionFormatNumber, string longDescription, int progress, int targetValue, bool showInGameProgressCounter, bool failed)
	{
	}

	[Token(Token = "0x6002BE5")]
	[Address(RVA = "0x9EF444", Offset = "0x9EF444", VA = "0x9EF444")]
	private void UpdateRestriction()
	{
	}

	[Token(Token = "0x6002BE6")]
	[Address(RVA = "0x9EF594", Offset = "0x9EF594", VA = "0x9EF594")]
	private void UpdateGoal3()
	{
	}

	[Token(Token = "0x6002BE7")]
	[Address(RVA = "0x9EF998", Offset = "0x9EF998", VA = "0x9EF998")]
	private string GetFormattedDescription(int[] hudFormatNumber, string description)
	{
		return null;
	}

	[Token(Token = "0x6002BE8")]
	[Address(RVA = "0x9EF1E8", Offset = "0x9EF1E8", VA = "0x9EF1E8")]
	private bool ShouldUpdateGoal(ObjectiveView objectiveView)
	{
		return default(bool);
	}

	[Token(Token = "0x6002BE9")]
	[Address(RVA = "0x9EFAD8", Offset = "0x9EFAD8", VA = "0x9EFAD8")]
	private void OnAssignmentProgressUpdated(object sender, MissionManager.AssignmentUpdateEventArgs args)
	{
	}

	[Token(Token = "0x6002BEA")]
	[Address(RVA = "0x9EFADC", Offset = "0x9EFADC", VA = "0x9EFADC")]
	private void OnContractEnded(object sender, ContractEndedArgs e)
	{
	}

	[Token(Token = "0x6002BEB")]
	[Address(RVA = "0x9EFAE0", Offset = "0x9EFAE0", VA = "0x9EFAE0")]
	private void OnAssignmentFailed(object sender, MissionManager.AssignmentUpdateEventArgs args)
	{
	}

	[Token(Token = "0x6002BEC")]
	[Address(RVA = "0x9EE3BC", Offset = "0x9EE3BC", VA = "0x9EE3BC")]
	private void OnShowPauseMenuChanged(HUDModel.PauseMenuState currentState)
	{
	}

	[Token(Token = "0x6002BED")]
	[Address(RVA = "0x9EEA98", Offset = "0x9EEA98", VA = "0x9EEA98")]
	private void OnObjectivesHighlightActiveChanged(bool active)
	{
	}

	[Token(Token = "0x6002BEE")]
	[Address(RVA = "0x9EEB68", Offset = "0x9EEB68", VA = "0x9EEB68")]
	private void OnShowTooltipChanged(bool show)
	{
	}

	[Token(Token = "0x6002BEF")]
	[Address(RVA = "0x9EEC38", Offset = "0x9EEC38", VA = "0x9EEC38")]
	private void OnTooltipTextChanged(string text)
	{
	}

	[Token(Token = "0x6002BF0")]
	[Address(RVA = "0x9EFBC0", Offset = "0x9EFBC0", VA = "0x9EFBC0")]
	public ObjectivesView()
	{
	}

	[Token(Token = "0x6002BF1")]
	[Address(RVA = "0x9EFBDC", Offset = "0x9EFBDC", VA = "0x9EFBDC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6204C8", Offset = "0x6204C8")]
	private void _003CUpdateGoal_003Eb__32_0()
	{
	}
}
