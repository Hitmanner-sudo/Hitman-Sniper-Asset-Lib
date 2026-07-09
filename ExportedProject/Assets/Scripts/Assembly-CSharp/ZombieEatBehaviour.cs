using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000118")]
public class ZombieEatBehaviour : AIBehaviour, TaskIdle.IListener
{
	[Token(Token = "0x4000627")]
	[FieldOffset(Offset = "0x38")]
	public Record Victim;

	[Token(Token = "0x4000628")]
	[FieldOffset(Offset = "0x40")]
	protected ThirdPersonCharacter PatientCharacter;

	[Token(Token = "0x4000629")]
	[FieldOffset(Offset = "0x48")]
	private AIController _patientAI;

	[Token(Token = "0x400062A")]
	[FieldOffset(Offset = "0x50")]
	private TaskIdle _task;

	[Token(Token = "0x400062B")]
	private const string TASK_ID = "EatMoveTo";

	[Token(Token = "0x400062C")]
	private const string PATIENT_TASK_ID = "GettingEaten";

	[Token(Token = "0x400062D")]
	[FieldOffset(Offset = "0x0")]
	public static string ATTACKERS_ID;

	[Token(Token = "0x400062E")]
	[FieldOffset(Offset = "0x8")]
	public static string ATTACKTOKENS_ID;

	[Token(Token = "0x400062F")]
	private const int MAX_TOKEN = 9;

	[Token(Token = "0x4000630")]
	private const float ANGLE_DIV = 40f;

	[Token(Token = "0x4000631")]
	private const float POS_PRECISION = 0.3f;

	[Token(Token = "0x4000632")]
	[FieldOffset(Offset = "0x58")]
	private int _tokenID;

	[Token(Token = "0x4000633")]
	[FieldOffset(Offset = "0x5C")]
	private bool _needNextValidToken;

	[Token(Token = "0x4000634")]
	[FieldOffset(Offset = "0x60")]
	private int _searchAddition;

	[Token(Token = "0x1700014C")]
	public new ZombieEatEvaluator Evaluator
	{
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x8810B0", Offset = "0x8810B0", VA = "0x8810B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007B3")]
	[Address(RVA = "0x88112C", Offset = "0x88112C", VA = "0x88112C", Slot = "5")]
	public override void Launch(AIController ai)
	{
	}

	[Token(Token = "0x60007B4")]
	[Address(RVA = "0x881584", Offset = "0x881584", VA = "0x881584")]
	private Vector3 GetTargetDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x8811F8", Offset = "0x8811F8", VA = "0x8811F8")]
	private void SelectNearestToken()
	{
	}

	[Token(Token = "0x60007B6")]
	[Address(RVA = "0x8817AC", Offset = "0x8817AC", VA = "0x8817AC")]
	private void FindNextValidToken()
	{
	}

	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x8818C8", Offset = "0x8818C8", VA = "0x8818C8")]
	private void IncrementTokenID()
	{
	}

	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x881620", Offset = "0x881620", VA = "0x881620")]
	private void AddValidToken()
	{
	}

	[Token(Token = "0x60007B9")]
	[Address(RVA = "0x88191C", Offset = "0x88191C", VA = "0x88191C")]
	private bool isValidPosition()
	{
		return default(bool);
	}

	[Token(Token = "0x60007BA")]
	[Address(RVA = "0x8819F8", Offset = "0x8819F8", VA = "0x8819F8")]
	private Vector3 GetTokenDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60007BB")]
	[Address(RVA = "0x881444", Offset = "0x881444", VA = "0x881444")]
	private void MoveToSpot()
	{
	}

	[Token(Token = "0x60007BC")]
	[Address(RVA = "0x881A50", Offset = "0x881A50", VA = "0x881A50")]
	private Vector3 GetTokenPosition(Vector3 normal)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60007BD")]
	[Address(RVA = "0x881AF8", Offset = "0x881AF8", VA = "0x881AF8")]
	private void UpdateTask()
	{
	}

	[Token(Token = "0x60007BE")]
	[Address(RVA = "0x881BD8", Offset = "0x881BD8", VA = "0x881BD8", Slot = "7")]
	public override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x60007BF")]
	[Address(RVA = "0x881CC8", Offset = "0x881CC8", VA = "0x881CC8")]
	protected void DoDamage()
	{
	}

	[Token(Token = "0x60007C0")]
	[Address(RVA = "0x882000", Offset = "0x882000", VA = "0x882000")]
	private void SpawnEffect(GameObject spawnEffectObject, bool attachToParent)
	{
	}

	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x882038", Offset = "0x882038", VA = "0x882038", Slot = "15")]
	private void TaskIdle_002EIListener_002EOnIdleComplete()
	{
	}

	[Token(Token = "0x60007C2")]
	[Address(RVA = "0x88203C", Offset = "0x88203C", VA = "0x88203C", Slot = "13")]
	private void TaskIdle_002EIListener_002EOnDestinationReached()
	{
	}

	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x88204C", Offset = "0x88204C", VA = "0x88204C", Slot = "16")]
	protected virtual void ArriveAtDestination()
	{
	}

	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x88222C", Offset = "0x88222C", VA = "0x88222C", Slot = "14")]
	private void TaskIdle_002EIListener_002EOnDestinationUnreacheable()
	{
	}

	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x882238", Offset = "0x882238", VA = "0x882238", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x60007C6")]
	[Address(RVA = "0x88265C", Offset = "0x88265C", VA = "0x88265C")]
	public ZombieEatBehaviour()
	{
	}
}
