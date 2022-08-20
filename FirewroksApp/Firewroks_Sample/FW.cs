using MinecraftConnection;
using MinecraftConnection.Entity;

namespace Firewroks_Sample
{
    public static class FW
    {
        static string address = "mstechcamp-fw2022.japaneast.cloudapp.azure.com";
        static ushort port = 25575;
        static string pass = "minecraft";
        static MinecraftCommands commands = new MinecraftCommands(address, port, pass);

        static Random rand = new Random();
        static int lifeTime = 30;
        static Position pos = new Position(31, 68, 15);

        // 小玉花火
        public static void FW01()
        { 
            for (int i = 0; i < 20; i++)
            {
                Fireworks fw = new Fireworks()
                {
                    LifeTime = 30,
                    Type = FireworkType.SmallBall,
                    Colors = FireworkOption.RandomColor(),
                    FadeColors = FireworkOption.RandomColor()
                };
                commands.SetOffFireworks(pos.X + rand.Next(-19, 20), pos.Y, pos.Z, fw);
                commands.Wait((ushort)rand.Next(200, 1000));
            }
            for (int i = 0; i < 20; i++)
            {
                Fireworks fw = new Fireworks()
                {
                    LifeTime = 30,
                    Type = FireworkType.SmallBall,
                    Colors = FireworkOption.RandomColor(),
                    FadeColors = FireworkOption.RandomColor(),
                    Flicker = true
                };
                commands.SetOffFireworks(pos.X + rand.Next(-19, 20), pos.Y, pos.Z, fw);
                commands.Wait((ushort)rand.Next(200, 1000));
            }
        }

        // 大玉花火
        public static void FW02()
        {
            for (int i = 0; i < 10; i++)
            {
                Fireworks fw = new Fireworks()
                {
                    LifeTime = 30,
                    Type = FireworkType.LargeBall,
                    Colors = FireworkOption.RandomColor(),
                    FadeColors = FireworkOption.RandomColor(),
                    Flicker = true
                };
                commands.SetOffFireworks(pos.X + rand.Next(-10, 10), pos.Y, pos.Z, fw);
                commands.Wait(3000);
            }
            for (int i = 0; i < 10; i++)
            {
                Fireworks fw = new Fireworks()
                {
                    LifeTime = 30,
                    Type = FireworkType.LargeBall,
                    Colors = FireworkOption.RandomColor(),
                    FadeColors = FireworkOption.RandomColor(),
                    Trail = true
                };
                commands.SetOffFireworks(pos.X + rand.Next(-10, 10), pos.Y, pos.Z, fw);
                commands.Wait(3000);
            }
        }

        // クリーパー
        public static void FW03()
        {
            for (int i = 0; i < 10; i++)
            {
                Fireworks fw = new Fireworks()
                {
                    LifeTime = 30,
                    Type = FireworkType.Creeper,
                    Colors = FireworkOption.RandomColor(),
                    FadeColors = FireworkOption.RandomColor(),
                };
                commands.SetOffFireworks(pos.X + rand.Next(-19, 20), pos.Y, pos.Z, fw);
                commands.Wait(2000);
            }
            for (int i = 0; i < 10; i++)
            {
                Fireworks fw = new Fireworks()
                {
                    LifeTime = 30,
                    Type = FireworkType.Creeper,
                    Colors = FireworkOption.RandomColor(),
                    FadeColors = FireworkOption.RandomColor(),
                    Trail = true
                };
                commands.SetOffFireworks(pos.X + rand.Next(-19, 20), pos.Y, pos.Z, fw);
                commands.Wait(2000);
            }
        }

