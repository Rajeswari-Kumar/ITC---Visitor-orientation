using UnityEngine;

[CreateAssetMenu(fileName = "PPEInstructionSO", menuName = "Safety/PPE Instruction", order = 1)]
public class PPEInstruction : ScriptableObject
{
    [TextArea(2, 4)]
    public string narration;           
    public GameObject Instruction;    
}
