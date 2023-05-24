﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pkl_app1_hikdhan.space_invader
{
    public partial class SpaceInvaderForm : Form
    {
        private Bitmap _canvas = null;
        const int SPACE_BOARD_WIDTH = 80;
        const int SPACE_BOARD_HEIGHT = 40;
        const int SQUARE_SIZE = 10;
        private List<EnemyModel> _listEnemy;
        private List<BentengModel> _listBenteng;
        private ActorModel _actor;
        private string _arahEnemy = "left";
        private string _arahActor = "";
        private PeluruModel _peluruActor;
        public SpaceInvaderForm()
        {
            InitializeComponent();
            _listEnemy = new List<EnemyModel>();
            _listBenteng = new List<BentengModel>();
            _actor = new ActorModel();
            _peluruActor = new PeluruModel();

            CreateEnemyObject();
            CreateBentengObject();
            CreateActorObject();
            CreatePeluruActorObject();
            DrawAll();
        }

        private void DrawAll()
        {
            DrawBoard();
            DrawEnemy();
            DrawBenteng();
            DrawActor();
            DrawPeluru();
            SpaceBoard.Invalidate();
        }

        private void DrawBoard()
        {
            _canvas = new Bitmap(SpaceBoard.Width, SpaceBoard.Height);
            using (var grafik = Graphics.FromImage(_canvas))
            {
                for (int x = 0; x < SPACE_BOARD_WIDTH; x++)
                    for (int y = 0; y < SPACE_BOARD_HEIGHT; y++)
                        grafik.DrawRectangle(new Pen(Color.DarkGreen), x * SQUARE_SIZE, y * SQUARE_SIZE, SQUARE_SIZE, SQUARE_SIZE);
            }
        }



        private void SpaceInvaderForm_Load(object sender, EventArgs e)
        {

        }

        private void SpaceBoard_Paint(object sender, PaintEventArgs e)
        {
            if (_canvas is null) return;
            e.Graphics.DrawImage(_canvas, 0, 0);
        }

        private void DrawEnemy()
        {
            using (var grafik = Graphics.FromImage(_canvas))
            {
                foreach (var enemy in _listEnemy)
                    grafik.DrawImage(enemy.Gambar, enemy.PosX * SQUARE_SIZE, enemy.PosY * SQUARE_SIZE, enemy.Width * SQUARE_SIZE, enemy.Height * SQUARE_SIZE);
            }
        }
        private void DrawActor()
        {
            using (var grafik = Graphics.FromImage(_canvas))
            {
                grafik.DrawImage(_actor.Gambar, _actor.PosX * SQUARE_SIZE, _actor.PosY * SQUARE_SIZE, _actor.Width * SQUARE_SIZE, _actor.Height * SQUARE_SIZE);
            }
        }

        private void DrawPeluru()
        {
            using (var grafik = Graphics.FromImage(_canvas))
            {
                grafik.DrawImage(_peluruActor.Gambar, _peluruActor.PosX * SQUARE_SIZE, _peluruActor.PosY * SQUARE_SIZE, _peluruActor.Width * SQUARE_SIZE, _peluruActor.Height * SQUARE_SIZE);
            }
        }

        private void MoveEnemy()
        {
            var modifierX = 0;
            var modifierY = 0;
            switch (_arahEnemy)
            {
                case "up":
                    modifierX = 0;
                    modifierY = -1;
                    break;
                case "down":
                    modifierX = 0;
                    modifierY = 1;
                    break;
                case "left":
                    modifierX = -1;
                    modifierY = 0;
                    break;
                case "right":
                    modifierX = 1;
                    modifierY = 0;
                    break;
            }
            foreach (var enemy in _listEnemy)
            {
                enemy.PosX += modifierX;
                enemy.PosY += modifierY;
            }
        }


        private void DrawBenteng()
        {
            using (var grafik = Graphics.FromImage(_canvas))
            {
                foreach (var benteng in _listBenteng)
                {
                    Brush brush = null;
                    switch (benteng.DefencePower)
                    {
                        case 5:
                            brush = new SolidBrush(Color.Aquamarine);
                            break;
                        case 4:
                            brush = new SolidBrush(Color.Turquoise);
                            break;
                        case 3:
                            brush = new SolidBrush(Color.LightSeaGreen);
                            break;
                        case 2:
                            brush = new SolidBrush(Color.Teal);
                            break;
                        case 1:
                            brush = new SolidBrush(Color.FromArgb(0, 40, 40));
                            break;
                        default:
                            brush = new SolidBrush(Color.DarkSlateGray);
                            break;
                    };
                    grafik.FillRectangle(brush, benteng.PosX * SQUARE_SIZE, benteng.PosY * SQUARE_SIZE, benteng.Width * SQUARE_SIZE, benteng.Height * SQUARE_SIZE);

                }
            }
        }


        private void CreateEnemyObject()
        {
            const int WIDTH = 4;
            const int HEIGHT = 3;

            //  enemy level-3 (paling atas)
            for (var i = 1; i <= 9; i++)
            {
                var newEnemy = new EnemyModel
                {
                    Id = i,
                    Gambar = enemy3.Image,
                    IsAlive = true,
                    Width = WIDTH,
                    Height = HEIGHT,
                    PosX = (i * WIDTH * 2) - WIDTH,
                    PosY = 2
                };
                _listEnemy.Add(newEnemy);
            }

            //  enemy level-2 (tengah)
            for (var i = 10; i <= 18; i++)
            {
                var newEnemy = new EnemyModel
                {
                    Id = i,
                    Gambar = enemy2.Image,
                    IsAlive = true,
                    Width = WIDTH,
                    Height = HEIGHT,
                    PosX = ((i - 9) * WIDTH * 2) - WIDTH,
                    PosY = 7
                };
                _listEnemy.Add(newEnemy);
            }

            //  enemy level-1 (baris ke-2)
            for (var i = 19; i <= 27; i++)
            {
                var newEnemy = new EnemyModel
                {
                    Id = i,
                    Gambar = enemy1.Image,
                    IsAlive = true,
                    Width = WIDTH,
                    Height = HEIGHT,
                    PosX = ((i - 18) * WIDTH * 2) - WIDTH,
                    PosY = 12
                };
                _listEnemy.Add(newEnemy);
            }

            //  enemy level-1 (baris ke-1)
            for (var i = 28; i <= 36; i++)
            {
                var newEnemy = new EnemyModel
                {
                    Id = i,
                    Gambar = enemy1.Image,
                    IsAlive = true,
                    Width = WIDTH,
                    Height = HEIGHT,
                    PosX = ((i - 27) * WIDTH * 2) - WIDTH,
                    PosY = 17
                };
                _listEnemy.Add(newEnemy);
            }
        }

        private void CreateBentengObject()
        {
            const int WIDTH = 7;
            const int HEIGHT = 1;

            for (var i = 1; i <= 8; i++)
            {
                var newBenteng = new BentengModel
                {
                    Id = i,
                    DefencePower = 5,
                    Height = HEIGHT,
                    Width = WIDTH,
                    PosX = (i * (WIDTH + 4)) - WIDTH,
                    PosY = 32
                };
                _listBenteng.Add(newBenteng);
            }

        }
        private void CreateActorObject()
        {
            _actor = new ActorModel
            {
                Gambar = player.Image,
                Width = 5,
                Height = 3,
                PosX = 0,
                PosY = 36,
            };
        }

        private void CreatePeluruActorObject()
        {
            _peluruActor.IsAktif = false;
            _peluruActor.Width = 1;
            _peluruActor.Height = 3;
            _peluruActor.Gambar = pelor.Image;
        }

        private void EnemyMoveTimer_Tick(object sender, EventArgs e)
        {
            var palingLeft = _listEnemy.Min(x => x.PosX);
            var palingRight = _listEnemy.Max(x => x.PosX + x.Width);

            if ((_arahEnemy == "left") && (palingLeft <= 0))
                _arahEnemy = "right";
            if ((_arahEnemy == "right") && (palingRight >= SPACE_BOARD_WIDTH))
                _arahEnemy = "left";
            MoveEnemy();
            DrawAll();
        }

        private void ActorMoveTimer_Tick(object sender, EventArgs e)
        {
            if (_arahActor == "left")
                _actor.PosX--;
            if (_arahActor == "right")
                _actor.PosX++;

            if (_actor.PosX <= 0)
                _actor.PosX = 0;
            if (_actor.PosX > SPACE_BOARD_WIDTH - _actor.Width)
                _actor.PosX = SPACE_BOARD_WIDTH - _actor.Width;
            DrawAll();
        }

        private void SpaceInvaderForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    _arahActor = "left";
                    break;
                case Keys.Right:
                    _arahActor = "right";
                    break;
                case Keys.Space:
                    TembakMusuh();
                    break;
            }
        }

        private void SpaceInvaderForm_KeyUp(object sender, KeyEventArgs e)
        {
            _arahActor = string.Empty;
        }

        private void SpaceInvaderForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }

        private void TembakMusuh()
        {
            if (_peluruActor.IsAktif)
                return;
            _peluruActor.PosX = _actor.PosX + (_actor.Width / 2);
            _peluruActor.PosY = _actor.PosY;
            _peluruActor.IsAktif = true;
        }

        private void SpaceBoard_Click(object sender, EventArgs e)
        {

        }

        private void PeluruActorTimer_Tick(object sender, EventArgs e)
        {
            if (!_peluruActor.IsAktif)
                return;
            _peluruActor.PosY--;
            if (_peluruActor.PosY <= 0)
            {
                _peluruActor.IsAktif = false;
                _peluruActor.PosY = -10;
            }
        }
    }
}