        // 星型
        public static void FW04()
        {
            for (int i = 0; i < 10; i++)
            {
                Fireworks fw = new Fireworks()
                {
                    LifeTime = 30,
                    Type = FireworkType.Star,
                    Colors = FireworkOption.RandomColor(),
                    FadeColors = FireworkOption.RandomColor(),
                };
                commands.SetOffFireworks(pos.X + rand.Next(-19, 20), pos.Y, pos.Z, fw);
                commands.Wait(2000);
            }
            for (int i = 0; i < 10; i++)
            {
                Fireworks fw = new Fireworks()
                {
                    LifeTime = 30,
                    Type = FireworkType.Star,
                    Colors = FireworkOption.RandomColor(),
                    FadeColors = FireworkOption.RandomColor(),
                    Flicker = true
                };
                commands.SetOffFireworks(pos.X + rand.Next(-19, 20), pos.Y, pos.Z, fw);
                commands.Wait(2000);
            }
        }

        // バースト型
        public static void FW05()
        {
            for (int i = 0; i < 10; i++)
            {
                Fireworks fw = new Fireworks()
                {
                    LifeTime = 20,
                    Type = FireworkType.Burst,
                    Colors = FireworkOption.RandomColor(),
                    FadeColors = FireworkOption.RandomColor(),
                };
                commands.SetOffFireworks(pos.X + rand.Next(-19, 20), pos.Y, pos.Z, fw);
                commands.Wait(2000);
            }
            for (int i = 0; i < 20; i++)
            {
                Fireworks fw = new Fireworks()
                {
                    LifeTime = 20,
                    Type = FireworkType.Burst,
                    Colors = FireworkOption.RandomColor(),
                    FadeColors = FireworkOption.RandomColor(),
                    Trail = true
                };
                commands.SetOffFireworks(pos.X + rand.Next(-19, 20), pos.Y, pos.Z, fw);
                commands.Wait((ushort)rand.Next(200, 1500));
            }
        }

