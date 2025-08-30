using System.Collections;
using UnityEngine;


public class FlowOfInstructions : MonoBehaviour
{
    public PPEInstruction[] instructions; // Assign your PPE steps in Inspector
    public AudioSource narrator;          // Plays narration audio
    public float delayAfterStep;     // Small delay before moving to next step

    private Animator animator;

    void Start()
    {
        StartCoroutine(PlayPPEFlow());
    }

    IEnumerator PlayPPEFlow()
    {
        foreach (var step in instructions)
        {
            yield return new WaitForSeconds(delayAfterStep);
            Debug.Log(step.narration);
            step.Instruction.SetActive(true);
            yield return new WaitForSeconds(delayAfterStep);
        }

        Debug.Log("PPE Flow completed.");
    }
}
