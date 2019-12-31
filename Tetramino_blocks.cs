using System;

namespace Tetramino_blocks
{

    public class InvalidTetraminoShape : ArgumentException
    {
        public InvalidTetraminoShape() : base() { }
        public InvalidTetraminoShape(string s) : base(s) { }
    }

    public class Tetramino_I : Tetramino
    {
        public Tetramino_I() : base() { }

        protected override void CreateBlocks(int width, int height)
        {
            blocks.Add(new ImageBlock(height, width, 0, 0, "cyan_block"));
            blocks.Add(new ImageBlock(height, width, 0, width, "cyan_block"));
            blocks.Add(new ImageBlock(height, width, 0, 2 * width, "cyan_block"));
            blocks.Add(new ImageBlock(height, width, 0, 3 * width, "cyan_block"));
        }

        public override void MakeRotation(int rotationType)
        {
            switch (rotationType)
            {
                case 0:
                    blocks[0].MoveRight();
                    blocks[0].MoveRightUp();
                    blocks[1].MoveRight();
                    blocks[2].MoveDown();
                    blocks[3].MoveDown();
                    blocks[3].MoveLeftDown();
                    break;
                case 1:
                    blocks[0].MoveDown();
                    blocks[0].MoveRightDown();
                    blocks[1].MoveDown();
                    blocks[2].MoveLeft();
                    blocks[3].MoveLeft();
                    blocks[3].MoveLeftUp();
                    break;
                case 2:
                    blocks[0].MoveLeft();
                    blocks[0].MoveLeftDown();
                    blocks[1].MoveLeft();
                    blocks[2].MoveUp();
                    blocks[3].MoveUp();
                    blocks[3].MoveRightUp();
                    break;
                case 3:
                    blocks[0].MoveUp();
                    blocks[0].MoveLeftUp();
                    blocks[1].MoveUp();
                    blocks[2].MoveRight();
                    blocks[3].MoveRight();
                    blocks[3].MoveRightDown();
                    break;
            }
        }
    }

    public class Tetramino_J : Tetramino
    {
        public Tetramino_J() : base() { }

        protected override void CreateBlocks(int width, int height)
        {
            blocks.Add(new ImageBlock(height, width, 0, 0, "blue_block"));
            blocks.Add(new ImageBlock(height, width, height, 0, "blue_block"));
            blocks.Add(new ImageBlock(height, width, height, width, "blue_block"));
            blocks.Add(new ImageBlock(height, width, height, 2 * width, "blue_block"));
        }

        public override void MakeRotation(int rotationType)
        {
            switch (rotationType)
            {
                case 0:
                    blocks[0].MoveRight();
                    blocks[0].MoveRight();
                    blocks[1].MoveRightUp();
                    blocks[3].MoveLeftDown();
                    break;
                case 1:
                    blocks[0].MoveDown();
                    blocks[0].MoveDown();
                    blocks[1].MoveRightDown();
                    blocks[3].MoveLeftUp();
                    break;
                case 2:
                    blocks[0].MoveLeft();
                    blocks[0].MoveLeft();
                    blocks[1].MoveLeftDown();
                    blocks[3].MoveRightUp();
                    break;
                case 3:
                    blocks[0].MoveUp();
                    blocks[0].MoveUp();
                    blocks[1].MoveLeftUp();
                    blocks[3].MoveRightDown();
                    break;
            }
        }
    }

    public class Tetramino_L : Tetramino
    {
        public Tetramino_L() : base() { }

        protected override void CreateBlocks(int width, int height)
        {
            blocks.Add(new ImageBlock(height, width, 0, 2 * width, "orange_block"));
            blocks.Add(new ImageBlock(height, width, height, 0, "orange_block"));
            blocks.Add(new ImageBlock(height, width, height, width, "orange_block"));
            blocks.Add(new ImageBlock(height, width, height, 2 * width, "orange_block"));
        }

        public override void MakeRotation(int rotationType)
        {
            switch (rotationType)
            {
                case 0:
                    blocks[0].MoveLeft();
                    blocks[0].MoveLeft();
                    blocks[1].MoveRightDown();
                    blocks[3].MoveLeftUp();
                    break;
                case 1:
                    blocks[0].MoveDown();
                    blocks[0].MoveDown();
                    blocks[1].MoveRightUp();
                    blocks[3].MoveLeftDown();
                    break;
                case 2:
                    blocks[0].MoveRight();
                    blocks[0].MoveRight();
                    blocks[1].MoveLeftUp();
                    blocks[3].MoveRightDown();
                    break;
                case 3:
                    blocks[0].MoveUp();
                    blocks[0].MoveUp();
                    blocks[1].MoveLeftDown();
                    blocks[3].MoveRightUp();
                    break;
            }
        }
    }

    public class Tetramino_O : Tetramino
    {
        public Tetramino_O() : base() { }

        protected override void CreateBlocks(int width, int height)
        {
            blocks.Add(new ImageBlock(height, width, 0, 0, "yellow_block"));
            blocks.Add(new ImageBlock(height, width, 0, width, "yellow_block"));
            blocks.Add(new ImageBlock(height, width, height, 0, "yellow_block"));
            blocks.Add(new ImageBlock(height, width, height, width, "yellow_block"));
        }

