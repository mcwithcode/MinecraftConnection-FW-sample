using MinecraftConnection;
using MinecraftConnection.Entity;

string address = "mstechcamp-fw2022.japaneast.cloudapp.azure.com";
ushort port = 25575;
string pass = "minecraft";

MinecraftCommands commands = new MinecraftCommands(address, port, pass);

ushort lifeTime = 30;
// 大玉花火
Fireworks fw = new Fireworks()
{
    LifeTime = lifeTime,
    Type = FireworkType.LargeBall,
    Colors = FireworkOption.RandomColor(),
    FadeColors = FireworkOption.RandomColor()
};

Fireworks BurstFW(double x, double y, double z)
{
    Fireworks fw = new Fireworks()
    {
        LifeTime = 0,
        Type = FireworkType.Burst,
        Colors = FireworkOption.RandomColor(),
        FadeColors = FireworkOption.RandomColor(),
        Flicker = false,
        Trail = true,
        Motion = new Motion(x, y, z)
    };
    return fw;
}

double diff = (0.020595 * lifeTime * lifeTime) - (0.02976 * lifeTime);

Position fwPos = new Position(31, 72, 15);
Position burstPos = new Position(fwPos.X, fwPos.Y + diff, fwPos.Z);

commands.SetOffFireworks(fwPos, fw);
commands.Wait(2000);
commands.SetOffFireworks(burstPos, BurstFW(1, 0, 0));
commands.SetOffFireworks(burstPos, BurstFW(-1, 0, 0));
commands.SetOffFireworks(burstPos, BurstFW(0, 1, 0));
commands.SetOffFireworks(burstPos, BurstFW(0, -1, 0));
commands.SetOffFireworks(burstPos, BurstFW(1, 1, 0));
commands.SetOffFireworks(burstPos, BurstFW(1, -1, 0));
commands.SetOffFireworks(burstPos, BurstFW(-1, 1, 0));
commands.SetOffFireworks(burstPos, BurstFW(-1, -1, 0));
