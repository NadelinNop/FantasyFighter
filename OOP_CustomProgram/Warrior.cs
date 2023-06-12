using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace TestingGUI
{
    public class Warrior : Character
    {
        public Warrior()
        {
            Name = "Warrior";
            Health = 300;
            Attackdmg = 30;
            Bitmap = SplashKit.LoadBitmap("Cat", "Meow-Knight_Idle.png");
            Bitmap.SetCellDetails(16, 24, 1, 6, 6);
            BitmapRight = SplashKit.LoadBitmap("Catidle", "Meow-Knight_Idle_Right.png");
            BitmapRight.SetCellDetails(16, 24, 1, 6, 6);
            BitmapRun = SplashKit.LoadBitmap("CatRun", "Meow-Knight_Run.png");
            BitmapRun.SetCellDetails(16, 28, 1, 8, 8);
            BitmapRunRight = SplashKit.LoadBitmap("Froggy", "Meow-Knight_Run_Right.png");
            BitmapRunRight.SetCellDetails(16, 28, 1, 8, 8);
            BitmapAttack = SplashKit.LoadBitmap("frrr", "Meow-Knight_Attack_1.png");
            BitmapAttack.SetCellDetails(32, 31, 1, 10, 10);
            BitmapAttackRight = SplashKit.LoadBitmap("fro", "Meow-Knight_Attack_1.png");
            BitmapAttackRight.SetCellDetails(32, 31, 1, 10, 10);
            //
            AnimationScriptIdle = SplashKit.LoadAnimationScript("IdleScript", "witchidle.txt");
            AnimationScriptRun = SplashKit.LoadAnimationScript("RunScript", "witchrun.txt");
            AnimationScriptAttack = SplashKit.LoadAnimationScript("AttackScript", "catattack.txt");
            //
            AnimationIdle = AnimationScriptIdle.CreateAnimation("witchidle");
            AnimationRun = AnimationScriptRun.CreateAnimation("witchrun");
            AnimationAttack = AnimationScriptAttack.CreateAnimation("catattack");

            X = 20;
            Right = true;
            BitmapOpt = Bitmap;
            Selected = true;
            Y = 310;

        }
        public override void Draw()
        {
            SplashKit.DrawBitmap(BitmapOpt, X, Y, Option);

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