        public override void Rotate(bool direct) { }
        public override void MakeRotation(int rotationType) { }
    }

    public class Tetramino_S : Tetramino
    {
        public Tetramino_S() : base() { }

        protected override void CreateBlocks(int width, int height)
        {
            blocks.Add(new ImageBlock(Tetris.Resources.BlockHeight, Tetris.Resources.BlockWidth, 0, width, "green_block"));
            blocks.Add(new ImageBlock(Tetris.Resources.BlockHeight, Tetris.Resources.BlockWidth, 0, 2 * width, "green_block"));
            blocks.Add(new ImageBlock(Tetris.Resources.BlockHeight, Tetris.Resources.BlockWidth, height, 0, "green_block"));
            blocks.Add(new ImageBlock(Tetris.Resources.BlockHeight, Tetris.Resources.BlockWidth, height, width, "green_block"));
        }

        public override void MakeRotation(int rotationType)
        {
            switch (rotationType)
            {
                case 0:
                    blocks[0].MoveRightDown();
                    blocks[1].MoveDown();
                    blocks[1].MoveDown();
                    blocks[2].MoveRightUp();
                    break;
                case 1:
                    blocks[0].MoveLeftDown();
                    blocks[1].MoveLeft();
                    blocks[1].MoveLeft();
                    blocks[2].MoveRightDown();
                    break;
                case 2:
                    blocks[0].MoveLeftUp();
                    blocks[1].MoveUp();
                    blocks[1].MoveUp();
                    blocks[2].MoveLeftDown();
                    break;
                case 3:
                    blocks[0].MoveRightUp();
                    blocks[1].MoveRight();
                    blocks[1].MoveRight();
                    blocks[2].MoveLeftUp();
                    break;
            }
        }
    }

    public class Tetramino_T : Tetramino
    {
        public Tetramino_T() : base() { }

        protected override void CreateBlocks(int width, int height)
        {
            blocks.Add(new ImageBlock(Tetris.Resources.BlockHeight, Tetris.Resources.BlockWidth, 0, width, "purple_block"));
            blocks.Add(new ImageBlock(Tetris.Resources.BlockHeight, Tetris.Resources.BlockWidth, height, 0, "purple_block"));
            blocks.Add(new ImageBlock(Tetris.Resources.BlockHeight, Tetris.Resources.BlockWidth, height, width, "purple_block"));
            blocks.Add(new ImageBlock(Tetris.Resources.BlockHeight, Tetris.Resources.BlockWidth, height, 2 * width, "purple_block"));
        }

        public override void MakeRotation(int rotationType)
        {
            switch (rotationType)
            {
                case 0:
                    blocks[0].MoveRightDown();
                    blocks[1].MoveRightUp();
                    blocks[3].MoveLeftDown();
                    break;
                case 1:
                    blocks[0].MoveLeftDown();
                    blocks[1].MoveRightDown();
                    blocks[3].MoveLeftUp();
                    break;
                case 2:
                    blocks[0].MoveLeftUp();
                    blocks[1].MoveLeftDown();
                    blocks[3].MoveRightUp();
                    break;
                case 3:
                    blocks[0].MoveRightUp();
                    blocks[1].MoveLeftUp();
                    blocks[3].MoveRightDown();
                    break;
            }
        }
    }

    public class Tetramino_Z : Tetramino
    {
        public Tetramino_Z() : base() { }

        protected override void CreateBlocks(int width, int height)
        {
            blocks.Add(new ImageBlock(Tetris.Resources.BlockHeight, Tetris.Resources.BlockWidth, 0, 0, "red_block"));
            blocks.Add(new ImageBlock(Tetris.Resources.BlockHeight, Tetris.Resources.BlockWidth, 0, width, "red_block"));
            blocks.Add(new ImageBlock(Tetris.Resources.BlockHeight, Tetris.Resources.BlockWidth, height, width, "red_block"));
            blocks.Add(new ImageBlock(Tetris.Resources.BlockHeight, Tetris.Resources.BlockWidth, height, 2 * width, "red_block"));
        }

        public override void MakeRotation(int rotationType)
        {
            switch (rotationType)
            {
                case 0:
                    blocks[0].MoveRight();
                    blocks[0].MoveRight();
                    blocks[1].MoveRightDown();
                    blocks[3].MoveLeftDown();
                    break;
                case 1:
                    blocks[0].MoveDown();
                    blocks[0].MoveDown();
                    blocks[1].MoveLeftDown();
                    blocks[3].MoveLeftUp();
                    break;
                case 2:
                    blocks[0].MoveLeft();
                    blocks[0].MoveLeft();
                    blocks[1].MoveLeftUp();
                    blocks[3].MoveRightUp();
                    break;
                case 3:
                    blocks[0].MoveUp();
                    blocks[0].MoveUp();
                    blocks[1].MoveRightUp();
                    blocks[3].MoveRightDown();
                    break;
            }
        }
    }


}