        // チューリップ
        public static void FW06()
        {
            Fireworks Leaf(double x, double y, double z)
            {
                return new Fireworks()
                {
                    LifeTime = 0,
                    Type = FireworkType.Burst,
                    Colors = new List<FireworkColors> { FireworkColors.LIME },
                    Trail = true,
                    Motion = new Motion(x, y, z)
                };
            }

            Fireworks Flower(double x, double y, double z)
            {
                return new Fireworks()
                {
                    LifeTime = 0,
                    Type = FireworkType.Burst,
                    Colors = new List<FireworkColors> { FireworkColors.RED },
                    Trail = true,
                    Motion = new Motion(x, y, z)
                };
            }

            Fireworks Flower2(double x, double y, double z)
            {
                return new Fireworks()
                {
                    LifeTime = 0,
                    Type = FireworkType.Burst,
                    Colors = new List<FireworkColors> { FireworkColors.YELLOW },
                    Trail = true,
                    Motion = new Motion(x, y, z)
                };
            }

            Fireworks Flower3(double x, double y, double z)
            {
                return new Fireworks()
                {
                    LifeTime = 0,
                    Type = FireworkType.Burst,
                    Colors = new List<FireworkColors> { FireworkColors.WHITE },
                    Trail = true,
                    Motion = new Motion(x, y, z)
                };
            }

            for (int i = 0; i < 10; i++)
            {
                var shift = rand.Next(-19, 20);
                commands.SetOffFireworks(pos.X + shift + 5, pos.Y + 10, pos.Z, Leaf(1.3, 0.8, 0));
                commands.SetOffFireworks(pos.X + shift + 5, pos.Y + 10, pos.Z, Leaf(-1.3, 0.8, 0));
                commands.SetOffFireworks(pos.X + shift + 3, pos.Y + 10, pos.Z, Flower(-0.2, 2.0, 0));
                commands.SetOffFireworks(pos.X + shift + 4, pos.Y + 10, pos.Z, Flower(-0.1, 2.0, 0));
                commands.SetOffFireworks(pos.X + shift + 5, pos.Y + 10, pos.Z, Flower(0, 2.0, 0));
                commands.SetOffFireworks(pos.X + shift + 6, pos.Y + 10, pos.Z, Flower(0.1, 2.0, 0));
                commands.SetOffFireworks(pos.X + shift + 7, pos.Y + 10, pos.Z, Flower(0.2, 2.0, 0));
                commands.Wait(2000);
            }

            for (int i = 0; i < 10; i++)
            {
                var shift = rand.Next(-19, 20);
                commands.SetOffFireworks(pos.X + shift + 5, pos.Y + 10, pos.Z, Leaf(1.3, 0.8, 0));
                commands.SetOffFireworks(pos.X + shift + 5, pos.Y + 10, pos.Z, Leaf(-1.3, 0.8, 0));
                commands.SetOffFireworks(pos.X + shift + 3, pos.Y + 10, pos.Z, Flower2(-0.2, 2.0, 0));
                commands.SetOffFireworks(pos.X + shift + 4, pos.Y + 10, pos.Z, Flower2(-0.1, 2.0, 0));
                commands.SetOffFireworks(pos.X + shift + 5, pos.Y + 10, pos.Z, Flower2(0, 2.0, 0));
                commands.SetOffFireworks(pos.X + shift + 6, pos.Y + 10, pos.Z, Flower2(0.1, 2.0, 0));
                commands.SetOffFireworks(pos.X + shift + 7, pos.Y + 10, pos.Z, Flower2(0.2, 2.0, 0));
                commands.Wait(2000);
            }

            for (int i = 0; i < 10; i++)
            {
                var shift = rand.Next(-19, 20);
                commands.SetOffFireworks(pos.X + shift + 5, pos.Y + 10, pos.Z, Leaf(1.3, 0.8, 0));
                commands.SetOffFireworks(pos.X + shift + 5, pos.Y + 10, pos.Z, Leaf(-1.3, 0.8, 0));
                commands.SetOffFireworks(pos.X + shift + 3, pos.Y + 10, pos.Z, Flower3(-0.2, 2.0, 0));
                commands.SetOffFireworks(pos.X + shift + 4, pos.Y + 10, pos.Z, Flower3(-0.1, 2.0, 0));
                commands.SetOffFireworks(pos.X + shift + 5, pos.Y + 10, pos.Z, Flower3(0, 2.0, 0));
                commands.SetOffFireworks(pos.X + shift + 6, pos.Y + 10, pos.Z, Flower3(0.1, 2.0, 0));
                commands.SetOffFireworks(pos.X + shift + 7, pos.Y + 10, pos.Z, Flower3(0.2, 2.0, 0));
                commands.Wait(2000);
            }

        }

        // ラベンダー
        public static void FW07()
        {
            Fireworks Leaf(double x, double y, double z)
            {
                return new Fireworks()
                {
                    LifeTime = 0,
                    Type = FireworkType.Burst,
                    Colors = new List<FireworkColors> { FireworkColors.LIME },
                    Trail = true,
                    Motion = new Motion(x, y, z)
                };
            }

            Fireworks Flower = new Fireworks()
            {
                LifeTime = 0,
                Type = FireworkType.SmallBall,
                Colors = new List<FireworkColors> { FireworkColors.PURPLE }
            };

            for (int i = 0; i < 10; i++)
            {
                var shift = rand.Next(-19, 20);
                commands.SetOffFireworks(pos.X + shift, pos.Y + 10, pos.Z, Leaf(1.3, 0.8, 0));
                commands.SetOffFireworks(pos.X + shift, pos.Y + 10, pos.Z, Leaf(-1.3, 0.8, 0));
                commands.Wait(200);
                for (int j = 0; j < 10; j++)
                {
                    commands.SetOffFireworks(pos.X + shift + rand.Next(-2, 2), pos.Y + 10 + rand.Next(3, 18), pos.Z, Flower);
                }
                commands.Wait(2000);
            }

            for (int i = 0; i < 10; i++)
            {
                var shift = rand.Next(-19, 20);
                commands.SetOffFireworks(pos.X + shift, pos.Y + 10, pos.Z, Leaf(1.3, 0.8, 0));
                commands.SetOffFireworks(pos.X + shift, pos.Y + 10, pos.Z, Leaf(-1.3, 0.8, 0));
                commands.Wait(200);
                for (int j = 0; j < 10; j++)
                {
                    commands.SetOffFireworks(pos.X + shift + rand.Next(-2, 2), pos.Y + 10 + rand.Next(3, 18), pos.Z, Flower);
                }
                commands.Wait(100);
            }
        }

