using UnityEngine;

public abstract class Option : MonoBehaviour
{
    [SerializeField] protected int numberOfOption;

    public int CountOption => numberOfOption;
}