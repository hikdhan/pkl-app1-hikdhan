using System.Drawing;

namespace pkl_app1_hikdhan.space_invader
{
    internal class ActorModel
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public int Speed { get; set; }
        public Image Gambar { get; set; }
    }
}