        // 猫
        public static void FW08()
        {
            Fireworks Parts(double x, double y, double z)
            {
                return new Fireworks()
                {
                    LifeTime = 0,
                    Type = FireworkType.Burst,
                    Colors = new List<FireworkColors> { FireworkColors.YELLOW },
                    Trail = true,
                    Motion = new Motion(x, y, z)
                };
            }

            Fireworks Eyes(double x, double y, double z)
            {
                return new Fireworks()
                {
                    LifeTime = 0,
                    Type = FireworkType.SmallBall,
                    Colors = new List<FireworkColors> { FireworkColors.BLUE },
                    Trail = true,
                    Motion = new Motion(x, y, z)
                };
            }

            Fireworks Face(double x, double y, double z)
            {
                return new Fireworks()
                {
                    LifeTime = 5,
                    IsEmpty = true,
                    Motion = new Motion(x, y, z)
                };
            }

            Fireworks Face2(double x, double y, double z)
            {
                return new Fireworks()
                {
                    LifeTime = 20,
                    IsEmpty = true,
                    Motion = new Motion(x, y, z)
                };
            }

            for (int i = 0; i < 5; i++)
            {
                var shift = rand.Next(0, 10);
                for (int j = 0; j < 10; j++)
                {
                    commands.SetOffFireworks(pos.X + shift, pos.Y + 20, pos.Z, Face(-0.2, -1, 0));
                    commands.SetOffFireworks(pos.X + shift, pos.Y + 20, pos.Z, Face(0.2, -1, 0));
                    commands.SetOffFireworks(pos.X + shift - 10, pos.Y + 20, pos.Z, Face(-0.2, -1, 0));
                    commands.SetOffFireworks(pos.X + shift - 10, pos.Y + 20, pos.Z, Face(0.2, -1, 0));
                    commands.SetOffFireworks(pos.X + shift - 10, pos.Y - 2 + 20, pos.Z, Face(0.8, 0, 0));
                }

                commands.SetOffFireworks(pos.X + shift - 14, pos.Y - 6 + 20, pos.Z, Face2(0.05, -0.85, 0));
                commands.SetOffFireworks(pos.X + shift + 3, pos.Y - 6 + 20, pos.Z, Face2(-0.05, -0.85, 0));

                commands.SetOffFireworks(pos.X + shift - 6, pos.Y - 12 + 20, pos.Z, Parts(-1.4, -0.2, 0));
                commands.SetOffFireworks(pos.X + shift - 6, pos.Y - 12 + 20, pos.Z, Parts(1.4, -0.2, 0));

                commands.SetOffFireworks(pos.X + shift - 11, pos.Y - 5 + 20, pos.Z + 7, Eyes(0, 0, 2));
                commands.SetOffFireworks(pos.X + shift, pos.Y - 5 + 20, pos.Z + 7, Eyes(0, 0, 2));

                commands.Wait(3000);
            }
        }

