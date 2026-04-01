namespace Bouncer;

public class ModEntry : Mod
{
    public override void Entry(IModHelper helper)
    {
        helper.Events.GameLoop.UpdateTicked += (sender, e) =>
        {
            if (e.IsMultipleOf(8) && Game1.getCharacterFromName("Bouncer") is NPC bouncer && bouncer.yJumpOffset == 0)
                bouncer.jump();
        };
    }
}
