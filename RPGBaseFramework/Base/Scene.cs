using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBaseFramework.Base
{
    internal abstract class Scene
    {
        public World World;
        public Camera Camera;

        public Scene()
        {
            World = new World(25, 80);
            World.Fill();

            Camera = new Camera();
        }

        public string RequestUserOption()
        {
            Console.Write("O que voce faz? ");
            return Console.ReadLine();

        }

        public void Move(Scene scene)
        {
            scene.Show();
            Scene s = scene.Options(RequestUserOption());

            scene.Move(s);
        }

        public abstract Scene Options(string option);

        public void Show()
        {
            Camera.Draw(World);
        }
    }
}