        // 万華鏡
        public static void FW09()
        {
            ushort lifeTime = 30;
            for (int i = 0; i < 10; i++)
            {
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

                double diff = (0.020595 * lifeTime * lifeTime) - (0.02976 * lifeTime) + 4;
                var shift = rand.Next(-3, 3);
                Position burstPos = new Position(pos.X + shift, pos.Y + diff, pos.Z + 10);
                double motion = 2.5;
                double revMotion = -2.5;
                double rate = 0.8;

                commands.SetOffFireworks(pos.X + shift, pos.Y, pos.Z, fw);
                commands.Wait(2000);
                commands.SetOffFireworks(burstPos, BurstFW(motion * rate, motion * rate, 0));
                commands.SetOffFireworks(burstPos, BurstFW(revMotion * rate, revMotion * rate, 0));
                commands.SetOffFireworks(burstPos, BurstFW(revMotion * rate, motion * rate, 0));
                commands.SetOffFireworks(burstPos, BurstFW(motion * rate, revMotion * rate, 0));
                commands.SetOffFireworks(burstPos, BurstFW(0, motion, 0));
                commands.SetOffFireworks(burstPos, BurstFW(0, revMotion, 0));
                commands.SetOffFireworks(burstPos, BurstFW(motion, 0, 0));
                commands.SetOffFireworks(burstPos, BurstFW(revMotion, 0, 0));

                commands.Wait(2000);
            }
            
        }

        // ミックス
        public static void FW10()
        {
            Fireworks fireworks(int num)
            {
                var shape = num switch
                {
                    0 => FireworkType.Burst,
                    1 => FireworkType.SmallBall,
                    2 => FireworkType.LargeBall,
                    3 => FireworkType.Star,
                    _ => FireworkType.Creeper
                };
                Fireworks fw = new Fireworks()
                {
                    LifeTime = 30,
                    Type = shape,
                    Colors = FireworkOption.RandomColor(),
                    FadeColors = FireworkOption.RandomColor()
                };
                return fw;
            }
            for (int i = 0; i < 30; i++)
            {
                var fw = fireworks(rand.Next(0, 5));
                commands.SetOffFireworks(pos.X + rand.Next(-19, 20), pos.Y, pos.Z, fw);
                commands.Wait(500);
            }
        }

        // 連打
        public static void FW11()
        {

            Fireworks emptyFirewroks(double x, double y, double z)
            {
                return new Fireworks()
                {
                    LifeTime = 20,
                    IsEmpty = true,
                    Motion = new Motion(x, y, z)
                };
            }

            Fireworks smallFirewroks()
            {
                return new Fireworks()
                {
                    LifeTime = 0,
                    Colors = new List<FireworkColors> { FireworkColors.YELLOW },
                    FadeColors = new List<FireworkColors> { FireworkColors.ORANGE },
                };
            }

            Fireworks smallFirewroks2()
            {
                return new Fireworks()
                {
                    LifeTime = 0,
                    Colors = new List<FireworkColors> { FireworkColors.CYAN },
                    FadeColors = new List<FireworkColors> { FireworkColors.WHITE },
                };
            }

            Fireworks smallFirewroks3()
            {
                return new Fireworks()
                {
                    LifeTime = 0,
                    Colors = new List<FireworkColors> { FireworkColors.PURPLE },
                    FadeColors = new List<FireworkColors> { FireworkColors.PINK },
                };
            }

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    commands.SetOffFireworks(pos.X - 10 + 5 * i, pos.Y, pos.Z, emptyFirewroks(0.2, 0.7, 0.0));
                    commands.SetOffFireworks(pos.X - 10 + 5 * i, pos.Y, pos.Z, emptyFirewroks(-0.2, 0.7, 0.0));
                    commands.Wait(100);
                }

                commands.Wait(300);

                for (int i = 0; i < 10; i++)
                {
                    commands.SetOffFireworks(pos.X - 20 + 5 * i, pos.Y + 20, pos.Z, smallFirewroks());
                }

                for (int i = 0; i < 10; i++)
                {
                    commands.SetOffFireworks(pos.X - 20 + 5 * i, pos.Y + 25, pos.Z, smallFirewroks2());
                }

                for (int i = 0; i < 10; i++)
                {
                    commands.SetOffFireworks(pos.X - 20 + 5 * i, pos.Y + 30, pos.Z, smallFirewroks3());
                }

