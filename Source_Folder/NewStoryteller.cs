﻿using RimWorld;
using Verse;

namespace AvaliMod
{
    internal class NewStorytellerComp : StorytellerComp
    {
        public override void Notify_PawnEvent(Pawn p, AdaptationEvent ev, DamageInfo? dinfo = null)
        {

            base.Notify_PawnEvent(p, ev, dinfo);
        }

        public override void Initialize()
        {
            base.Initialize();
        }
    }
}