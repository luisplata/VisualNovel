using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Bell/OptionsConfiguration")]
public class OptionsConfiguration : ScriptableObject
{
    [SerializeField] private Option[] options;
    private Dictionary<int, Option> idToOption;

    private void Awake()
    {
        idToOption = new Dictionary<int, Option>(options.Length);
        foreach (var option in options)
        {
            idToOption.Add(option.CountOption, option);
        }
    }

    public Option GetOptionPrefabById(int optionCount)
    {
        if (!idToOption.TryGetValue(optionCount, out var option))
        {
            throw new FindOptionException($"PowerUp with id {optionCount} does not exit");
        }
        return option;
    }
}