                commands.Wait(3000);
            }

        }

        // クロス
        public static void FW12()
        {
            Fireworks burst1 = new Fireworks()
            {
                LifeTime = 0,
                Type = FireworkType.Burst,
                Colors = new List<FireworkColors> { FireworkColors.YELLOW },
                Trail = true,
                Motion = new Motion(-1.5, 1.0, 0)
            };
            Fireworks burst2 = new Fireworks()
            {
                LifeTime = 0,
                Type = FireworkType.Burst,
                Colors = new List<FireworkColors> { FireworkColors.YELLOW },
                Trail = true,
                Motion = new Motion(1.5, 1.0, 0)
            };

            for (int i = 0; i < 3; i++)
            {
                var rnd = rand.Next(-19, 20);
                commands.SetOffFireworks(pos.X + rnd + 10, pos.Y, pos.Z, burst1);
                commands.Wait(200);
                commands.SetOffFireworks(pos.X + rnd, pos.Y + 5, pos.Z, burst2);
                commands.Wait(200);
                commands.SetOffFireworks(pos.X + rnd + 10, pos.Y + 10, pos.Z, burst1);
                commands.Wait(200);
                commands.SetOffFireworks(pos.X + rnd, pos.Y + 15, pos.Z, burst2);
                commands.Wait(200);
                commands.SetOffFireworks(pos.X + rnd + 10, pos.Y + 20, pos.Z, burst1);
                commands.Wait(200);
                commands.SetOffFireworks(pos.X + rnd, pos.Y + 25, pos.Z, burst2);
                commands.Wait(1000);
            }

        }

        // ラスト
        public static void FW13()
        {
            
            for (int i = 0; i < 30; i++)
            {
                Fireworks fw = new Fireworks()
                {
                    LifeTime = 30,
                    Type = FireworkType.LargeBall,
                    Colors = FireworkOption.RandomColor(),
                    FadeColors = FireworkOption.RandomColor(),
                };
                commands.SetOffFireworks(pos.X + rand.Next(-19, 20), pos.Y + rand.Next(-5, 5), pos.Z, fw);
                commands.Wait((ushort)rand.Next(200, 1000));
            }
            
            for (int i = 0; i < 30; i++)
            {
                Fireworks fw2 = new Fireworks()
                {
                    LifeTime = 30,
                    Type = FireworkType.LargeBall,
                    Colors = FireworkOption.RandomColor(),
                    FadeColors = FireworkOption.RandomColor(),
                    Flicker = true
                };
                commands.SetOffFireworks(pos.X + rand.Next(-19, 20), pos.Y + rand.Next(-5, 5), pos.Z, fw2);
                commands.Wait((ushort)rand.Next(200, 1000));
            }

            commands.Wait(1000);
            
            for (int i = 0; i < 100; i++)
            {
                Fireworks fw2 = new Fireworks()
                {
                    LifeTime = 30,
                    Type = FireworkType.LargeBall,
                    Colors = FireworkOption.RandomColor(),
                    FadeColors = FireworkOption.RandomColor(),
                    Flicker = true
                };
                commands.SetOffFireworks(pos.X + rand.Next(-29, 30), pos.Y + rand.Next(-5, 5), pos.Z, fw2);
                commands.Wait(50);
            }

        }

        // 花火ループ
        public static void FW_roop()
        {
            while (true)
            {
                Fireworks fw2 = new Fireworks()
                {
                    LifeTime = 30,
                    Type = FireworkType.LargeBall,
                    Colors = FireworkOption.RandomColor(),
                    FadeColors = FireworkOption.RandomColor(),
                    Flicker = true
                };
                commands.SetOffFireworks(pos.X + rand.Next(-29, 30), pos.Y + rand.Next(-5, 5), pos.Z, fw2);
                commands.Wait(50);
            }
        }
    }
}
