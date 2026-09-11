using Robust.Shared.Prototypes;

namespace Content.Shared._Ronstation;

[Prototype("flagMentorRequirementPrototype")]
public sealed partial class flagMentorRequirementPrototype : IPrototype
{
    [ViewVariables]
    [IdDataField]
    public string ID { get; private set; } = default!;

    [DataField]
    public ulong[] Roles { get; set; } = [];

}
