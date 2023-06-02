using System.Drawing;

namespace pkl_app1_hikdhan.space_invader
{
    internal class EnemyModel
    {
        public int Id { get; set; }
        public int IsAlive { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public Image Gambar { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
