using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Server.Sound;

[RegisterComponent]
public sealed partial class PlaySoundOnUseComponent : Component
{
    [DataField]
    public string Sound = string.Empty;
}
