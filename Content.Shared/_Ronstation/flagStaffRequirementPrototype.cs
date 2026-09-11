using Robust.Shared.Prototypes;

namespace Content.Shared._Ronstation;

[Prototype("flagStaffRequirementPrototype")]
public sealed partial class flagStaffRequirementPrototype : IPrototype
{
    [ViewVariables]
    [IdDataField]
    public string ID { get; private set; } = default!;

    [DataField]
    public ulong[] Roles { get; set; } = [];

}
