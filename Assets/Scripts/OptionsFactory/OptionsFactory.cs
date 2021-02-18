using UnityEngine;

public class OptionsFactory
{
    private readonly OptionsConfiguration optionsConfiguration;

    public OptionsFactory(OptionsConfiguration optionConfiguration)
    {
        optionsConfiguration = optionConfiguration;
    }

    public Option Create(int countOption)
    {
        var prefab = optionsConfiguration.GetOptionPrefabById(countOption);

        return Object.Instantiate(prefab);
    }
}