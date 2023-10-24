using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

using System;

/*Aceste este proiectul atribuit temei 2
 * Proiectul implică dezvoltarea unei aplicații 3D în C# cu OpenTK, 
 * unde un pătrat roșu este afișat pe ecran și poate fi controlat de utilizator folosind săgețile.
 * Gherasimescu Emanuel 3131b
 */

internal class Window3D : GameWindow
{
    private float squareSize = 0.2f; // Dimensiunea pătratului
    private Vector2 squarePosition = new Vector2(0.0f, 0.0f); // Poziția pătratului

    public Window3D() : base(800, 600, new GraphicsMode(32, 24, 0, 8))
    {
        VSync = VSyncMode.On;
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        GL.ClearColor(0.5f, 0.5f, 1.0f, 1.0f); // Fundal albastru deschis
    }

    protected override void OnUpdateFrame(FrameEventArgs e)
    {
        base.OnUpdateFrame(e);

        KeyboardState keyboard = Keyboard.GetState();

        if (keyboard.IsKeyDown(Key.Left))
        {
            squarePosition.X -= 0.01f; // Mișcare la stânga
        }
        if (keyboard.IsKeyDown(Key.Right))
        {
            squarePosition.X += 0.01f; // Mișcare la dreapta
        }
        if (keyboard.IsKeyDown(Key.Up))
        {
            squarePosition.Y += 0.01f; // Mișcare în sus
        }
        if (keyboard.IsKeyDown(Key.Down))
        {
            squarePosition.Y -= 0.01f; // Mișcare în jos
        }
    }

    protected override void OnRenderFrame(FrameEventArgs e)
    {
        base.OnRenderFrame(e);

        GL.Clear(ClearBufferMask.ColorBufferBit);

        GL.MatrixMode(MatrixMode.Modelview);
        GL.LoadIdentity();

        GL.Begin(PrimitiveType.Quads); // Desenare pătrat
        GL.Color3(1.0f, 0.0f, 0.0f); // Roșu
        GL.Vertex2(squarePosition.X, squarePosition.Y);
        GL.Vertex2(squarePosition.X + squareSize, squarePosition.Y);
        GL.Vertex2(squarePosition.X + squareSize, squarePosition.Y + squareSize);
        GL.Vertex2(squarePosition.X, squarePosition.Y + squareSize);
        GL.End();

        SwapBuffers();
    }


}