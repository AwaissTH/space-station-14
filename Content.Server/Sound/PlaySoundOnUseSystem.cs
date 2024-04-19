using Content.Shared.Interaction.Events;
using JetBrains.Annotations;
using Robust.Shared.Audio.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Server.Sound;

public sealed class PlaySoundOnUseSystem : EntitySystem
{
    [Dependency] private readonly SharedAudioSystem _audio = default!;


    public override void Initialize()
    {
        SubscribeLocalEvent<PlaySoundOnUseComponent, UseInHandEvent>(OnUseInHand);
    }

    private void OnUseInHand(Entity<PlaySoundOnUseComponent> ent, ref UseInHandEvent args)
    {

        _audio.PlayPvs(ent.Comp.Sound, ent.Owner);

        Console.WriteLine(ent.Comp.Desc);


    }
}
