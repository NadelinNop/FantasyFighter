using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace TestingGUI
{
    public class Witch : Character
    {


        public Witch(int c)
        {
            if (c == 0)
            {
                Loading1();

            }
            else if(c == 1)
            {
                Loading2();
            }

        }
        public override void Draw()
        {
            SplashKit.DrawBitmap(BitmapOpt, X, Y, Option);

        }
        public void Loading1()
        {
            Name = "Blue Witch";
            Health = 300;
            Attackdmg = 30;
            Bitmap = SplashKit.LoadBitmap("FrogBmp", "B_witch_idle.png");
            Bitmap.SetCellDetails(32, 48, 1, 6, 6);
            BitmapRight = SplashKit.LoadBitmap("FrogBpp", "B_witch_idle_right.png");
            BitmapRight.SetCellDetails(32, 48, 1, 6, 6);
            BitmapRun = SplashKit.LoadBitmap("Frog", "B_witch_run.png");
            BitmapRun.SetCellDetails(32, 48, 1, 8, 8);
            BitmapRunRight = SplashKit.LoadBitmap("Froggy", "B_witch_run_right.png");
            BitmapRunRight.SetCellDetails(32, 48, 1, 8, 8);
            BitmapAttack = SplashKit.LoadBitmap("frrr", "B_witch_attack.png");
            BitmapAttack.SetCellDetails(104, 46, 1, 9, 9);
            BitmapAttackRight = SplashKit.LoadBitmap("fro", "B_witch_attack_right.png");
            BitmapAttackRight.SetCellDetails(104, 46, 1, 9, 9);

            //
            AnimationScriptIdle = SplashKit.LoadAnimationScript("IdleScript", "witchidle.txt");
            AnimationScriptRun = SplashKit.LoadAnimationScript("RunScript", "witchrun.txt");
            AnimationScriptAttack = SplashKit.LoadAnimationScript("AttackScript", "witchattack.txt");

            //
            AnimationIdle = AnimationScriptIdle.CreateAnimation("witchidle");
            AnimationRun = AnimationScriptRun.CreateAnimation("witchrun");
            AnimationAttack = AnimationScriptAttack.CreateAnimation("witchattack");

            X = 20;
            Right = true;
            BitmapOpt = Bitmap;
            Selected = true;
            Y = 290;
        }
        public void Loading2()
        {

            Name = "White Witch";
            Health = 300;
            Attackdmg = 30;
            Bitmap = SplashKit.LoadBitmap("RedWitchidle", "W_witch_idle.png");
            Bitmap.SetCellDetails(64, 64, 1, 6, 6);
            BitmapRight = SplashKit.LoadBitmap("RedWitchidleRight", "W_witch_idle_right.png");
            BitmapRight.SetCellDetails(64, 64, 1, 6, 6);
            BitmapRun = SplashKit.LoadBitmap("RedWitchRun", "W_witch_run.png");
            BitmapRun.SetCellDetails(64, 64, 1, 6, 6);
            BitmapRunRight = SplashKit.LoadBitmap("RedWitchRunright", "W_witch_run_right.png");
            BitmapRunRight.SetCellDetails(48, 64, 1, 6, 6);
            BitmapAttack = SplashKit.LoadBitmap("Redwitchattack", "W_witch_attack.png");
            BitmapAttack.SetCellDetails(132, 47, 1, 12, 12);
            BitmapAttackRight = SplashKit.LoadBitmap("redwitchattack", "W_witch_attack_right.png");
            BitmapAttackRight.SetCellDetails(132, 47, 1, 12, 12);
            //
            AnimationScriptIdle = SplashKit.LoadAnimationScript("IdleScript", "witchidle.txt");
            AnimationScriptRun = SplashKit.LoadAnimationScript("RunScript", "witchidle.txt");
            AnimationScriptAttack = SplashKit.LoadAnimationScript("AttackScript", "Wwitchattack.txt");
            //
            AnimationIdle = AnimationScriptIdle.CreateAnimation("witchidle");
            AnimationRun = AnimationScriptRun.CreateAnimation("witchidle");
            AnimationAttack = AnimationScriptAttack.CreateAnimation("Wwitchattack");

            X = 600;
            Right = true;
            Selected = true;
            BitmapOpt = Bitmap;
            Y = 270;
            //

        }

        public override void Attack()
        {

        }
        public override int TakeDmg(int attack)
        {
            Health = Health - attack;
            return Health;
        }


    }
}


